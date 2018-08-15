using DOSS.Business.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSS.Business.Models
{
    public class DeliveryResult
    {
        public DeliveryResult(Delivery delivery)
        {
            Category = delivery.Category.ToString();
            Cost = delivery.Cost.HasValue ? delivery.Cost.Value.ToString("C", new CultureInfo("en-US")) : "N/A";
        }

        public string Category { get; set; }
        public string Cost { get; set; }
    }
}
