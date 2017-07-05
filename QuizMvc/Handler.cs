using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace QuizMvc
{
    public class HeaderHandler : DelegatingHandler
    {
        private string apiKey;

        public HeaderHandler(string apiSubscriptionKey) {
            apiKey = apiSubscriptionKey;
        }

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if(apiKey != null && apiKey != "")
                request.Headers.Add("Ocp-Apim-Subscription-Key", apiKey);

            return await base.SendAsync(request, cancellationToken);
        }
     }
}
