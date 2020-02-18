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

    public partial class SynchronizeUserArgsParameterAccessGroupsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SynchronizeUserArgsParameterAccessGroupsItem class.
        /// </summary>
        public SynchronizeUserArgsParameterAccessGroupsItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// SynchronizeUserArgsParameterAccessGroupsItem class.
        /// </summary>
        public SynchronizeUserArgsParameterAccessGroupsItem(string accessGroup = default(string), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?))
        {
            AccessGroup = accessGroup;
            FromDate = fromDate;
            ToDate = toDate;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessGroup")]
        public string AccessGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FromDate")]
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ToDate")]
        public DateTime? ToDate { get; set; }

    }
}
