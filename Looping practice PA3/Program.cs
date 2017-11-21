using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_practice_PA3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Package Shipping Calculator");

            string packagesInput;
            int packages;  // total packages entered by user

            Console.WriteLine(); //deliberately blank

            Console.Write("How many packages would you like to ship? ");
            packagesInput = Console.ReadLine();

            packages = int.Parse(packagesInput);

            Console.WriteLine(); // intentionally blank

            Console.WriteLine(); // intentionally blank

            int startPackages;      // put in new variable for start point that will progress toward total number of packages.  
            startPackages = 1;

            string weightInput;  // user inputs weight that must be parsed into double status
            double weight;

            // need a variable to sum all of the weights of the packages

            double sum;
            sum = 0;  // sum value starts at 0 and we will add each weight to it.

            while (startPackages > 0 && startPackages <= packages)  //range is between 0 and whatever the user inputs
            {
                Console.Write("Please enter the weight of package {0}:  ", startPackages);
                weightInput = Console.ReadLine();
                weight = double.Parse(weightInput);

                sum = sum + weight;

                startPackages++;

            }

            Console.WriteLine(); // intentionally blank

            Console.WriteLine("The total cost to ship {0} packages is {1:C}", packages, sum);




            Console.ReadKey();
        }
    }
}
