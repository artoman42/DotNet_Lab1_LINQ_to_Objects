using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL
{
    public class Runner : IRunner
    {
        private readonly IDictionaryCommands _dictionaryCommands;
        public Runner(IDictionaryCommands dictionaryCommands)
        {
            _dictionaryCommands = dictionaryCommands;
        }

        public void Run()
        {
            var DictionaryCommands = new Dictionary<DictionaryCommandsEnum, Action>()
            {
                { DictionaryCommandsEnum.Exit, () => _dictionaryCommands.Exit() },
                { DictionaryCommandsEnum.ShowAllBooks, () => _dictionaryCommands.ShowAllBooks() },
                { DictionaryCommandsEnum.ShowInnerJoin, () => _dictionaryCommands.ShowInnerJoin() },
                { DictionaryCommandsEnum.ShowClientsByCategory, () => _dictionaryCommands.ShowClientsByCategory() },
                { DictionaryCommandsEnum.ShowConcatBook, () => _dictionaryCommands.ShowConcatBook() },
                { DictionaryCommandsEnum.ShowAllBooksByClients, () => _dictionaryCommands.ShowAllBooksByClients() },
                { DictionaryCommandsEnum.ShowFullAmountOfBook, () => _dictionaryCommands.ShowFullAmountOfBook() },
                { DictionaryCommandsEnum.ShowBooksByGenres, () => _dictionaryCommands.ShowBooksByGenres() },
                { DictionaryCommandsEnum.ShowBoolAllBooksWithSpecificAmount, () => _dictionaryCommands.ShowBoolAllBooksWithSpecificAmount() },
                { DictionaryCommandsEnum.ShowClientWithSkipedIndex, () => _dictionaryCommands.ShowClientWithSkipedIndex() },
                { DictionaryCommandsEnum.ShowSortedOldestTakenBooks, () => _dictionaryCommands.ShowSortedOldestTakenBooks() },
                { DictionaryCommandsEnum.ShowAvgRentProfit, () => _dictionaryCommands.ShowAvgRentProfit() },
                { DictionaryCommandsEnum.ShowRentedBooksInRange, () => _dictionaryCommands.ShowRentedBooksInRange() },
                { DictionaryCommandsEnum.ShowPercentOfCategoryClients, () => _dictionaryCommands.ShowPercentOfCategoryClients() },
                { DictionaryCommandsEnum.ShowAllBooksStartedWithChar, () => _dictionaryCommands.ShowAllBooksStartedWithChar() },
                { DictionaryCommandsEnum.ShowJoinBooksGenres, () => _dictionaryCommands.ShowJoinBooksGenres() },
                { DictionaryCommandsEnum.ShowDecartMultiply, () => _dictionaryCommands.ShowDecartMultiply() },
                { DictionaryCommandsEnum.ShowClientsWithOutRent, () => _dictionaryCommands.ShowClientsWithOutRent() },
                { DictionaryCommandsEnum.ShowBooksWithHigherPrice, () => _dictionaryCommands.ShowBooksWithHigherPrice() },
                { DictionaryCommandsEnum.ShowMaxCollateralValue, () => _dictionaryCommands.ShowMaxCollateralValue() },
                { DictionaryCommandsEnum.ShowClientFirstHaveLuckyNumber, () => _dictionaryCommands.ShowClientFirstHaveLuckyNumber() },
                
            };
            while (true)
            {
                Console.WriteLine(Menu.GetMenu());
                string input = Console.ReadLine();
                if(string.Compare(input,"Exit") == 0)
                {
                    DictionaryCommands[0].Invoke();
                }
                if(Enum.TryParse(input,out DictionaryCommandsEnum dictionaryCommand) && DictionaryCommands.ContainsKey(dictionaryCommand))
                {
                    DictionaryCommands[dictionaryCommand].Invoke();
                }
                else
                {
                    Console.WriteLine("Incorect Enter!");
                }
            }
        }
    }
}