using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDAL;
using Library.enums;
namespace LibraryDAL
{
    public class DictionaryCommands : IDictionaryCommands
    {
        private readonly ILibraryService _libraryService;
        public DictionaryCommands(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }
        public void Exit()
        {
            Environment.Exit(0);
        }
        public void ShowAllBooks()
        {
            var books = _libraryService.SelectAllBooks();
            Console.WriteLine("1. All Books :");
            foreach (var b in books)
            {
                Console.WriteLine($"\t{b.ToString()}");
            }
            Console.WriteLine();
        }
        public void ShowInnerJoin()
        {
            var InnerJoin = _libraryService.GetInnerJoin();
            Console.WriteLine("2. Inner join Clients with Subscriptions");
            foreach (var res in InnerJoin)
            {
                Console.WriteLine($"\t{res.Name} {res.DateOfIssue} {res.ExpectedReturnDate} {res.RentalPrice}");
            }
            Console.WriteLine();
        }
        public void ShowClientsByCategory()
        {
            const Categories CATEGORY = Categories.Student;
            var clients = _libraryService.SelectClientsByCategory(CATEGORY);
            Console.WriteLine("3. Select clients by Category");
            foreach (var c in clients)
            {
                Console.WriteLine($"\t{c.Name} {c.Category}");
            }
        }
        public void ShowConcatBook()
        {
            var books = _libraryService.GetConcatBook();
            Console.WriteLine("4. Show distinct concat Books(IssuDate Month ago or earlier or Collateral value bigger than 23) :");
            foreach (var b in books)
            {
                Console.WriteLine($"\t{b.ToString()}");
            }
            Console.WriteLine();
        }

        public void ShowAllBooksByClients()
        {
            var books = _libraryService.GetAllBooksByClient();
            Console.WriteLine("5.All Books By Clients:");
            foreach (var b in books)
            {
                Console.WriteLine($"Client : {b.Key.ToString()}");
                foreach (var c in b.Value)
                {
                    Console.WriteLine($"\tBook : {c.ToString()}");
                }
                Console.WriteLine();
            }
        }
        public void ShowFullAmountOfBook()
        {
            var amount = _libraryService.GetFullAmountOfBook();
            Console.WriteLine("6. Full Amount of Books");
            Console.WriteLine($"{amount}");
            Console.WriteLine();
        }
        public void ShowBooksByGenres()
        {
            var res = _libraryService.GetBooksByGenres();
            Console.WriteLine("7. Books by genres");
            foreach (var g in res)
            {
                Console.WriteLine($"{g.Genre.ToString()}:");
                foreach (var book in g.Books)
                {
                    Console.WriteLine($"\t{book.ToString()}");
                }
            }
            Console.WriteLine();
        }
        public void ShowBoolAllBooksWithSpecificAmount()
        {
            const int AMOUNT = 5;
            var res = _libraryService.GetBoolAllBooksWithSpecificAmount(AMOUNT);
            Console.WriteLine($"8. Bool of all books are more than{AMOUNT}");
            Console.WriteLine($"{res}");
            Console.WriteLine();
        }
        public void ShowClientWithSkipedIndex()
        {
            const int INDEX = 4;
            var clients = _libraryService.GetClientsWithSkipedIndex(INDEX);
            Console.WriteLine($"9. All Clients, but client with index: {INDEX} is skiped");
            foreach (var c in clients)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine();
        }
        public void ShowSortedOldestTakenBooks()
        {
            var books = _libraryService.GetSortedOldestTakenBooks();
            Console.WriteLine("10. All books sorted by oldest taken");
            foreach (var b in books)
            {
                Console.WriteLine($"{b.Name} {b.DateOfIssue}");
            }
            Console.WriteLine();
        }

        public void ShowAvgRentProfit()
        {
            var res = _libraryService.GetAvgRentProfit();
            Console.WriteLine("11. Show Average rent profit");
            Console.WriteLine($"{res}");
            Console.WriteLine();
        }

        public void ShowRentedBooksInRange()
        {
            const int BEGIN = -3;
            const int END = 3;
            var books = _libraryService.GetRentedBooksInRange(BEGIN, END);
            Console.WriteLine($"12. Show books Rented in  range {DateTime.Now.AddMonths(BEGIN)} {DateTime.Now.AddMonths(END)}");
            foreach (var b in books)
            {
                Console.WriteLine($"{b.ToString()}");
            }
            Console.WriteLine();
        }
        public void ShowPercentOfCategoryClients()
        {
            const Categories CATEGORY = Categories.Student;
            var res = _libraryService.GetPercentOfCategoryClients(CATEGORY);
            Console.WriteLine($"13. Show percent of clients of {CATEGORY} ");
            Console.WriteLine(res);
            Console.WriteLine();
        }
        public void ShowAllBooksStartedWithChar()
        {
            const char CHAR = 'Е';
            var books = _libraryService.GetAllBooksStartedWithChar(CHAR);
            Console.WriteLine($"14. Show All books started with Char {CHAR}");
            foreach (var b in books)
            {
                Console.WriteLine(b.ToString());
            }
            Console.WriteLine();
        }
        public void ShowJoinBooksAuthors()
        {
            var res = _libraryService.GetJoinBooksAuthors();
            Console.WriteLine("15. Show Join books with authors");
            foreach (var r in res)
            {
                Console.WriteLine($"{r.BookName} {r.Author}");
            }
            Console.WriteLine();
        }

        public void ShowDecartMultiply()
        {
            var res = _libraryService.GetDecartMultiply();
            Console.WriteLine("16.Show Decart Multiply of books and subscriptions");
            foreach (var r in res)
            {
                Console.WriteLine($"{r.Name} {r.SubscriptionId} {r.DateOfIssue} {r.ExpectedReturnDate} {r.RentalPrice}");
            }
            Console.WriteLine();
        }
        public void ShowClientsWithOutRent()
        {
            var clients = _libraryService.GetClientsWithOutRent();
            Console.WriteLine("17. Show Clients with out rent");
            foreach (var c in clients)
            {
                Console.WriteLine($"{c.ToString()}");
            }
            Console.WriteLine();
        }
        public void ShowBooksWithHigherPrice()
        {
            const decimal LIMIT = 47.55M;
            var books = _libraryService.GetBooksWithHihgerRentPrice(LIMIT);
            Console.WriteLine($"18. Show books with rent price more than {LIMIT}");
            foreach (var b in books)
            {
                Console.WriteLine(b.ToString());
            }
            Console.WriteLine();
        }

        public void ShowMaxCollateralValue()
        {
            var res = _libraryService.GetMaxCollateralValue();
            Console.WriteLine("19. Show Max Collateral value :");
            Console.WriteLine(res);
        }
        public void ShowClientFirstHaveLuckyNumber()
        {
            const string NUMBER = "666";
            var res = _libraryService.GetClientFirstHaveLuckyNumber(NUMBER);
            Console.WriteLine($"20. Show First client who has Lucky number, which contain{NUMBER}");
            Console.WriteLine();
        }
    }
}
