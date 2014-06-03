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
    class Program
    {
        static void Main(string[] args)
        {
            // Open Package Manager Console (View -> Other Windows -> Package Manager Console)
            //   Install-Package Castle.Windsor

            var windsor = new WindsorContainer();
            windsor.Kernel.Resolver.AddSubResolver(new ArrayResolver(windsor.Kernel));
            windsor.Register(
                Classes.FromThisAssembly().Pick().WithServiceDefaultInterfaces()
            );

            var engine = windsor.Resolve<IGameEngine>();
            engine.Start();
        }

        public static bool IsSuccessful()
        {
            return (DateTime.Now.Ticks % 2) == 0;
        }
    }
}
