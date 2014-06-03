using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class BaseCommand
    {
        public bool IsFirstWord(string word, string input)
        {
            var firstWord = input.ToLower().Trim().Split(' ')[0];
            return firstWord == word.ToLower().Trim();
        }
    }
}
