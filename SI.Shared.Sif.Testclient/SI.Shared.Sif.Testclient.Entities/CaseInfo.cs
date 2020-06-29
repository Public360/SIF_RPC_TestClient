using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SI.Shared.Sif.Testclient.Common.Entities
{
    [JsonObject("CaseInfo")]
    public class CaseInfo
    {
        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Project")]
        public string Project { get; set; }

        [JsonProperty("CreateProject")]
        public bool CreateProject { get; set; }
    }
}
