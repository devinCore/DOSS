using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOSS.Business.Enums;
using DOSS.Business.Intefaces;
using DOSS.Business.Models;

namespace DOSS.Business.Categories
{
    public class Reject : DeliveryCategory, IWeightLimitable
    {
        public decimal WeightLimit { get; set; } = 50;

        public Reject() => Priority = (int)DeliveryCategoryEnum.Rejected;

        public override Delivery CalculateDeliveryCost(Parcel parcel)
        {
            return new Delivery
            {
                Category = DeliveryCategoryEnum.Rejected,
                Cost = null
            };
        }

        public override bool IsCorrectCategory(Parcel parcel)
            => parcel.Weight > WeightLimit;
    }
}
