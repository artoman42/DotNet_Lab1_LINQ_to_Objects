using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
namespace LibraryDAL
{
    public interface IData
    {
        IEnumerable<Book> Books { get; }
        IEnumerable<Client> Clients { get; }
        IEnumerable<Genre> Genres { get; }
        IEnumerable<Author> Authors { get; }
        IEnumerable<Subscription> Subscriptions { get; }
        IEnumerable<Co_Author> Co_Authors { get; }
    }
}
