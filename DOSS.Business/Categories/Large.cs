using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOSS.Business.Enums;
using DOSS.Business.Models;

namespace DOSS.Business.Categories
{
    public class Large : DeliveryCategory
    {
        public Large() => Priority = (int)DeliveryCategoryEnum.Large;

        public override Delivery CalculateDeliveryCost(Parcel parcel)
        {
            return new Delivery
            {
                Category = DeliveryCategoryEnum.Large,
                Cost = 0.03m * parcel.Volume
            };
        }

        public override bool IsCorrectCategory(Parcel parcel)
            => true;
    }
}
