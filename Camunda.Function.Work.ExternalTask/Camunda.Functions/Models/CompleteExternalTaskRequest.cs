using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Functions.Models
{
    public class CompleteExternalTaskRequest
    {
        [JsonProperty("workerId")]
        public string WorkerId { get; set; }

        [JsonProperty("variables")]
        public Dictionary<string, Variables> Variables { get; set; }
    }
}