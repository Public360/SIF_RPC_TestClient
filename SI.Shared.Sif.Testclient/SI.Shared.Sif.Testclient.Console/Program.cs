using Microsoft.Rest;
using SI.Shared.Sif.Testclient.Common;
using SI.Shared.Sif.Testclient.Common.Models;
using SI.Shared.Sif.Testclient.Common.Entities;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Globalization;
using Newtonsoft.Json;
using System.IO;
using SI.Shared.Sif.Testclient.Common.Helpers;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;
using System.Threading;

namespace SI.Shared.Sif.Testclient.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                string arg = args[0];

                try
                {


                    IConfiguration config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", false, true)
                        .Build();

                    Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

                    string getEnterpriseExternalId = config["GetEnterpriseExternalId"];
                    string createOrUpdateEnterpriseExternalID = config["CreateOrUpdateEnterpriseExternalID"];
                    string createOrUpdateEnterpriseName = config["CreateOrUpdateEnterpriseName"];

                    DocumentInfo documentInfo = config.GetSection("DocumentInfo").Get<DocumentInfo>();
                    UserInfo userInfo = config.GetSection("UserInfo").Get<UserInfo>();
                    var serviceConfig = config.GetSection("ServiceInformation");
                    var getEnterpriseConfig = config.GetSection("GetEnterprise");
                    var createOrUpdateEnterpriseConfig = config.GetSection("CreateOrUpdateEnterprise");

                    ServiceInformation serviceInformation = new ServiceInformation(
                        serviceConfig["authkey"],
                        serviceConfig["baseUrl"]);

                    using (ServiceHelper serviceHelper = new ServiceHelper(serviceInformation))
                    {
                        switch (arg)
                        {
                            case "CreateDocument":
                                CreateDocument(serviceHelper, documentInfo);
                                break;
                            case "GetSIFVersion":
                                var response1 = SampleMethodes.GetSIFVersion(serviceHelper);
                                System.Console.WriteLine($"SIF version = { response1 }");
                                break;
                            case "GetEnterprises":
                                var response2 = SampleMethodes.GetEnterprises(serviceHelper);
                                LogToConsole(response2.Successful ?? false, response2.ErrorMessage, response2.ErrorDetails);
                                System.Console.WriteLine($"Returned { response2.TotalCount } enterprises");
                                break;
                            case "GetEnterprise":
                                var response3 = SampleMethodes.GetEnterprise(serviceHelper, getEnterpriseConfig["ExternalId"]);
                                System.Console.WriteLine($"Returned enterprise with name = { response3.Name }");
                                break;
                            case "CreateOrUpdateEnterprise":
                                var response4 = SampleMethodes.CreateOrUpdateEnterprise(serviceHelper,
                                    createOrUpdateEnterpriseConfig["ExternalId"],
                                    createOrUpdateEnterpriseConfig["Name"]);
                                LogToConsole(response4.Successful ?? false, response4.ErrorMessage, response4.ErrorDetails);
                                break;
                            case "CreateOrUpdateUserAndContact":
                                var response5 = SampleMethodes.CreateOrUpdateUserAndContact(serviceHelper, userInfo);
                                LogToConsole(response5);
                                break;
                        }
                    }
                }
                catch(HttpOperationException he)
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine($"Operation = {arg}, encountered an exeption");
                    System.Console.WriteLine($"ErrorMessage = {he.Message}");
                    System.Console.WriteLine($"ResponseHeaders = {he.Response.Headers}");
                    System.Console.WriteLine($"ResponseReason = {he.Response.ReasonPhrase}");
                    System.Console.WriteLine($"ResponseContent = {he.Response.Content}");
                    System.Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e)
                {
                    //This would be the place to write errors to a log if needed
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine($"Operation = {arg}, encountered an exeption");
                    System.Console.WriteLine($"ErrorMessage = {e.Message}");
                    System.Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static void CreateDocument(ServiceHelper serviceHelper, DocumentInfo documentInfo)
        {
            if (documentInfo.StreamFile)
            {
                var response = SampleMethodes.CreateDocumentWithFileStream(serviceHelper, documentInfo);
                LogToConsole(response);
            }
            else
            {
                var response = SampleMethodes.CreateDocument(serviceHelper, documentInfo);
                LogToConsole(response.Successful ?? false, response.ErrorMessage, response.ErrorDetails);
            }
        }

        private static void LogToConsole(bool successful, string errorMessage, string errorDetails)
        {
            System.Console.WriteLine($"respons successful = { successful }");

            if(successful == false)
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"respons ErrorMessage = { errorMessage }");
                System.Console.WriteLine($"respons ErrorDetails = { errorDetails }");
                System.Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void LogToConsole(CreateOrUpdateUserAndContactResponse response)
        {
            System.Console.WriteLine($"User respons: ");
            LogToConsole(response.synchronizeUserOKResponset.Successful ?? false,
                response.synchronizeUserOKResponset.ErrorMessage,
                response.synchronizeUserOKResponset.ErrorDetails);

            System.Console.WriteLine($"Contact respons: ");
            LogToConsole(response.synchronizeContactPersonOKResponse.Successful ?? false,
                response.synchronizeContactPersonOKResponse.ErrorMessage,
                response.synchronizeContactPersonOKResponse.ErrorDetails);
        }

        private static void LogToConsole(CreateDocumentWithFileStreamResponse response)
        {
            System.Console.WriteLine($"File respons: ");
            LogToConsole(response.uploadOKResponse.Successful ?? false,
                response.uploadOKResponse.ErrorMessage,
                response.uploadOKResponse.ErrorDetails);

            System.Console.WriteLine($"Document respons: ");
            LogToConsole(response.createDocumentOKResponse.Successful ?? false,
                response.createDocumentOKResponse.ErrorMessage,
                response.createDocumentOKResponse.ErrorDetails);
        }
    }
}
