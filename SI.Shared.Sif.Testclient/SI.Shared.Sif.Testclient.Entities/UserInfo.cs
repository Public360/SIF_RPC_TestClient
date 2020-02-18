using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SI.Shared.Sif.Testclient.Common.Entities
{
    [JsonObject("UserInfo")]
    public class UserInfo
    {
        [JsonProperty("File_Path")]
        public string ExternalId { get; set; }

        [JsonProperty("Active")]
        public bool Active { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Enterprise")]
        public string Enterprise { get; set; }

        [JsonProperty("Login")]
        public string Login { get; set; }

        [JsonProperty("ShoudHaveProfile")]
        public bool ShoudHaveProfile { get; set; }

        public static UserInfo CreateSample()
        {

            //78ad078b-ca54-47d3-a7a0-847c443103af
            //7920d503-0b20-47d4-969c-0f62f95241c3
            Guid contactExternalId = new Guid("bc9a04c9-f380-4e29-8b78-5c14ca52bea4");

            return new UserInfo()
            {
                ExternalId = contactExternalId.ToString(),
                Active = false,
                FirstName = "TeamA",
                LastName = "Test",
                Title = "Solution Consultant",
                Enterprise = "7943018e-1934-437b-8fe6-49362ed8d043",
                Login = "TeamA.test@tieto.com",
                ShoudHaveProfile = true
            };
        }
    }
}
