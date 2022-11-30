using RecordKeeperApp.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperApp.Design
{
    static class Home
    {
        public static void displayHome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n*************************************************");
            Console.WriteLine("\t\tMr Buhari Records");
            Console.WriteLine("*************************************************\n");
            Console.ResetColor();

            Console.WriteLine("Welcome onboard Mr Buhari...");
            Console.WriteLine("Do you want to add a record ?");
            Console.WriteLine("You can only add an installmental payment for products higher than N10000");
            Utility.PressEnterToContinue();
            Utility.LoadingAnimation();
            
        }
    }
}
