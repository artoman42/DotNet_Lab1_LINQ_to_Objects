using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL
{
    public interface IDictionaryCommands
    {
        public void Exit();
        public void ShowAllBooks();
        public void ShowInnerJoin();
        public void ShowClientsByCategory();
        public void ShowConcatBook();
        public void ShowAllBooksByClients();
        public void ShowFullAmountOfBook();
        public void ShowBooksByGenres();
        public void ShowBoolAllBooksWithSpecificAmount();
        public void ShowClientWithSkipedIndex();
        public void ShowSortedOldestTakenBooks();
        public void ShowAvgRentProfit();
        public void ShowRentedBooksInRange();
        public void ShowPercentOfCategoryClients();
        public void ShowAllBooksStartedWithChar();
        public void ShowJoinBooksAuthors();
        public void ShowDecartMultiply();
        public void ShowClientsWithOutRent();
        public void ShowBooksWithHigherPrice();
        public void ShowMaxCollateralValue();
        public void ShowClientFirstHaveLuckyNumber();

    }
}
