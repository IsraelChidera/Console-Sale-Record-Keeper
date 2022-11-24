using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperApp
{
    class Record
    {
        private string _name;
        private int _amount;
        private double _quantity;
        private int _totalAmount;

        public Record(){}

        public Record(string name, int amount, double quantity, int totalAmount)
        {
            _name = name;
            _amount = amount;
            _quantity = quantity;
            _totalAmount = totalAmount;
        }

        public void collectRecords()
        {
            Console.WriteLine("Welcome onboard Mr Buhari...\n");
            Console.WriteLine("Do you want to add a record of sale?");
            Console.WriteLine("Click 1 if yes\nClick 0 to exit");

            while (true)
            {
                try
                {
                    Console.WriteLine("\n***************** RECORDS ***********************");
                    Console.Write("Name of buyer");
                    _name = Console.ReadLine();

                    if (_name?.Length <= 3)
                    {
                        Console.WriteLine("Name is too short. It must be longer than 3");
                        continue;
                    }
                    Console.WriteLine("Your name is {0} ", _name);                  

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                _amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your name is {0} ", _amount);
            }

            
        }
    }
}
