using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Library.enums;
using LibraryDAL.QeuryHelperClasses;
namespace LibraryDAL
{
    public interface ILibraryService
    {
        public IEnumerable<Book> SelectAllBooks();
        public IEnumerable<HelpClassInnerJoinClientSubscription> GetInnerJoin();
        public IEnumerable<HelpClassFindClientsByCategory> SelectClientsByCategory(Categories category = Categories.Student);
        public IEnumerable<Book> GetConcatBook();
        public Dictionary<string, List<Book>> GetAllBooksByClient();
        public int GetFullAmountOfBook();
        public IEnumerable<HelpClassGroupJoinBookGenre> GetBooksByGenres();
        public bool GetBoolAllBooksWithSpecificAmount(int amount = 5);
        public IEnumerable<Client> GetClientsWithSkipedIndex(int index = 4);
        public IEnumerable<HelpClassSortedBooks> GetSortedOldestTakenBooks();
        public decimal GetAvgRentProfit();
        public IEnumerable<Book> GetRentedBooksInRange(int begin = -3, int end = 3);
        public decimal GetPercentOfCategoryClients(Categories category = Categories.Student);
        public IEnumerable<string> GetAllBooksStartedWithChar(char a = 'Е');
        public IEnumerable<HelpClassJoinBookGenres> GetJoinBooksGenres();
        public IEnumerable<HelpClassDecart> GetDecartMultiply();
        public IEnumerable<Client> GetClientsWithOutRent();
        public IEnumerable<HelpClassBooksWithHigher> GetBooksWithHihgerRentPrice(decimal limit = 47.55M);
        public decimal GetMaxCollateralValue();
        public Client GetClientFirstHaveLuckyNumber(string number = "666");


    }
}
