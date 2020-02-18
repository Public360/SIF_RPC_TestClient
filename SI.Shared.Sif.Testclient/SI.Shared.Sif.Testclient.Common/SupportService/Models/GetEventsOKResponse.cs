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

    public partial class GetEventsOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetEventsOKResponse class.
        /// </summary>
        public GetEventsOKResponse() { }

        /// <summary>
        /// Initializes a new instance of the GetEventsOKResponse class.
        /// </summary>
        public GetEventsOKResponse(IList<GetEventsOKResponseEventsItem> events = default(IList<GetEventsOKResponseEventsItem>), int? skippedLogs = default(int?), bool? isEndOfLog = default(bool?), bool? successful = default(bool?), string errorMessage = default(string), string errorDetails = default(string))
        {
            Events = events;
            SkippedLogs = skippedLogs;
            IsEndOfLog = isEndOfLog;
            Successful = successful;
            ErrorMessage = errorMessage;
            ErrorDetails = errorDetails;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Events")]
        public IList<GetEventsOKResponseEventsItem> Events { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SkippedLogs")]
        public int? SkippedLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEndOfLog")]
        public bool? IsEndOfLog { get; set; }

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
