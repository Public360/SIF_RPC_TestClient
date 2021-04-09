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

    public partial class GetProjectsOKResponseProjectsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetProjectsOKResponseProjectsItem class.
        /// </summary>
        public GetProjectsOKResponseProjectsItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// GetProjectsOKResponseProjectsItem class.
        /// </summary>
        public GetProjectsOKResponseProjectsItem(int? recno = default(int?), string projectNumber = default(string), GetProjectsOKResponseProjectsItemExternalId externalId = default(GetProjectsOKResponseProjectsItemExternalId), string title = default(string), string categoryDescription = default(string), string statusDescription = default(string), DateTime? startDate = default(DateTime?), string accessGroup = default(string), string notes = default(string), GetProjectsOKResponseProjectsItemResponsiblePerson responsiblePerson = default(GetProjectsOKResponseProjectsItemResponsiblePerson), string responsiblePersonName = default(string), object contacts = default(object))
        {
            Recno = recno;
            ProjectNumber = projectNumber;
            ExternalId = externalId;
            Title = title;
            CategoryDescription = categoryDescription;
            StatusDescription = statusDescription;
            StartDate = startDate;
            AccessGroup = accessGroup;
            Notes = notes;
            ResponsiblePerson = responsiblePerson;
            ResponsiblePersonName = responsiblePersonName;
            Contacts = contacts;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Recno")]
        public int? Recno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProjectNumber")]
        public string ProjectNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalId")]
        public GetProjectsOKResponseProjectsItemExternalId ExternalId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CategoryDescription")]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StatusDescription")]
        public string StatusDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessGroup")]
        public string AccessGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Notes")]
        public string Notes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePerson")]
        public GetProjectsOKResponseProjectsItemResponsiblePerson ResponsiblePerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponsiblePersonName")]
        public string ResponsiblePersonName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Contacts")]
        public object Contacts { get; set; }

    }
}