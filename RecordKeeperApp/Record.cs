namespace RecordKeeperApp
{
    class Record
    {
        private string _name;
        private int _amount;
        private DateTime _date;
        private decimal _percentage;
        private DateTime _startDate;
        private int _payment;
        

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
            _amount = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                try
                {
                    if (_amount>35000)
                    {
                        Console.WriteLine("Amount =====> {0}", _amount);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. You can only pay installmental for products higher than" +
                            " N35000");                        
                        _amount = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine("Invalid plan");
                    break;
            }

            
        }

        public void dailyPayment()
        {
            _percentage = ((decimal)(5d / 100));
            Console.WriteLine("Record list");
            Console.WriteLine($"{_name} willl pay N{_amount} through the daily installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate=DateTime.Now}");

            _payment = (int)(_percentage * _amount);
            
            Console.WriteLine(_payment);
            Console.WriteLine($"{_name} chose the daily payment plan of paying N{_payment} till " +
                $"N{_amount} is completed");
            _startDate = _date.AddDays(1);
            Console.WriteLine("****************************************************************");
            for (int i = _payment; i < _amount; i += _payment)
            {
                Console.WriteLine($"{_name} will pay {_payment} for {_startDate.ToLongDateString()}");
                _startDate = _date.AddDays(1);
            }
        }

        public void weeklyPayment()
        {
            //_percentage = (15d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{_name} willl pay N{_amount} through the weekly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");
            

            
        }


    }
}
