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

    public partial class SynchronizeEnterpriseArgs
    {
        /// <summary>
        /// Initializes a new instance of the SynchronizeEnterpriseArgs class.
        /// </summary>
        public SynchronizeEnterpriseArgs() { }

        /// <summary>
        /// Initializes a new instance of the SynchronizeEnterpriseArgs class.
        /// </summary>
        public SynchronizeEnterpriseArgs(SynchronizeEnterpriseArgsParameter parameter = default(SynchronizeEnterpriseArgsParameter))
        {
            Parameter = parameter;
        }

        /// <summary>
        /// SynchronizeEnterpriseParameter.
        /// </summary>
        [JsonProperty(PropertyName = "parameter")]
        public SynchronizeEnterpriseArgsParameter Parameter { get; set; }

    }
}