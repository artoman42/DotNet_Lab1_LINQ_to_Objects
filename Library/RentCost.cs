using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RentCost
    {
        public double CollateralValue { get; set; }
        public double RentalPrice { get; set; }// має калькулювати, decimal!!!! 

        public override string ToString()
        {

            return $"{CollateralValue} {RentalPrice}";
        }
    }
}
