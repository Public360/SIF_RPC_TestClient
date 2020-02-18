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
    /// GetLogsQuery
    /// </summary>
    public partial class GetLogsArgsParameter
    {
        /// <summary>
        /// Initializes a new instance of the GetLogsArgsParameter class.
        /// </summary>
        public GetLogsArgsParameter() { }

        /// <summary>
        /// Initializes a new instance of the GetLogsArgsParameter class.
        /// </summary>
        public GetLogsArgsParameter(string entityName = default(string), int? entityRecno = default(int?), int? maxReturnedLogs = default(int?), int? page = default(int?), string sortCriterion = default(string))
        {
            EntityName = entityName;
            EntityRecno = entityRecno;
            MaxReturnedLogs = maxReturnedLogs;
            Page = page;
            SortCriterion = sortCriterion;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityName")]
        public string EntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityRecno")]
        public int? EntityRecno { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxReturnedLogs")]
        public int? MaxReturnedLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Page")]
        public int? Page { get; set; }

        /// <summary>
        /// Possible values include: 'RecnoDescending', 'RecnoAscending'
        /// </summary>
        [JsonProperty(PropertyName = "SortCriterion")]
        public string SortCriterion { get; set; }

    }
}