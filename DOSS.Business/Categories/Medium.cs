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
    public class Medium : DeliveryCategory, IVolumeLimitable
    {
        public Medium() => Priority = (int)DeliveryCategoryEnum.Medium;

        public decimal VolumeLimit { get; set; } = 2500;

        public override Delivery CalculateDeliveryCost(Parcel parcel)
            => new Delivery
            {
                Category = DeliveryCategoryEnum.Medium,
                Cost = (0.04m * parcel.Volume)
            };

        public override bool IsCorrectCategory(Parcel parcel)
            => parcel.Volume < VolumeLimit;
    }
}
