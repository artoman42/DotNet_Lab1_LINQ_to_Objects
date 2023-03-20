using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDAL;
namespace Lab1
{
    public class ConsoleMenu
    {
        public static void TextMenu()
        {
            string s = "0 - exit \n" +
                "1- Select All books\n" +
                "2- Select All books names\n" +
                "3- Get all clients, who are students\n" +
                "4- Get All clients by books\n" +
                "5- Get all books by clients\n" +
                "6- Get full amount of books\n" +
                "7- Get books by genre\n" +
                "8- Get books, which amount is more or equal than 3\n" +
                "9- Get all books, which are on hands\n" +
                "10 - Get sorted by the oldest books, which are taken\n" +
                "11 - Get full rent profit\n" +
                "12 - Get overdued books and time of overdue\n" +
                "13 - Get percent of student clients\n" +
                "14 - Get all books, which name is started with \"E\"\n" +
                "15 - Get Books by Authors\n" +
                "16 - Get active subscriptions\n" +
                "17- Get all clients, who has no books in rent\n" +
                "18- Get all books, which price is higher than 47.55\n" +
                "19- Get average collateral values\n" +
                "20- Get clients, who lucky phone number(contains 666)\n" +
                "21 - RUN ALL\n\n\n\n";
            Console.WriteLine(s);
        }
        public static void MenuRunAll()
        {
            LibraryService LibraryDAL = new LibraryService();
            ConsoleShow.ShowAllBooks(LibraryDAL.SelectAllBooks());
            Console.WriteLine();
            ConsoleShow.ShowAllBooksNames(LibraryDAL.SelectAllBookNames());
            Console.WriteLine();
            ConsoleShow.ShowAllStudentClients(LibraryDAL.SelectAllStudentClients());
            Console.WriteLine();
            ConsoleShow.ShowAllClientsByBook(LibraryDAL.GetAllClientsByBook());
            Console.WriteLine();
            ConsoleShow.ShowAllBooksByClient(LibraryDAL.GetAllBooksByClient());
            Console.WriteLine();
            ConsoleShow.ShowFullAmountOfBook(LibraryDAL.GetFullAmountOfBook());
            Console.WriteLine();
            ConsoleShow.ShowBooksByGenres(LibraryDAL.GetBooksByGenres());
            Console.WriteLine();
            ConsoleShow.ShowBooksWithSpecificAmount(LibraryDAL.GetBooksWithSpecificAmount(3));
            Console.WriteLine();
            ConsoleShow.ShowBooksOnHand(LibraryDAL.GetBooksOnHand());
            Console.WriteLine();
            ConsoleShow.ShowSortedOldestTakenBooks(LibraryDAL.GetSortedOldestTakenBooks());
            Console.WriteLine();
            ConsoleShow.ShowFullRentProfit(LibraryDAL.GetFullRentProfit());
            Console.WriteLine();
            ConsoleShow.ShowOverdueBooks(LibraryDAL.GetOverdueBooks());
            Console.WriteLine();
            ConsoleShow.ShowPercentOfStudentClients(LibraryDAL.GetPercentOfStudentClients());
            Console.WriteLine();
            ConsoleShow.ShowAllBooksStartedWithE(LibraryDAL.GetAllBooksStartedWithE());
            Console.WriteLine();
            ConsoleShow.ShowBooksByAuthors(LibraryDAL.GetBooksByAuthors());
            Console.WriteLine();

            ConsoleShow.ShowActiveSubscriptions(LibraryDAL.GetActiveSubscriptions());
            Console.WriteLine();
            ConsoleShow.ShowClientsWithOutRent(LibraryDAL.GetClientsWithOutRent());
            Console.WriteLine();
            ConsoleShow.ShowBooksWithHihgerRentPrice(LibraryDAL.GetBooksWithHihgerRentPrice());
            Console.WriteLine();
            ConsoleShow.ShowAverageCollateralValue(LibraryDAL.GetAverageCollateralValue());
            Console.WriteLine();
            ConsoleShow.ShowClientsWithLuckyNumber(LibraryDAL.GetClientsWithLuckyNumber());
        }
    }
}
