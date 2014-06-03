using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class HideCommand : BaseCommand, ICommand
    {
        public bool IsValid(string input)
        {
            return IsFirstWord("hide", input);
        }

        public void Execute(string input)
        {
            Console.WriteLine("You hide in the shadows...");
        }
    }
}
