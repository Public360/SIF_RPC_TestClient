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

    public partial class CreateDocumentArgsParameterContactsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateDocumentArgsParameterContactsItem class.
        /// </summary>
        public CreateDocumentArgsParameterContactsItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateDocumentArgsParameterContactsItem class.
        /// </summary>
        public CreateDocumentArgsParameterContactsItem(string role = default(string), string referenceNumber = default(string), string externalId = default(string), bool? isUnofficial = default(bool?), string dispatchChannel = default(string))
        {
            Role = role;
            ReferenceNumber = referenceNumber;
            ExternalId = externalId;
            IsUnofficial = isUnofficial;
            DispatchChannel = dispatchChannel;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role")]
        public string Role { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferenceNumber")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsUnofficial")]
        public bool? IsUnofficial { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DispatchChannel")]
        public string DispatchChannel { get; set; }

    }
}
