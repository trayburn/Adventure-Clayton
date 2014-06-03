using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class ShootCommand : BaseCommand, ICommand
    {
        public bool IsValid(string input)
        {
            return IsFirstWord("shoot", input);
        }

        public void Execute(string input)
        {
            Console.WriteLine("Off the mark. Try again? Choose yes or no");
        }
    }
}
