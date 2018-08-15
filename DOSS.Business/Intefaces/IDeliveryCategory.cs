using DOSS.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSS.Business.Intefaces
{
    public interface IDeliveryCategory
    {
        int Priority { get; set; }

        bool IsCorrectCategory(Parcel parcel);

        Delivery CalculateDeliveryCost(Parcel parcel);
    }
}
