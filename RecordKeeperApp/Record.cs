namespace RecordKeeperApp
{
    class Record
    {
        private string _name;
        private string _amount;
        private DateTime _date;

        public Record() { }

        public Record(string name, string amount)
        {
            _name = name;
            _amount = amount;
            
        }

        public void collectRecords()
        {
            Console.WriteLine("Welcome onboard Mr Buhari...\n");
            Console.WriteLine("Do you want to add a record ?");
            Console.WriteLine("Press any key to start your application");
            Console.ReadLine();

            Console.WriteLine("\n******************** RECORDS ***************************");

            Console.Write("Name of buyer: ");
            _name = Console.ReadLine();

            while (true)
            {
                try
                {
                    if (_name?.Length >= 3)
                    {
                        Console.WriteLine("Name =====> {0}", _name);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Name is too short, Try again!");
                        _name = Console.ReadLine();
                    }
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine("Please enter a correct format");
                }
            }

            Console.Write("Amount owed: ");
            _amount = Console.ReadLine();

            while (true)
            {
                try
                {
                    if (int.TryParse(_amount, out int amt))
                    {
                        Console.WriteLine("Amount =====> {0}", amt);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter a valid number");
                        //amt = Convert.ToInt32(Console.ReadLine());
                        _amount = Console.ReadLine();
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Invalid amount");
                }
            }

            Console.WriteLine("\nSelect a Plan ");
            Console.WriteLine("4% installmental Payment with Daily Plan, Type 1");
            Console.WriteLine("5% installmental Payment with Weekly Plan , Type 2");
            Console.WriteLine("10% installmental Payment with Bi-Weekly Plan , Type 3");
            Console.WriteLine("20% installmental Payment with Monthly Plan , Type 4");
            Console.WriteLine("25% installmental Payment with Six-Month Plan , Type 5");
            Console.WriteLine("50% installmental Payment with Yearly , Type 6");

            int plan = Convert.ToInt32(Console.ReadLine());

            switch (plan)
            {
                case 1:
                    Console.WriteLine("Daily plan");
                    break;
                case 2:
                    Console.WriteLine("Weekly plan");
                    break;
                case 3:
                    Console.WriteLine("Weekly plan");
                    break;
                case 4:
                    Console.WriteLine("Monthyly plan");
                    break;
                default:
                    Console.WriteLine("Ibalid");
                    break;
            }
        }

       
    }
}
