using DOSS.Business.Intefaces;
using DOSS.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSS.Business.Categories
{
    public abstract class DeliveryCategory : IDeliveryCategory
    {
        public int Priority { get; set; }

        public abstract Delivery CalculateDeliveryCost(Parcel parcel);

        public abstract bool IsCorrectCategory(Parcel parcel);
    }
}
