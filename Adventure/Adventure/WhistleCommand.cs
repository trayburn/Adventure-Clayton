using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class WhistleCommand : BaseCommand, ICommand
    {
        public bool IsValid(string input)
        {
            return IsFirstWord("whistle", input);
        }

        public void Execute(string input)
        {
            Console.WriteLine("You whistle while you work.");
        }
    }

}
