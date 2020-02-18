﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SI.Shared.Sif.Testclient.Common.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// CreateDocumentParameter
    /// </summary>
    public partial class CreateDocumentArgsParameter
    {
        /// <summary>
        /// Initializes a new instance of the CreateDocumentArgsParameter
        /// class.
        /// </summary>
        public CreateDocumentArgsParameter() { }

        /// <summary>
        /// Initializes a new instance of the CreateDocumentArgsParameter
        /// class.
        /// </summary>
        public CreateDocumentArgsParameter(string caseNumber = default(string), CreateDocumentArgsParameterCaseExternalId caseExternalId = default(CreateDocumentArgsParameterCaseExternalId), string archive = default(string), string defaultValueSet = default(string), string aDContextUser = default(string), string title = default(string), string unofficialTitle = default(string), DateTime? documentDate = default(DateTime?), string category = default(string), string status = default(string), string accessCode = default(string), string accessGroup = default(string), int? responsiblePersonRecno = default(int?), string responsiblePersonIdNumber = default(string), string responsiblePersonEmail = default(string), string responsiblePersonUserId = default(string), int? responsibleEnterpriseRecno = default(int?), string responsibleEnterpriseNumber = default(string), IList<CreateDocumentArgsParameterContactsItem> contacts = default(IList<CreateDocumentArgsParameterContactsItem>), IList<CreateDocumentArgsParameterUnregisteredContactsItem> unregisteredContacts = default(IList<CreateDocumentArgsParameterUnregisteredContactsItem>), string sendersReference = default(string), string paragraph = default(string), DateTime? journalDate = default(DateTime?), DateTime? dispatchedDate = default(DateTime?), bool? filedOnPaper = default(bool?), string notes = default(string), IList<CreateDocumentArgsParameterReferringCasesItem> referringCases = default(IList<CreateDocumentArgsParameterReferringCasesItem>), IList<CreateDocumentArgsParameterReferringDocumentsItem> referringDocuments = default(IList<CreateDocumentArgsParameterReferringDocumentsItem>), IList<string> keywords = default(IList<string>), IList<CreateDocumentArgsParameterFilesFromTemplateItem> filesFromTemplate = default(IList<CreateDocumentArgsParameterFilesFromTemplateItem>), IList<CreateDocumentArgsParameterFilesItem> files = default(IList<CreateDocumentArgsParameterFilesItem>), IList<CreateDocumentArgsParameterRemarksItem> remarks = default(IList<CreateDocumentArgsParameterRemarksItem>), string project = default(string), IList<CreateDocumentArgsParameterAdditionalFieldsItem> additionalFields = default(IList<CreateDocumentArgsParameterAdditionalFieldsItem>), IList<CreateDocumentArgsParameterEstatesItem> estates = default(IList<CreateDocumentArgsParameterEstatesItem>), string revisionStatus = default(string), string subArchive = default(string), IList<CreateDocumentArgsParameterArchiveCodesItem> archiveCodes = default(IList<CreateDocumentArgsParameterArchiveCodesItem>), string recordType = default(string))
        {
            CaseNumber = caseNumber;
            CaseExternalId = caseExternalId;
            Archive = archive;
            DefaultValueSet = defaultValueSet;
            ADContextUser = aDContextUser;
            Title = title;
            UnofficialTitle = unofficialTitle;
            DocumentDate = documentDate;
            Category = category;
            Status = status;
            AccessCode = accessCode;
            AccessGroup = accessGroup;
            ResponsiblePersonRecno = responsiblePersonRecno;
            ResponsiblePersonIdNumber = responsiblePersonIdNumber;
            ResponsiblePersonEmail = responsiblePersonEmail;
            ResponsiblePersonUserId = responsiblePersonUserId;
            ResponsibleEnterpriseRecno = responsibleEnterpriseRecno;
            ResponsibleEnterpriseNumber = responsibleEnterpriseNumber;
            Contacts = contacts;
            UnregisteredContacts = unregisteredContacts;
            SendersReference = sendersReference;
            Paragraph = paragraph;
            JournalDate = journalDate;
            DispatchedDate = dispatchedDate;
            FiledOnPaper = filedOnPaper;
            Notes = notes;
            ReferringCases = referringCases;
            ReferringDocuments = referringDocuments;
            Keywords = keywords;
            FilesFromTemplate = filesFromTemplate;
            Files = files;
            Remarks = remarks;
            Project = project;
            AdditionalFields = additionalFields;
            Estates = estates;
            RevisionStatus = revisionStatus;
            SubArchive = subArchive;
            ArchiveCodes = archiveCodes;
            RecordType = recordType;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CaseNumber")]
        public string CaseNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CaseExternalId")]
        public CreateDocumentArgsParameterCaseExternalId CaseExternalId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Archive")]
        public string Archive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultValueSet")]
        public string DefaultValueSet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ADContextUser")]
        public string ADContextUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UnofficialTitle")]
        public string UnofficialTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DocumentDate")]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessCode")]
        public string AccessCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessGroup")]
        public string AccessGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePersonRecno")]
        public int? ResponsiblePersonRecno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePersonIdNumber")]
        public string ResponsiblePersonIdNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePersonEmail")]
        public string ResponsiblePersonEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePersonUserId")]
        public string ResponsiblePersonUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsibleEnterpriseRecno")]
        public int? ResponsibleEnterpriseRecno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsibleEnterpriseNumber")]
        public string ResponsibleEnterpriseNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contacts")]
        public IList<CreateDocumentArgsParameterContactsItem> Contacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UnregisteredContacts")]
        public IList<CreateDocumentArgsParameterUnregisteredContactsItem> UnregisteredContacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SendersReference")]
        public string SendersReference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Paragraph")]
        public string Paragraph { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "JournalDate")]
        public DateTime? JournalDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DispatchedDate")]
        public DateTime? DispatchedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FiledOnPaper")]
        public bool? FiledOnPaper { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Notes")]
        public string Notes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferringCases")]
        public IList<CreateDocumentArgsParameterReferringCasesItem> ReferringCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferringDocuments")]
        public IList<CreateDocumentArgsParameterReferringDocumentsItem> ReferringDocuments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Keywords")]
        public IList<string> Keywords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FilesFromTemplate")]
        public IList<CreateDocumentArgsParameterFilesFromTemplateItem> FilesFromTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Files")]
        public IList<CreateDocumentArgsParameterFilesItem> Files { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Remarks")]
        public IList<CreateDocumentArgsParameterRemarksItem> Remarks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Project")]
        public string Project { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AdditionalFields")]
        public IList<CreateDocumentArgsParameterAdditionalFieldsItem> AdditionalFields { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Estates")]
        public IList<CreateDocumentArgsParameterEstatesItem> Estates { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RevisionStatus")]
        public string RevisionStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubArchive")]
        public string SubArchive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ArchiveCodes")]
        public IList<CreateDocumentArgsParameterArchiveCodesItem> ArchiveCodes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecordType")]
        public string RecordType { get; set; }

    }
}