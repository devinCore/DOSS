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
    public class Heavy : DeliveryCategory, IWeightLimitable
    {
        public Heavy() => Priority = (int)DeliveryCategoryEnum.Heavy;

        public decimal WeightLimit { get; set; } = 10;
        
        public override Delivery CalculateDeliveryCost(Parcel parcel)
        {
            return new Delivery
            {
                Category = DeliveryCategoryEnum.Heavy,
                Cost = (15 * parcel.Weight)
            };
        }

        public override bool IsCorrectCategory(Parcel parcel)
            => parcel.Weight > WeightLimit;
    }
}
