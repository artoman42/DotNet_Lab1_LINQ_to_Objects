using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using LibraryDAL;
using Library.enums;
namespace Lab1
{
    public class ConsoleShow
    {
        public static void ShowAllBooks(IEnumerable<Book> books)
        {
            if ( books != null && books.Any())
            {
                Console.WriteLine("All Books :");
                foreach (var b in books)
                {
                    Console.WriteLine($"\t{b}");
                }
            }
            else
            {
                Console.WriteLine("No Books are available!");
            }
        }
        public static void ShowAllBooksNames(IEnumerable<String> books)
        {
            if (books != null && books.Any())
            {
                Console.WriteLine("All Books Names:");
                foreach (var b in books)
                {
                    Console.WriteLine($"\t{b}");
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowAllStudentClients(IEnumerable<dynamic> books) { 
            if (books != null && books.Any())
            {
                Console.WriteLine("All Student Clients Names:");
                foreach (var b in books)
                {
                    Console.WriteLine($"\t{b}");
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowAllClientsByBook(Dictionary<string, List<Client>> clients)
        {
            if (clients != null && clients.Any())
            {
                Console.WriteLine("All Clients By Book:");
                foreach (var b in clients)
                {
                    Console.WriteLine($"Book : {b.Key}");
                    foreach(var c in b.Value)
                    {
                        Console.WriteLine($"\tClient : {c}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowAllBooksByClient(Dictionary<string, List<Book>> books)
        {
            if (books != null && books.Any())
            {
                Console.WriteLine("All Books By Clients:");
                foreach (var b in books)
                {
                    Console.WriteLine($"Client : {b.Key}");
                    foreach (var c in b.Value)
                    {
                        Console.WriteLine($"\tBook : {c}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowFullAmountOfBook(int Amount)
        {
            if (Amount != null )
            {
                Console.WriteLine($"All of Amount of books: {Amount}");
               
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowBooksByGenres(Dictionary<Genres,IEnumerable<Book>> books)
        {
            if (books != null && books.Any())
            {
                Console.WriteLine("All Books By Genres:");
                foreach (var b in books)
                {
                    Console.WriteLine($"Genre : {b.Key}");
                    foreach (var c in b.Value)
                    {
                        Console.WriteLine($"\tBook : {c}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowBooksWithSpecificAmount(IEnumerable<dynamic> books)
        {
            if (books != null && books.Any())
            {
                Console.WriteLine("Books, which amount is more or equal than 3");
                foreach (var b in books)
                {
                    Console.WriteLine($"\t{b}");
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowBooksOnHand(Dictionary<string, int> books)
        {
            if (books != null && books.Any())
            {
                Console.WriteLine("Книжки виданi та їх кiлькiсть:");
                foreach (var b in books)
                {
                    Console.WriteLine($"\t{b.Key} {b.Value}");
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }

        public static void ShowSortedOldestTakenBooks(IEnumerable<dynamic> books)
        {
            if (books != null && books.Any())
            {
                Console.WriteLine("Топ книжок за давнiстю їх видачi :");
                foreach (var b in books)
                {
                    Console.WriteLine($"\t{b} ");
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowFullRentProfit(double profit)
        {
            if (profit != null)
            {
                Console.WriteLine("Очiкуваний прибуток вiд всiх орендованих книжок :");

                Console.WriteLine($"\t{profit} ");


            }
            else Console.WriteLine("No result!");
        }
        public static void ShowOverdueBooks(IEnumerable<dynamic> books)
        {
            
            if (books != null && books.Any())
            {
                Console.WriteLine("Просроченi книжки та час просрочки :");
                foreach (var b in books)
                {
                    Console.WriteLine($"\t{b} ");
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowPercentOfStudentClients(double percent)
        {
            if (percent != null)
            {
                Console.WriteLine("Відсоток студентів серед клієнтів :");

                Console.WriteLine($"\t{percent} ");


            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowAllBooksStartedWithE(IEnumerable<string> books)
        {
            if(books != null && books.Any())
            {
                Console.WriteLine("Усi книжки назва яких починається на \"Е\"");
                foreach(var b in books)
                {
                    Console.WriteLine($"\t {b}");
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowBooksByAuthors(Dictionary<string, IEnumerable<Book>> AuthBooks)
        {
            if (AuthBooks != null && AuthBooks.Any())
            {
                Console.WriteLine("Книжки по авторам : ");
                foreach(var a in AuthBooks)
                {
                    Console.WriteLine($"{a.Key}");
                    foreach(var b in a.Value)
                    {
                        Console.WriteLine($"\t{b}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }

    
        public static void ShowActiveSubscriptions(IEnumerable<Subscription> subscriptions)
        {
            if (subscriptions != null && subscriptions.Any())
            {
                Console.WriteLine("Активнi абонементи : ");
                foreach (var a in subscriptions)
                {
                    Console.WriteLine($"\t{a}");
                    
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowClientsWithOutRent(IEnumerable<Client> clients)
        {
            if (clients != null && clients.Any())
            {
                Console.WriteLine("All Clients with out rent:");
                foreach (var b in clients)
                {
                    Console.WriteLine($"\tClient : {b}");
                   
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowBooksWithHihgerRentPrice(IEnumerable<Book> books)
        {
            if (books != null && books.Any())
            {
                Console.WriteLine("Усi книжки, цiна яких бiльше 47.55");
                foreach (var b in books)
                {
                    Console.WriteLine($"\t {b}");
                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowAverageCollateralValue(double avg)
        {
            if (avg != null)
            {
                Console.WriteLine("Середня цiна застави за книжку :");

                Console.WriteLine($"\t{avg} ");


            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
        public static void ShowClientsWithLuckyNumber(IEnumerable<Client> clients)
        {
            if (clients != null && clients.Any())
            {
                Console.WriteLine("Усi клiєнти з удачливим номером телефону:");
                foreach (var b in clients)
                {
                    Console.WriteLine($"\tClient : {b}");

                }
            }
            else
            {
                Console.WriteLine("No result!");
            }
        }
    }
}
