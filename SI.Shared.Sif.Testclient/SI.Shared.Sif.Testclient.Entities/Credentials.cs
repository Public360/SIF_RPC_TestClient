using Microsoft.Rest;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace SI.Shared.Sif.Testclient.Common.Entities
{
    public class Credentials : ServiceClientCredentials
    {
        private string AuthKey { get; set; }

        public Credentials(string _AuthKey)
        {
            AuthKey = _AuthKey;
        }

        public override void InitializeServiceClient<T>(ServiceClient<T> client)
        {
            //This can be used to get authkey and mediatype from config based on type T
        }

        public override async Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            if (AuthKey == null)
            {
                throw new InvalidOperationException("Token provider cannot be null");
            }

            request.Headers.Add("Authorization", "authkey " + AuthKey);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  

            await base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
}
