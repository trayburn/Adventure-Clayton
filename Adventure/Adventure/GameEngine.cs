using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;

namespace Adventure
{
    public class GameEngine : IGameEngine
    {
        private ICommand[] allCommands;

        public GameEngine(ICommand[] allCommands)
        {
            this.allCommands = allCommands;
        }

        public void Start()
        {
            string input = "";
            do
            {
                foreach (ICommand cmd in allCommands)
                {
                    if (cmd.IsValid(input))
                    {
                        cmd.Execute(input);
                        break;
                    }
                }

                Console.Write("> ");
                input = Console.ReadLine();
            }
            while (input.ToLower().Trim() != "exit");

        }
    }
}
