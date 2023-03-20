using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IObject
    {
        Guid Id { get;  set; }
        

        void setId()
        {
            Id = Guid.NewGuid();
        }
        Guid getId()
        {
            return Id;
        }
    }
}
