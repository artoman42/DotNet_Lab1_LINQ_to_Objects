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
       
        public IEnumerable<Book> SelectAllBooks()
        {
            return from x in Data.Books
                   select x;
        }

       
        public IEnumerable<HelpClassInnerJoinClientSubscription> GetInnerJoin()
        {
            return from c in Data.Clients
                   from s in Data.Subscriptions
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
            return from x in Data.Clients
                   where x.Category == category
                   select new HelpClassFindClientsByCategory { Name = x.FullName, Category = x.Category};
        } 

        public IEnumerable<Book> GetConcatBook()
        {
            return (from b in Data.Books
                    from s in Data.Subscriptions
                    where b.Id == s.BookId && s.DateOfIssue >= DateTime.Now.AddMonths(-1)
                    select b).Concat(from b in Data.Books
                                     where b.CollateralValue >=23M
                                     select b).Distinct().ToList();

                }
        public Dictionary<string, List<Book>> GetAllBooksByClient()
        {

            return Data.Clients
                             .GroupJoin(Data.Books
                             .Join(Data.Subscriptions,
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
            return Data.Books.Aggregate(0, (sum, a) => sum + a.Amount);
        }

        public IEnumerable<HelpClassGroupJoinBookGenre> GetBooksByGenres()
        {
           
            return Data.Genres.GroupJoin(Data.Books,  g => g.Id, b => b.GenreId,(b, g) =>
               new HelpClassGroupJoinBookGenre
               {
                   Genre = b.pGenre,
                   Books = g
               }
            );
        }
     
       public bool GetBoolAllBooksWithSpecificAmount(int amount = 5)
        {
            
            return Data.Books.All(b => b.Amount>=amount);
        }
       public IEnumerable<Client> GetClientsWithSkipedIndex(int index = 4)
        {
            return Data.Clients.Skip(index);  
        }
        public IEnumerable<HelpClassSortedBooks> GetSortedOldestTakenBooks()
        {
            var res = from x in Data.Books
                      join y in Data.Subscriptions on x.Id equals y.BookId
                      orderby y.DateOfIssue.Year
                      select new HelpClassSortedBooks { Name = x.Name, DateOfIssue = y.DateOfIssue };
            return res;
                      
        }
        
        
        public decimal GetAvgRentProfit()
        {
            var res = from x in Data.Books
                      join y in Data.Subscriptions on x.Id equals y.BookId
                      select y.RentalPrice;

            return res.Average();
        }

        
        public IEnumerable<Book> GetRentedBooksInRange(int begin = -3, int end = 3)
        {
            var res = from x in Data.Books
                      join y in Data.Subscriptions on x.Id equals y.BookId
                      where y.DateOfIssue >= DateTime.Now.AddMonths(begin) && y.DateOfIssue <= DateTime.Now.AddMonths(end) 
                      select x;
            return res;
        }
        public decimal GetPercentOfCategoryClients(Categories category = Categories.Student)
        {
            var res = from c in Data.Clients
                      where c.Category == category
                      select c;
           if (res is null) return 0;
            return (decimal)res.Count() / Data.Clients.Count() * 100M;
        }
       
        public IEnumerable<string> GetAllBooksStartedWithChar(char a = 'Е')
        {
            return from b in Data.Books
                   where b.Name[0] == a
                   select b.Name;
        }
   
        public IEnumerable<HelpClassJoinBookAuthors> GetJoinBooksAuthors()
        {
            return Data.Co_Authors.Join(Data.Books,
                empLv1 => empLv1.BookId,
                addLv1 => addLv1.Id,
                (empLv1, addLv1) => new { empLv1, addLv1 }
                ).Join(
                Data.Authors,
                empLv2 => empLv2.empLv1.AuthorId,
                deptLv2 => deptLv2.Id,
                (empLv2, deptLv2) => new { empLv2, deptLv2 }
                ).Select(c => new HelpClassJoinBookAuthors
                {
                    BookName = c.empLv2.addLv1.Name,
                    Author = c.deptLv2.Name
                }).ToList();
        }
      
       public IEnumerable<HelpClassDecart> GetDecartMultiply()
        {
            return from b in Data.Books
                   from c in Data.Subscriptions
                   select new HelpClassDecart { SubscriptionId = c.Id, Name = b.Name, DateOfIssue = c.DateOfIssue, ExpectedReturnDate = c.ExpectedReturnDate, RentalPrice = c.RentalPrice };
        }

        public IEnumerable<Client> GetClientsWithOutRent()
        {
            return from c in Data.Clients
                   where !(from s in Data.Subscriptions select s.ClientId).Contains(c.Id)
                   select c;
        }
        public IEnumerable<HelpClassBooksWithHigher> GetBooksWithHihgerRentPrice(decimal limit = 47.55M)
        {
            return from b in Data.Books
                   from s in Data.Subscriptions
                   where s.RentalPrice >= limit
                   select new HelpClassBooksWithHigher { Name = b.Name, RentPrice = s.RentalPrice};

        }

        public decimal GetMaxCollateralValue()
        {
            return Data.Books.Max(b => b.CollateralValue);
        }

        
        public Client GetClientFirstHaveLuckyNumber(string number = "666")
        {
            return Data.Clients.FirstOrDefault(c => c.Phone.Contains(number));
            
        }
    }
}
