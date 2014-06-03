using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class PassCommand : BaseCommand, ICommand
    {

        public bool IsValid(string input)
        {
            return IsFirstWord("pass", input);
        }

        public void Execute(string input)
        {
            string passError = "Error : To who? Use 'pass to <player>'";
            var words = input.Trim().Split(' ');

            if (words.Length < 3 || words.Length > 3)
                Console.WriteLine(passError);
            else
            {
                if (words[1].ToLower() != "to")
                    Console.WriteLine(passError);
                else
                    Console.WriteLine("Good Pass to " + words[2] + "!");
            }
        }
    }
}
