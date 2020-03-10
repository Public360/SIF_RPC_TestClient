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

    public partial class UploadAndCheckInFileFromExternalControlOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UploadAndCheckInFileFromExternalControlOKResponse class.
        /// </summary>
        public UploadAndCheckInFileFromExternalControlOKResponse() { }

        /// <summary>
        /// Initializes a new instance of the
        /// UploadAndCheckInFileFromExternalControlOKResponse class.
        /// </summary>
        public UploadAndCheckInFileFromExternalControlOKResponse(string fileRecno = default(string), bool? successful = default(bool?), string errorMessage = default(string), string errorDetails = default(string))
        {
            FileRecno = fileRecno;
            Successful = successful;
            ErrorMessage = errorMessage;
            ErrorDetails = errorDetails;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileRecno")]
        public string FileRecno { get; set; }

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