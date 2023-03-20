using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.enums;
namespace Library
{
    public interface IClient : IObject
    {
       
        string FullName { get; set; }
        string Adress { get; set; }
        string Phone { get; set; }
        Categories Category { get; set; }

    }
}
