namespace RecordKeeperApp
{
    class Record
    {
        private string _name;
        private string _amount;
        private DateTime _date;
        private decimal _percentage;
        private DateTime _startDate;       

        public Record() { }
       

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
                    dailyPayment();
                    break;
                case 2:
                    Console.WriteLine("Weekly plan");
                    weeklyPayment();
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

        public void dailyPayment()
        {
            _percentage = (decimal)(5d/100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{_name} willl pay {_amount} through the daily installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate=DateTime.Now}");

            int payment =(int) _percentage * Convert.ToInt32(_amount);
            Console.WriteLine(payment);
            Console.WriteLine($"{_name} chose the daily payment plan of paying {payment} till " +
                $"{_amount} is completed");
            Console.WriteLine(_percentage);
        }

        public void weeklyPayment()
        {
            _percentage = (decimal)(15d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{_name} willl pay {_amount} through the weekly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");
            Console.WriteLine(_percentage);
        }


    }
}
