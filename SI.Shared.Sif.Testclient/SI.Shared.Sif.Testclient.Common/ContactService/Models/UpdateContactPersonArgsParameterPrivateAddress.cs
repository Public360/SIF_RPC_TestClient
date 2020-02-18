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

    public partial class UpdateContactPersonArgsParameterPrivateAddress
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateContactPersonArgsParameterPrivateAddress class.
        /// </summary>
        public UpdateContactPersonArgsParameterPrivateAddress() { }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateContactPersonArgsParameterPrivateAddress class.
        /// </summary>
        public UpdateContactPersonArgsParameterPrivateAddress(string streetAddress = default(string), string state = default(string), string zipCode = default(string), string zipPlace = default(string), string country = default(string), string county = default(string), string area = default(string))
        {
            StreetAddress = streetAddress;
            State = state;
            ZipCode = zipCode;
            ZipPlace = zipPlace;
            Country = country;
            County = county;
            Area = area;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StreetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ZipCode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ZipPlace")]
        public string ZipPlace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "County")]
        public string County { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Area")]
        public string Area { get; set; }

    }
}
