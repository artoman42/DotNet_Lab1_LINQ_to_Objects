using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Library.enums;
using LibraryDAL;
using LibraryDAL.QeuryHelperClasses;
namespace LibraryDAL
{
    public class LibraryService : ILibraryService
    {
        private readonly IData _data;
        public LibraryService(IData data)
        {
            _data = data;
        }
        public IEnumerable<Book> SelectAllBooks()
        {
            return from x in _data.Books
                   select x;
        }

       
        public IEnumerable<HelpClassInnerJoinClientSubscription> GetInnerJoin()
        {
            return from c in _data.Clients
                   from s in _data.Subscriptions
                   where c.Id == s.ClientId
                   select new HelpClassInnerJoinClientSubscription {
                       Name = c.FullName,
                       DateOfIssue = s.DateOfIssue,
                       ExpectedReturnDate = s.ExpectedReturnDate,
                       RentalPrice = s.RentalPrice
                   };

        }
        public IEnumerable<HelpClassFindClientsByCategory> SelectClientsByCategory(Categories category = Categories.Student)
        {
            return from x in _data.Clients
                   where x.Category == category
                   select new HelpClassFindClientsByCategory { Name = x.FullName, Category = x.Category};
        } 

        public IEnumerable<Book> GetConcatBook()
        {
            return (from b in _data.Books
                    from s in _data.Subscriptions
                    where b.Id == s.BookId && s.DateOfIssue >= DateTime.Now.AddMonths(-1)
                    select b).Concat(from b in _data.Books
                                     where b.CollateralValue >=23M
                                     select b).Distinct(new BookQualityComparer()).ToList();

                }
        public Dictionary<string, List<Book>> GetAllBooksByClient()
        {

            return _data.Clients
                             .GroupJoin(_data.Books
                             .Join(_data.Subscriptions,
                                    c => c.Id,
                                    cb => cb.BookId,
                                    (c, cb) => new
                                    {
                                        ClientId = cb.ClientId,
                                        BookItem = c
                                    }),
                                b => b.Id,
                                bc => bc.ClientId,
                                (b, clients) => new
                                {
                                    ClientName = b.FullName,
                                    Clients = clients.Select(c => c.BookItem).ToList()
                                }).Where(c=> c.Clients.Count!=0).ToDictionary(b => b.ClientName, c => c.Clients);
        }

        public int GetFullAmountOfBook()
        {
            return _data.Books.Aggregate(0, (sum, a) => sum + a.Amount);
        }

        public IEnumerable<HelpClassGroupJoinBookGenre> GetBooksByGenres()
        {
           
            return _data.Genres.GroupJoin(_data.Books,  g => g.Id, b => b.GenreId,(b, g) =>
               new HelpClassGroupJoinBookGenre
               {
                   Genre = b.pGenre,
                   Books = g
               }
            );
        }
     
       public bool GetBoolAllBooksWithSpecificAmount(int amount = 5)
        {
            
            return _data.Books.All(b => b.Amount>=amount);
        }
       public IEnumerable<Client> GetClientsWithSkipedIndex(int index = 4)
        {
            return _data.Clients.Skip(index);  
        }
        public IEnumerable<HelpClassSortedBooks> GetSortedOldestTakenBooks()
        {
            var res = from x in _data.Books
                      join y in _data.Subscriptions on x.Id equals y.BookId
                      orderby y.DateOfIssue.Year
                      select new HelpClassSortedBooks { Name = x.Name, DateOfIssue = y.DateOfIssue };
            return res;
                      
        }
        
        
        public decimal GetAvgRentProfit()
        {
            var res = from x in _data.Books
                      join y in _data.Subscriptions on x.Id equals y.BookId
                      select y.RentalPrice;

            return res.Average();
        }

        
        public IEnumerable<Book> GetRentedBooksInRange(int begin = -3, int end = 3)
        {
            var res = from x in _data.Books
                      join y in _data.Subscriptions on x.Id equals y.BookId
                      where y.DateOfIssue >= DateTime.Now.AddMonths(begin) && y.DateOfIssue <= DateTime.Now.AddMonths(end) 
                      select x;
            return res;
        }
        public decimal GetPercentOfCategoryClients(Categories category = Categories.Student)
        {
            var res = from c in _data.Clients
                      where c.Category == category
                      select c;
           if (res is null) return 0;
            return (decimal)res.Count() / _data.Clients.Count() * 100M;
        }
       
        public IEnumerable<string> GetAllBooksStartedWithChar(char a = 'Е')
        {
            return from b in _data.Books
                   where b.Name[0] == a
                   select b.Name;
        }
   
        public IEnumerable<HelpClassJoinBookGenres> GetJoinBooksGenres()
        {
            return _data.Books.Join(_data.Genres,
                b => b.GenreId,
                g => g.Id,
                (b, g) => new HelpClassJoinBookGenres
                {
                    Name = b.Name,
                    Genre = g.pGenre
                });
           /* return _data.Co_Authors.Join(_data.Books,
                empLv1 => empLv1.BookId,
                addLv1 => addLv1.Id,
                (empLv1, addLv1) => new { empLv1, addLv1 }
                ).DefaultIfEmpty().Join(
                _data.Authors,
                empLv2 => empLv2.empLv1.AuthorId,
                deptLv2 => deptLv2.Id,
                (empLv2, deptLv2) => new { empLv2, deptLv2 }
                ).Select(c => new HelpClassJoinBookAuthors
                {
                    BookName = c.empLv2.addLv1.Name,
                    Author = c.deptLv2.Name
                }).DefaultIfEmpty().ToList();*/
        }
      
       public IEnumerable<HelpClassDecart> GetDecartMultiply()
        {
            return from b in _data.Books
                   from c in _data.Subscriptions
                   select new HelpClassDecart { SubscriptionId = c.Id, Name = b.Name, DateOfIssue = c.DateOfIssue, ExpectedReturnDate = c.ExpectedReturnDate, RentalPrice = c.RentalPrice };
        }

        public IEnumerable<Client> GetClientsWithOutRent()
        {
            return from c in _data.Clients
                   where !(from s in _data.Subscriptions select s.ClientId).Contains(c.Id)
                   select c;
        }
        public IEnumerable<HelpClassBooksWithHigher> GetBooksWithHihgerRentPrice(decimal limit = 47.55M)
        {
            return from b in _data.Books
                   from s in _data.Subscriptions
                   where s.RentalPrice >= limit
                   select new HelpClassBooksWithHigher { Name = b.Name, RentPrice = s.RentalPrice};
            
        }

        public decimal GetMaxCollateralValue()
        {
            return _data.Books.Max(b => b.CollateralValue);
        }

        
        public Client GetClientFirstHaveLuckyNumber(string number = "666")
        {
            return (from c in _data.Clients
                    where c.Phone.Contains(number)
                    select c).FirstOrDefault();
            
        }
    }
}
