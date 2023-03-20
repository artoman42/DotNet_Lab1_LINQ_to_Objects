using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Subscription : Object, ISubscription
    {
        //
        public Guid ClientId { get; set; }
        public Guid BookId { get; set; }
        public RentPeriod RentPeriod { get; set; } // одне з двух
        public bool IsActive { get; set; } // одне з двух

        public override string ToString()
        {
            return $"{RentPeriod} {IsActive}";
        }
    }
}
