using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public static class CommandFactory
    {
        public static ICommand[] GetCommands()
        {
            return new ICommand[] {
                    new DanceCommand(),
                    new PassCommand(),
                    new ShootCommand()
                };
        }
    }
}
