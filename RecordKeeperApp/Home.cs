using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperApp
{
    static class Home
    {
        public static void displayHome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************************************");
            Console.WriteLine("\t\tMr Buhari Records");
            Console.WriteLine("*************************************************\n");
            Console.ResetColor();
        }
    }
}
