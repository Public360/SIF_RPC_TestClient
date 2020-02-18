using SI.Shared.Sif.Testclient.Common;
using SI.Shared.Sif.Testclient.Common.Entities;
using SI.Shared.Sif.Testclient.Common.Helpers;
using SI.Shared.Sif.Testclient.Common.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SI.Shared.Sif.Testclient.Console
{
    public static class SampleMethodes
    {
        public static CreateDocumentOKResponse CreateDocument(ServiceHelper serviceHelper, DocumentInfo documentInfo)
        {
            Byte[] bytes = File.ReadAllBytes(@$"{documentInfo.File_Path}");
            String base64file = Convert.ToBase64String(bytes);

            CreateDocumentArgsParameterFilesItem file = new CreateDocumentArgsParameterFilesItem()
            {
                Title = documentInfo.File_Title,
                Format = documentInfo.File_Format,

                Base64Data = base64file
            };

            List<CreateDocumentArgsParameterFilesItem> files = new List<CreateDocumentArgsParameterFilesItem>();
            files.Add(file);

            CreateDocumentArgs createDocumentArgs = new CreateDocumentArgs(new CreateDocumentArgsParameter()
            {
                CaseNumber = documentInfo.CaseNumber,
                Title = documentInfo.Title,
                UnofficialTitle = documentInfo.UnofficialTitle,
                DocumentDate = documentInfo.DocumentDate,
                JournalDate = documentInfo.JournalDate,
                DispatchedDate = documentInfo.DispatchedDate,
                Category = documentInfo.Category,
                Status = documentInfo.Status,
                Files = files
            });

            CreateDocumentOKResponse createDocumentOKResponse = serviceHelper.DocumentService.CreateDocument(createDocumentArgs);
            return createDocumentOKResponse;
        }

        /// <summary>
        /// Getting SIF version(se doc if you get Json deserialization)
        /// </summary>
        /// <returns></returns>
        public static string GetSIFVersion(ServiceHelper serviceHelper) 
        {
            string SIFVersion = serviceHelper.SupportService.GetSIFVersion();
            return SIFVersion;
        }

        public static SynchronizeEnterpriseOKResponse CreateOrUpdateEnterprise(ServiceHelper serviceHelper, string externalID, string name)
        {
            SynchronizeEnterpriseArgsParameter synchronizeEnterpriseArgsParameter = new SynchronizeEnterpriseArgsParameter()
            {
                ExternalID = externalID,
                Name = name
            };

            SynchronizeEnterpriseArgs synchronizeEnterpriseArgs = new SynchronizeEnterpriseArgs(synchronizeEnterpriseArgsParameter);

            SynchronizeEnterpriseOKResponse synchronizeEnterpriseOKResponse = serviceHelper.ContactService.SynchronizeEnterprise(synchronizeEnterpriseArgs);

            return synchronizeEnterpriseOKResponse;
        }

        public static GetEnterprisesOKResponse GetEnterprises(ServiceHelper serviceHelper) 
        {
            GetEnterprisesArgs getEnterpriseArgs = new GetEnterprisesArgs(
                new GetEnterprisesArgsParameter());

            GetEnterprisesOKResponse response = serviceHelper.ContactService.GetEnterprises(getEnterpriseArgs);

            return response;
        }

        public static GetEnterprisesOKResponseEnterprisesItem GetEnterprise(ServiceHelper serviceHelper, string externalID)
        {
            GetEnterprisesArgs getEnterpriseArgs = new GetEnterprisesArgs(
                new GetEnterprisesArgsParameter()
                {
                    ExternalID = externalID
                });

            GetEnterprisesOKResponse response = serviceHelper.ContactService.GetEnterprises(getEnterpriseArgs);

            GetEnterprisesOKResponseEnterprisesItem enterprisesItem;

            try
            {
                enterprisesItem = response.Enterprises.SingleOrDefault();
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("Enterprise search resultet in no enterprises", e);
            }
            catch (InvalidOperationException e)
            {
                throw new InvalidOperationException("Enterprise search has more than one result. Recno shoud be unique, check you data", e);
            }

            return enterprisesItem;
        }

        public static CreateOrUpdateUserAndContactResponse CreateOrUpdateUserAndContact(ServiceHelper serviceHelper, UserInfo userInfo) 
        {
            SynchronizeContactPersonArgsParameter synchronizeContactPersonArgsParameter = new SynchronizeContactPersonArgsParameter()
            {
                ExternalId = userInfo.ExternalId,
                Active = userInfo.Active,
                FirstName = userInfo.FirstName,
                LastName = userInfo.LastName,
                Title = userInfo.Title,
                Enterprise = userInfo.Enterprise
            };

            SynchronizeContactPersonOKResponse synchronizeContactPersonOKResponse = serviceHelper.SynchronizeContact(synchronizeContactPersonArgsParameter);

            List<SynchronizeUserArgsParameterProfilesItem> profilesItems = new List<SynchronizeUserArgsParameterProfilesItem>();

            if (userInfo.ShoudHaveProfile)
            {
                profilesItems.Add(new SynchronizeUserArgsParameterProfilesItem()
                {
                    EnterpriseId = userInfo.Enterprise,
                    Role = "4",
                    FromDate = DateTime.Now,
                });
            }

            SynchronizeUserArgsParameter synchronizeUserArgsParameter = new SynchronizeUserArgsParameter()
            {
                ContactExternalId = userInfo.ExternalId,
                Profiles = profilesItems,
                Login = userInfo.Login,
                IsActive = userInfo.Active
            };

            SynchronizeUserOKResponse synchronizeUserOKResponse = serviceHelper.SynchronizeUser(synchronizeUserArgsParameter);

            CreateOrUpdateUserAndContactResponse createOrUpdateUserAndContactResponse = new CreateOrUpdateUserAndContactResponse()
            {
                synchronizeContactPersonOKResponse = synchronizeContactPersonOKResponse,
                synchronizeUserOKResponset = synchronizeUserOKResponse
            };

            return createOrUpdateUserAndContactResponse;
        }
    }
}
