using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.enums;
namespace Library
{
    public interface IBook : IObject
    {
        
        public string Name { get; set; }
        public string Author { get; set; }
        public Genres Genre { get; set; }

        public int Amount { get; set; }

        public RentCost RentCost { get; set; }

        
    }
}
