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

    public partial class UpdateDocumentArgsParameterArchiveCodesItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateDocumentArgsParameterArchiveCodesItem class.
        /// </summary>
        public UpdateDocumentArgsParameterArchiveCodesItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateDocumentArgsParameterArchiveCodesItem class.
        /// </summary>
        public UpdateDocumentArgsParameterArchiveCodesItem(string archiveCode = default(string), string archiveType = default(string), int? sort = default(int?), bool? isManualText = default(bool?))
        {
            ArchiveCode = archiveCode;
            ArchiveType = archiveType;
            Sort = sort;
            IsManualText = isManualText;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ArchiveCode")]
        public string ArchiveCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ArchiveType")]
        public string ArchiveType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Sort")]
        public int? Sort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsManualText")]
        public bool? IsManualText { get; set; }

    }
}
