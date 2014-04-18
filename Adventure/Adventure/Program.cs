using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            do
            {
                if (input.ToLower().Trim() == "dance")
                    Console.WriteLine("You dance around like a fool");
                
                if (input.ToLower().Trim() == "pass")
                    Console.WriteLine("Good Pass!");
               
                if (input.ToLower().Trim() == "shoot")
                    Console.WriteLine("Off the mark. Try again? Choose yes or no");
                Console.Write("> ");
                input = Console.ReadLine();
            }
            while (input.ToLower().Trim() != "exit");
        }
    }
}
