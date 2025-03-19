using DesignPatterns.Factory.Factories;
using DesignPatterns.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Services
{
    public class PackageService
    {
        private readonly Dictionary<int, PackageFactory> _factories;

        public PackageService()
        {
            _factories = new Dictionary<int, PackageFactory>
            {
                { 1, new StandardPackageFactory() },
                { 2, new ExpressPackageFactory() }
            };
        }

        public void RunFactoryMethod()
        {
            Console.WriteLine("Select a package type:");
            Console.WriteLine("1 - Standard Package");
            Console.WriteLine("2 - Express Package");

            if (int.TryParse(Console.ReadLine(), out int choice) && _factories.ContainsKey(choice))
            {
                IPackage package = _factories[choice].CreatePackage();
                package.Deliver();
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
    }
}
