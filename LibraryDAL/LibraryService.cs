using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Library.enums;
namespace LibraryDAL
{
    public class LibraryService
    {
        public IEnumerable<Book> SelectAllBooks()
        {
            return from x in Data.Books
                   select x;
        }
        public IEnumerable<Book> SelectAllBookNames()
        {
            return from x in Data.Books
                   select x;
        }
        public IEnumerable<dynamic> SelectAllStudentClients()
        {
            return from x in Data.Clients
                   where x.Category == Library.enums.Categories.Student
                   select new { Name = x.FullName, Category = x.Category};
        } 

        public Dictionary<string, List<Client>> GetAllClientsByBook()
        {

            return Data.Books
                             .GroupJoin(Data.Clients
                             .Join(Data.Subscriptions,
                                    c => c.Id,
                                    cb => cb.ClientId,
                                    (c, cb) => new
                                    {
                                        BookId = cb.BookId,
                                        ClientItem = c
                                    }),
                                b => b.Id,
                                bc => bc.BookId,
                                (b, books) => new
                                {
                                    BookName = b.Name,
                                    books = books.Select(c => c.ClientItem).ToList()
                                }).Where(c=>c.books.Count()!=0).ToDictionary(b => b.BookName, c => c.books);
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

        public Dictionary<Genres, IEnumerable<Book>> GetBooksByGenres()
        {
            var q = from b in Data.Books
                    group b by b.Genre;
            return q.ToDictionary(k => k.Key, v => v.Select(h => h));
        }
     
       public IEnumerable<dynamic> GetBooksWithSpecificAmount(int amount)
        {
            var q  = from x in Data.Books
                     where x.Amount >= amount
                     select new { Name = x.Name, Amount = x.Amount};
            return q;
        }
       public Dictionary<string, int> GetBooksOnHand()
        {
            return Data.Books
                             .GroupJoin(Data.Clients
                             .Join(Data.Subscriptions,
                                    c => c.Id,
                                    cb => cb.ClientId,
                                    (c, cb) => new
                                    {
                                        BookId = cb.BookId,
                                        ClientItem = c
                                    }),
                                b => b.Id,
                                bc => bc.BookId,
                                (b, books) => new
                                {
                                    BookName = b.Name,
                                    books = books.Select(c => c.ClientItem).ToList()
                                }).Where(x=>x.books.Count >0).ToDictionary(x => x.BookName, y => y.books.Count);
        }
        public IEnumerable<dynamic> GetSortedOldestTakenBooks()
        {
            var res = from x in Data.Books
                      join y in Data.Subscriptions on x.Id equals y.BookId
                      orderby y.RentPeriod.DateOfIssue.Year
                      select new { Name = x.Name, DateOfIssue = y.RentPeriod.DateOfIssue };
            return res;
                      
        }
        public IEnumerable<dynamic> GetFullInfo()
        {
            var bookIdAndClients = from b in Data.Books
                                  join s in Data.Subscriptions
                                            on b.Id equals s.BookId
                                  group b by s.ClientId into models
                                  select new {ClientId = models.Key, Books = models };
            return bookIdAndClients;
        }
        
        public double GetFullRentProfit()
        {
            var res = from x in Data.Books
                      join y in Data.Subscriptions on x.Id equals y.BookId
                      select x.RentCost.RentalPrice;

            return res.Sum();
        }

        //TODO base method that get data in range 
        public IEnumerable<dynamic> GetOverdueBooks()
        {
            var res = from x in Data.Books
                      join y in Data.Subscriptions on x.Id equals y.BookId
                      where y.RentPeriod.ExpectedReturnDate < DateTime.Now
                      select new { Name = x.Name, OverdueTime = DateTime.Now - y.RentPeriod.ExpectedReturnDate };
            return res;
        }
        public double GetPercentOfStudentClients()
        {
            var res = from c in Data.Clients
                      where c.Category == 0
                      select c;
           if (res is null) return 0;
            return (double)res.Count() / Data.Clients.Count() * 100;
        }
        //GetAllBooksStartedWithStartChar(char a) 
        public IEnumerable<string> GetAllBooksStartedWithE()
        {
            return from b in Data.Books
                   where b.Name[0] == 'Е'
                   select b.Name;
        }
   
        public Dictionary<string, IEnumerable<Book>> GetBooksByAuthors()
        {
            var q = from b in Data.Books
                    group b by b.Author;
            return q.ToDictionary(k => k.Key, v => v.Select(h => h));
        }
      
       public IEnumerable<Subscription> GetActiveSubscriptions()
        {
            return from s in Data.Subscriptions
                   where s.IsActive == true
                   select s;
        }

        public IEnumerable<Client> GetClientsWithOutRent()
        {
            return from c in Data.Clients
                   where !(from s in Data.Subscriptions select s.ClientId).Contains(c.Id)
                   select c;
        }
        public IEnumerable<Book> GetBooksWithHihgerRentPrice()
        {
            return from b in Data.Books
                   where b.RentCost.RentalPrice >= 47.55
                   select b;

        }

        public double GetAverageCollateralValue()
        {
            return Data.Books.Average(b => b.RentCost.CollateralValue);
        }

        public string GetCityName(string input)
        {
            string[] words = input.Split(' ');
            int index = Array.IndexOf(words, "місто");
            if (index >= 0 && index < words.Length - 1)
            {
                return words[index + 1];
            }
            else
            {
                return null;
            }
        }
        public IEnumerable<Client> GetClientsWithLuckyNumber()
        {
            return from c in Data.Clients
                   where c.Phone.Contains("666")
                   select c;
        }
    }
}
