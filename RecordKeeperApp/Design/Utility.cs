using RecordKeeperApp.App;
using RecordKeeperApp.App.PartialClasses;
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

        public static void ReturnToMenu()
        {
            Console.WriteLine("\n\nDo you want to add another record\nPress 1 to continue\nPress 0 to exit");

            int toContinue = Convert.ToInt32(Console.ReadLine());

            InstallmentChoice choice = new();
            CollectRecord records = new();
            
            switch (toContinue)
            {
                case 1:
                    records.CollectRecords();
                    choice.InstallmentalPayment();
                    break;
                case 0:
                    Console.WriteLine("Thank you for banking with us");
                    break;
            }
        }

        public static void RecordHeader()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n*************************************************************");
            Console.WriteLine("Record list");
            Console.WriteLine("**************************************************************");
            Console.ResetColor();
            Console.WriteLine("Hello, Mr Buhari...\nHere is a record list of those owing you\n");
        }
    }
}
