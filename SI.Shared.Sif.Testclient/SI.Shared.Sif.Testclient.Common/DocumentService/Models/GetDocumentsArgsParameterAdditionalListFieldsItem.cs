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

    public partial class GetDocumentsArgsParameterAdditionalListFieldsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetDocumentsArgsParameterAdditionalListFieldsItem class.
        /// </summary>
        public GetDocumentsArgsParameterAdditionalListFieldsItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// GetDocumentsArgsParameterAdditionalListFieldsItem class.
        /// </summary>
        public GetDocumentsArgsParameterAdditionalListFieldsItem(string name = default(string), object value = default(object))
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public object Value { get; set; }

    }
}
