﻿using Domain.Enums;
using Newtonsoft.Json;

namespace Domain.Entities
{
    public class Claim
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "coverId")]
        public string CoverId { get; set; }
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "claimType")]
        public ClaimType Type { get; set; }
        [JsonProperty(PropertyName = "damageCost")]
        public decimal DamageCost { get; set; }

    }
}
