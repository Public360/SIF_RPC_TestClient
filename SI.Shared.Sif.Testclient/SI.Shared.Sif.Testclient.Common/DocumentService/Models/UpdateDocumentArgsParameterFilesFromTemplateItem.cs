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

    public partial class UpdateDocumentArgsParameterFilesFromTemplateItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateDocumentArgsParameterFilesFromTemplateItem class.
        /// </summary>
        public UpdateDocumentArgsParameterFilesFromTemplateItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateDocumentArgsParameterFilesFromTemplateItem class.
        /// </summary>
        public UpdateDocumentArgsParameterFilesFromTemplateItem(string title = default(string), string templateId = default(string))
        {
            Title = title;
            TemplateId = templateId;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TemplateId")]
        public string TemplateId { get; set; }

    }
}
