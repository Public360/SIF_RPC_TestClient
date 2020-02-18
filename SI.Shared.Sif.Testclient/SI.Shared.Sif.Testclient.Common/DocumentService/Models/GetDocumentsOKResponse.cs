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

    public partial class GetDocumentsOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetDocumentsOKResponse class.
        /// </summary>
        public GetDocumentsOKResponse() { }

        /// <summary>
        /// Initializes a new instance of the GetDocumentsOKResponse class.
        /// </summary>
        public GetDocumentsOKResponse(IList<GetDocumentsOKResponseDocumentsItem> documents = default(IList<GetDocumentsOKResponseDocumentsItem>), int? totalPageCount = default(int?), int? totalCount = default(int?), bool? successful = default(bool?), string errorMessage = default(string), string errorDetails = default(string))
        {
            Documents = documents;
            TotalPageCount = totalPageCount;
            TotalCount = totalCount;
            Successful = successful;
            ErrorMessage = errorMessage;
            ErrorDetails = errorDetails;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Documents")]
        public IList<GetDocumentsOKResponseDocumentsItem> Documents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalPageCount")]
        public int? TotalPageCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Successful")]
        public bool? Successful { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorDetails")]
        public string ErrorDetails { get; set; }

    }
}
