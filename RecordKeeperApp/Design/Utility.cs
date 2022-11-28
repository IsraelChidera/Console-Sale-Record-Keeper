using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperApp.Design
{
    public static class Utility
    {
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\nPlease press enter to continue");            

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {                
            }
        }

        public static void LoadingAnimation(int timer=18)
        {
            for(var i=0; i<timer; i++)
            {
                Console.Write(".");
            }
            Thread.Sleep(200);
        }

    }
}
