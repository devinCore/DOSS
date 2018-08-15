using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSS.Business.Intefaces
{
    public interface IWeightLimitable
    {
        decimal WeightLimit { get; set; }
    }
}
