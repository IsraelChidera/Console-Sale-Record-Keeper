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
        private double _amount;
        private double _quantity;
        private int _totalAmount;

        public Record(){}

        public Record(string name, double amount, double quantity, int totalAmount)
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

            int? name = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} ",name);
        }
    }
}
