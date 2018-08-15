using DOSS.Business.Categories;
using DOSS.Business.Helpers;
using DOSS.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSS.ConsoleApp
{
    /// <summary>
    /// TO DO: Can be done using an IoC Container.
    /// </summary>
    public static class BusinessObjectFactory
    {
        public static Parcel CreateParcel(
                 decimal weight, decimal height, decimal width, decimal depth)
        {
            return new Parcel
            {
                Weight = weight,
                Height = height,
                Width = width,
                Depth = depth
            };
        }

        public static List<DeliveryCategory> CreateDeliveryCategories
            => new List<DeliveryCategory>
            {
                new Reject(),
                new Heavy(),
                new Small(),
                new Medium(),
                new Large()
            };

        public static DeliveryHelper CreateDeliveryHelper
            => new DeliveryHelper(CreateDeliveryCategories);

    }
}
