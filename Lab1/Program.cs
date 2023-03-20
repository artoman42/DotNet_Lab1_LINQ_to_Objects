using System;
using LibraryDAL;
namespace Lab1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            LibraryService LibraryDAL = new LibraryService();

            while (true)
            {
                try
                {
                    ConsoleMenu.TextMenu();
                    int menuItem = Int32.Parse(Console.ReadLine());
                    switch (menuItem)
                    { 
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            ConsoleShow.ShowAllBooks(LibraryDAL.SelectAllBooks());
                            break;
                        case 2:
                            ConsoleShow.ShowAllBooksNames(LibraryDAL.SelectAllBookNames());
                            break;
                        case 3:
                            ConsoleShow.ShowAllStudentClients(LibraryDAL.SelectAllStudentClients());
                            break;
                        case 4:
                            ConsoleShow.ShowAllClientsByBook(LibraryDAL.GetAllClientsByBook());
                            break;
                        case 5:
                            ConsoleShow.ShowAllBooksByClient(LibraryDAL.GetAllBooksByClient());
                            break;
                        case 6:
                            ConsoleShow.ShowFullAmountOfBook(LibraryDAL.GetFullAmountOfBook());
                            break;
                        case 7:
                            ConsoleShow.ShowBooksByGenres(LibraryDAL.GetBooksByGenres());
                            break;
                        case 8:
                            ConsoleShow.ShowBooksWithSpecificAmount(LibraryDAL.GetBooksWithSpecificAmount(3));
                            break;
                        case 9:
                            ConsoleShow.ShowBooksOnHand(LibraryDAL.GetBooksOnHand());
                            break;
                        case 10:
                            ConsoleShow.ShowSortedOldestTakenBooks(LibraryDAL.GetSortedOldestTakenBooks());
                            break;
                        case 11:
                            ConsoleShow.ShowFullRentProfit(LibraryDAL.GetFullRentProfit());
                            break;
                        case 12:
                            ConsoleShow.ShowOverdueBooks(LibraryDAL.GetOverdueBooks());
                            break;
                        case 13:
                            ConsoleShow.ShowPercentOfStudentClients(LibraryDAL.GetPercentOfStudentClients());
                            break;
                        case 14:
                            ConsoleShow.ShowAllBooksStartedWithE(LibraryDAL.GetAllBooksStartedWithE());
                            break;
                        case 15:
                            ConsoleShow.ShowBooksByAuthors(LibraryDAL.GetBooksByAuthors());
                            break;
                        case 16:
                            ConsoleShow.ShowActiveSubscriptions(LibraryDAL.GetActiveSubscriptions());
                            break;
                        case 17:
                            ConsoleShow.ShowClientsWithOutRent(LibraryDAL.GetClientsWithOutRent());
                            break;
                        case 18:
                            ConsoleShow.ShowBooksWithHihgerRentPrice(LibraryDAL.GetBooksWithHihgerRentPrice());
                            break;
                        case 19:
                            ConsoleShow.ShowAverageCollateralValue(LibraryDAL.GetAverageCollateralValue());
                            break;
                        case 20:
                            ConsoleShow.ShowClientsWithLuckyNumber(LibraryDAL.GetClientsWithLuckyNumber());
                            break;
                        case 21:
                            ConsoleMenu.MenuRunAll();
                            break;

                    }

                }
                catch
                {
                    Console.WriteLine("Wrong MenuItem");
                }
                
            }

            
           
            
        }
    }
}
