using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface ISubscription : IObject
    {

        Guid ClientId { get; set; }
        Guid BookId { get; set; }
        RentPeriod RentPeriod { get; set; }
        bool IsActive { get; set; }
      
    }
}
