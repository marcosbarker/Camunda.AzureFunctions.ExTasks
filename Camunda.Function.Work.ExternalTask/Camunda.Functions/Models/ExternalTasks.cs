using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Functions.Models
{
    public class ExternalTasks
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("workerId")]
        public string WorkerId { get; set; }

        [JsonProperty("topicName")]
        public string TopicName { get; set; }

        [JsonProperty("variables")]
        public Dictionary<string, object> Variables { get; set; }

        [JsonProperty("businessKey")]
        public string BusinessKey { get; set; }
    }
}
