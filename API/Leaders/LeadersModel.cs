using System;
using Newtonsoft.Json;

namespace EnQ_Admin.API.Leaders
{
    public class LeadersModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("startAt")]
        public string StartAt { get; set; }
        
        [JsonProperty("endAt")]
        public string EndAt { get; set; }
        
        [JsonProperty("users")]
        public Array Users { get; set; }
    }
}