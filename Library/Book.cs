using System;
using System.Collections.Generic;
using Library.enums;
namespace Library
{
    public class Book : Object, IBook
    {
        
        
        public string Name { get; set; }
        public string Author { get; set; } // в окрему таблицю
        public Genres Genre { get; set; } // в окрему таблицю 
        public int Amount { get; set; } 
        public RentCost RentCost { get; set; } // інкапсулювати логіку встановлення 

        public override string ToString()
        {
            return $"{Name} {Author} {Genre} {Amount} {RentCost}";
        }

    }
}
