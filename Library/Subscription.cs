using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Subscription : Object<Subscription>
    {
        //
        public Guid ClientId { get; set; }
        public Guid BookId { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public bool IsActive { get; set; } // одне з двух
        public decimal CollateralValue { get; set; }
        public decimal RentalPrice { get {
                int expectedDuration = (ExpectedReturnDate - DateOfIssue).Days;
                decimal PricePerDay = 1.5M;
                return PricePerDay * expectedDuration;

            } }
        public RentCost RentCost { get; } // інкапсулювати логіку встановлення 

       
        public override string ToString()
        {
            return $"Взято {DateOfIssue}, очікувана дата повернення{ExpectedReturnDate} {IsActive}";
        }
    }
}
