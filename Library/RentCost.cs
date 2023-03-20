using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RentCost
    {
        public decimal CollateralValue { get; set; }
        public decimal RentalPrice { get; set; }// має калькулювати, decimal!!!! 

        public override string ToString()
        {

            return $"{CollateralValue} {RentalPrice}";
        }
    }
}
