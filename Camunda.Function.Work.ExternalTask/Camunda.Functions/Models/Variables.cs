using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Functions.Models
{
    public class Variables
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}