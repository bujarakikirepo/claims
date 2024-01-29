﻿using Domain.Enums;

namespace Domain.Models
{
    public class CreateClaimModel
    {
        public string CoverId { get; set; }
        public string Name { get; set; }
        public ClaimType Type { get; set; }
        public decimal DamageCost { get; set; }
    }
}
