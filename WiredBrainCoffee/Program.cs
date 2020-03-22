using System;
using WiredBrainCoffee.DataAccess;

namespace WiredBrainCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            /// This is a comment to update this file
            /// Now this is a 2nd comment to this file
            /// Here now is a 3rd comment!
            Console.WriteLine("Wired Brain Coffee!");
            Console.WriteLine("Write 'help' to list available Coffee Shop commands");
            var coffeeShopDataProvider = new CoffeeShopDataProvider();

            while (true)

            {
                var line = Console.ReadLine(); 
                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();
                if(string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available coffee shop commands:");
                    foreach(var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> " + coffeeShop.Location);

                    }
                }
            }
        }
    }
}
