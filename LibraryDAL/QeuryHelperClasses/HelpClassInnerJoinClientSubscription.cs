﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.QeuryHelperClasses
{
    public class HelpClassInnerJoinClientSubscription
    {
        public string Name { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public decimal RentalPrice { get; set; }

    }
}
