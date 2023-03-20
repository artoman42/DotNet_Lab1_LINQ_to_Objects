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
        static List<Book> Books { get; }
        static List<Client> Clients { get; }
        static List<Genre> Genres { get; }
        static List<Author> Authors { get; }
        static List<Subscription> Subscriptions { get; }
        static List<Co_Author> Co_Authors { get; }
    }
}
