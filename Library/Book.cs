using System;
using System.Collections.Generic;
using Library.enums;
namespace Library
{
    public class Book : Object<Book>
    {
        
        
        public string Name { get; set; }
        // public string Author { get; set; } // в окрему таблицю
        //public Genres Genre { get; set; } // в окрему таблицю 
        public int Amount { get; set; } 
        public int GenreId { get; set; }
        public decimal CollateralValue { get; set; }
        public override string ToString()
        {
            return $"{Name}  {Amount} {CollateralValue}";
        }

    }
}
