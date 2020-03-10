using SI.Shared.Sif.Testclient.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SI.Shared.Sif.Testclient.Common.Helpers
{
    /// <summary>
    /// This class is intented as a sample on one way of creating a safe and easy to read implementation that uses multiple services. 
    /// 
    /// Creates a instance of all services. Disposing of this object will dispose all services.
    /// Make extentions for all the methodes you need. 
    /// </summary>
    public class ServiceHelper : IDisposable
    {
        public SupportService SupportService { get; private set; }
        public UserService UserService { get; private set; }
        public ContactService ContactService { get; private set; }
        public DocumentService DocumentService { get; private set; }
        public FileService FileService { get; private set; }

        public ServiceHelper(ServiceInformation serviceInformation)
        {
            if (serviceInformation == null)
            {
                throw new ArgumentException("serviceInformation is empty, can not create ServiceHelper");
            }

            try
            {
                SupportService = new SupportService(
                    serviceInformation.SupportServiceUri,
                    serviceInformation.Credentials);

                UserService = new UserService(
                    serviceInformation.UserServiceUri,
                    serviceInformation.Credentials);

                ContactService = new ContactService(
                    serviceInformation.ContactServiceUri,
                    serviceInformation.Credentials);

                DocumentService = new DocumentService(
                    serviceInformation.DocumentServiceUri,
                    serviceInformation.Credentials);

                FileService = new FileService(
                    serviceInformation.FileServiceUri,
                    serviceInformation.Credentials);
            }
            catch (Exception e)
            {
                string errorMessage = "Something went wrong with SupportService creation, se inner exception";
                throw new Exception(errorMessage, e);
            }
        }

        public void Dispose()
        {
            SupportService.Dispose();
            UserService.Dispose();
            ContactService.Dispose();
        }
    }
}
