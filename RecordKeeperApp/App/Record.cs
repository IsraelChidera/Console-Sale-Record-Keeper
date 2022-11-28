using RecordKeeperApp.App.Interfaces;

namespace RecordKeeperApp.App
{
    class Record : IRecordCollection
    {
        private string _name;
        private int _amount;
        private DateTime _date;
        private decimal _percentage;
        private DateTime _startDate;
        private int _payment;


        public Record() { }


        public void CollectRecords()
        {


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
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a correct format");
                }
            }

            Console.Write("Amount to pay: ");
            _amount = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                try
                {
                    if (_amount > 10000)
                    {
                        Console.WriteLine("Amount =====> {0}", _amount);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. You can only pay installmental for products higher than" +
                            " N10000");
                        _amount = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid amount");
                    Console.WriteLine(e.ToString());
                    Console.Write("Amount owed: ");
                    _amount = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nSelect a Payment Plan ");
            Console.WriteLine("======> For a 5% installmental Payment with Daily Plan, Type 1");
            Console.WriteLine("======> For a 10% installmental Payment with Weekly Plan , Type 2");
            Console.WriteLine("======> For a 25% installmental Payment with Bi-Weekly Plan , Type 3");
            Console.WriteLine("======> For a 30% installmental Payment with Monthly Plan , Type 4");
            Console.WriteLine("======> For a 40% installmental Payment with Six-Month Plan , Type 5");
            Console.WriteLine("======> For a 50% installmental Payment with Yearly , Type 6");

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
                    Console.WriteLine("Bi-weekly plan");
                    biWeeklyPayment();
                    break;
                case 4:
                    Console.WriteLine("Monthyly plan");
                    monthly();
                    break;
                case 5:
                    Console.WriteLine("6-month plan");
                    sixMonths();
                    break;
                case 6:
                    Console.WriteLine("Yearly plan");
                    yearly();
                    break;
                default:
                    Console.WriteLine("Invalid plan");
                    break;
            }


        }

        public void dailyPayment()
        {
            _percentage = (decimal)(5d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{_name} willl pay N{_amount} through the daily installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            _payment = (int)(_percentage * _amount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{_name} chose the daily payment plan of paying N{_payment} till " +
                $"N{_amount} is completed\n");

            _startDate = _date.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{_name} will pay total amount of{_amount} and it is due on {DateTime.Now.AddDays(_payment)}");

        }

        public void weeklyPayment()
        {
            _percentage = (decimal)(10d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{_name} willl pay N{_amount} through the weekly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            _payment = (int)(_percentage * _amount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{_name} chose the weekly payment plan of paying N{_payment} till " +
                $"N{_amount} is completed\n");

            _startDate = _date.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{_name} will pay total amount of{_amount} and it is due on {DateTime.Now.AddDays(_payment)}");


        }

        public void biWeeklyPayment()
        {
            _percentage = (decimal)(10d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{_name} willl pay N{_amount} through the bi-weekly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            _payment = (int)(_percentage * _amount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{_name} chose the bi-weekly payment plan of paying N{_payment} till " +
                $"N{_amount} is completed\n");

            _startDate = _date.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{_name} will pay total amount of{_amount} and it is due on {DateTime.Now.AddDays(_payment)}");

        }

        public void monthly()
        {
            _percentage = (decimal)(10d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{_name} willl pay N{_amount} through the monthly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            _payment = (int)(_percentage * _amount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{_name} chose the monthly payment plan of paying N{_payment} till " +
                $"N{_amount} is completed\n");

            _startDate = _date.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{_name} will pay total amount of{_amount} and it is due on {DateTime.Now.AddDays(_payment)}");

        }

        public void sixMonths()
        {
            _percentage = (decimal)(10d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{_name} willl pay N{_amount} through the 6-month installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            _payment = (int)(_percentage * _amount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{_name} chose the 6-month payment plan of paying N{_payment} till " +
                $"N{_amount} is completed\n");

            _startDate = _date.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{_name} will pay total amount of{_amount} and it is due on {DateTime.Now.AddDays(_payment)}");

        }

        public void yearly()
        {
            _percentage = (decimal)(10d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{_name} willl pay N{_amount} through the yearly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            _payment = (int)(_percentage * _amount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{_name} chose the yearly payment plan of paying N{_payment} till " +
                $"N{_amount} is completed\n");

            _startDate = _date.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{_name} will pay total amount of{_amount} and it is due on {DateTime.Now.AddDays(_payment)}");

        }
    }
}
