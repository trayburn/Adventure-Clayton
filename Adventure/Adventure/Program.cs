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
                Console.Write("> ");
                input = Console.ReadLine();
            }
            while (input.ToLower().Trim() != "exit");
        }
    }
}
