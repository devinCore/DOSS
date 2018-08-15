using DOSS.Business.Categories;
using DOSS.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSS.Business.Helpers
{
    public class DeliveryHelper
    {
        private readonly List<DeliveryCategory> _deliveryCategories;

        public DeliveryHelper(List<DeliveryCategory> deliveryCategories)
        {
            _deliveryCategories = deliveryCategories;
        }

        public DeliveryResult GetDelivery(Parcel parcel)
        {
            // Iterate per priority
            DeliveryResult deliveryResult = null;
            var categories = _deliveryCategories.OrderBy(p => p.Priority);

            foreach (var category in categories)
            {
                if (category.IsCorrectCategory(parcel))
                {
                    deliveryResult = new DeliveryResult(category.CalculateDeliveryCost(parcel));
                    return deliveryResult;
                }
            }

            return deliveryResult;
        }
    }
}
