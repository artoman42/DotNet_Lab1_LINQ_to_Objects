using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RentPeriod : IRentPeriod
    {
        public DateTime DateOfIssue { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public override string ToString()
        {
            return $"{DateOfIssue} {ExpectedReturnDate}";
        }
    }
}
