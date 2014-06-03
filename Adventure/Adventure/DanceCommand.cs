using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class DanceCommand : BaseCommand, ICommand
    {
        public bool IsValid(string input)
        {
            return IsFirstWord("dance", input);
        }

        public void Execute(string input)
        {
            Console.WriteLine("You dance around like a fool");
        }
    }
}
