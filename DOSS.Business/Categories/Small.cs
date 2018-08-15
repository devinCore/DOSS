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
    public class Small : DeliveryCategory, IVolumeLimitable
    {
        public decimal VolumeLimit { get; set; } = 1500;

        public Small() => Priority = (int)DeliveryCategoryEnum.Small;

        public override Delivery CalculateDeliveryCost(Parcel parcel)
           => new Delivery
           {
               Category = DeliveryCategoryEnum.Small,
               Cost = (0.05m * parcel.Volume)
           };

        public override bool IsCorrectCategory(Parcel parcel)
            => parcel.Volume < VolumeLimit;
    }
}
