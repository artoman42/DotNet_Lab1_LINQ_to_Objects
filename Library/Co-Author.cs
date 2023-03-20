using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Co_Author:Object<Co_Author>
    {
        public Guid BookId { get; set; }
        public Guid AuthorId { get; set; }
    }
}
