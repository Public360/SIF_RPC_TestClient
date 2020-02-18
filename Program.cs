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
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();


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
                                var response = SampleMethodes.CreateDocument(serviceHelper, documentInfo);
                                System.Console.WriteLine($"respons successful = { response.Successful }");
                                break;
                            case "GetSIFVersion":
                                var response1 = SampleMethodes.GetSIFVersion(serviceHelper);
                                System.Console.WriteLine($"SIF version = { response1 }");
                                break;
                            case "GetEnterprises":
                                var response2 = SampleMethodes.GetEnterprises(serviceHelper);
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
                                System.Console.WriteLine($"respons successful = { response4.Successful }");
                                break;
                            case "CreateOrUpdateUserAndContact":
                                var response5 = SampleMethodes.CreateOrUpdateUserAndContact(serviceHelper, userInfo);
                                System.Console.WriteLine($"Contact respons successful = { response5.synchronizeContactPersonOKResponse.Successful }");
                                System.Console.WriteLine($"User respons successful = { response5.synchronizeUserOKResponset.Successful }");
                                break;
                        }
                    }
                }
                catch (Exception e)
                {
                    //This would be the place to write errors to a log if needed
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine($"Operation = {arg}");
                    System.Console.WriteLine($"ErrorMessage = {e.Message}");
                    System.Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
