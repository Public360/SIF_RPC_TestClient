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

    public partial class GetFileOKResponseRequestMessageMethod
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetFileOKResponseRequestMessageMethod class.
        /// </summary>
        public GetFileOKResponseRequestMessageMethod() { }

        /// <summary>
        /// Initializes a new instance of the
        /// GetFileOKResponseRequestMessageMethod class.
        /// </summary>
        public GetFileOKResponseRequestMessageMethod(string method = default(string))
        {
            Method = method;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Method")]
        public string Method { get; set; }

    }
}