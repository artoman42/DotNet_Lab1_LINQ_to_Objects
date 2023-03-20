using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL
{
    public class Menu
    {
        public static string GetMenu()
        {
            string res = "Enter the number :\n";
            int i = 0;
            foreach(var d in Enum.GetValues(typeof(DictionaryCommandsEnum)))
            {
                res += $"{i}. {d} \n";
                i++;
            }
            return res;
        }
    }
}
