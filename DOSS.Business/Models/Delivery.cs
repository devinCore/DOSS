using DOSS.Business.Enums;
using System;

namespace DOSS.Business.Models
{
    public class Delivery
    {
        public DeliveryCategoryEnum Category { get; set; }
        public decimal? Cost { get; set; }
    }
}
