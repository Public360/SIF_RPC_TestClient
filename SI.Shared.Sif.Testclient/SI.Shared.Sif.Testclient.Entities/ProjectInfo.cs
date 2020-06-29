using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SI.Shared.Sif.Testclient.Common.Entities
{
    [JsonObject("ProjectInfo")]
    public class ProjectInfo
    {
        [JsonProperty("Title")]
        public string Title { get; set; }
    }
}
