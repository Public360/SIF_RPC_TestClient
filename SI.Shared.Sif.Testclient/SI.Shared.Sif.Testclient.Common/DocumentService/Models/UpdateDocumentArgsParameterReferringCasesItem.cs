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

    public partial class UpdateDocumentArgsParameterReferringCasesItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateDocumentArgsParameterReferringCasesItem class.
        /// </summary>
        public UpdateDocumentArgsParameterReferringCasesItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateDocumentArgsParameterReferringCasesItem class.
        /// </summary>
        public UpdateDocumentArgsParameterReferringCasesItem(string caseNumber = default(string))
        {
            CaseNumber = caseNumber;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CaseNumber")]
        public string CaseNumber { get; set; }

    }
}
