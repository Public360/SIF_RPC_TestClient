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

    public partial class SynchronizeEnterpriseOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the SynchronizeEnterpriseOKResponse
        /// class.
        /// </summary>
        public SynchronizeEnterpriseOKResponse() { }

        /// <summary>
        /// Initializes a new instance of the SynchronizeEnterpriseOKResponse
        /// class.
        /// </summary>
        public SynchronizeEnterpriseOKResponse(int? recno = default(int?), bool? successful = default(bool?), string errorMessage = default(string), string errorDetails = default(string))
        {
            Recno = recno;
            Successful = successful;
            ErrorMessage = errorMessage;
            ErrorDetails = errorDetails;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Recno")]
        public int? Recno { get; set; }

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
