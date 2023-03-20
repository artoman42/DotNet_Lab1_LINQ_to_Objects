using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IBookRent
    {
       IBook Book { get; set; } // 
       IClient Client { get; set; }
       IRentPeriod RentPeriod { get; set; }


    }
}
