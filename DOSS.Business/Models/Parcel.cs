using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSS.Business.Models
{
    public class Parcel
    {
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }

        public decimal Volume => Height * Width * Depth;
    }
}
