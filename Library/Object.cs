using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    //this one should be generic 
    //interface is not needed here same as in book
    //Object<TKey>
    public class Object<TKey>
    {
        //line 14 is the same as line 21-29
        public Guid Id { get; set; }

        public Object()
        {
            Id = Guid.NewGuid();
        }
       
    }
}
