using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IRentCost
    {
        double CollateralValue { get; set; } 
        double RentalPrice { get; set; }

    }
}
