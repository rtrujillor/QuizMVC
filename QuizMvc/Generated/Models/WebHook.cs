// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace QuizMvc.QuizApi.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class WebHook
    {
        /// <summary>
        /// Initializes a new instance of the WebHook class.
        /// </summary>
        public WebHook() { }

        /// <summary>
        /// Initializes a new instance of the WebHook class.
        /// </summary>
        public WebHook(string webHookUri, string id = default(string), string secret = default(string), string description = default(string), bool? isPaused = default(bool?), IList<string> filters = default(IList<string>), IDictionary<string, string> headers = default(IDictionary<string, string>), IDictionary<string, object> properties = default(IDictionary<string, object>))
        {
            Id = id;
            WebHookUri = webHookUri;
            Secret = secret;
            Description = description;
            IsPaused = isPaused;
            Filters = filters;
            Headers = headers;
            Properties = properties;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WebHookUri")]
        public string WebHookUri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Secret")]
        public string Secret { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPaused")]
        public bool? IsPaused { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Filters")]
        public IList<string> Filters { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Headers")]
        public IDictionary<string, string> Headers { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Properties")]
        public IDictionary<string, object> Properties { get; private set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (WebHookUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WebHookUri");
            }
        }
    }
}
