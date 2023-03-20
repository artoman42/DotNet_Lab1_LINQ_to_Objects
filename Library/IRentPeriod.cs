using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IRentPeriod
    {
        DateTime DateOfIssue { get; set; }
        DateTime ExpectedReturnDate { get; set; }
    }
}
