using RecordKeeperApp.App.PartialClasses;

namespace RecordKeeperApp.App
{
    class Record:RecordCollectionTwo
    {
       
        private decimal _percentage;
        private DateTime _startDate;
        private int _payment;
        public CollectRecord debtor = new();
        


        public Record() { }



        public void dailyPayment()
        {
            _percentage = (decimal)(5d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{debtor.GetName} willl pay N{debtor.GetAmount} through the daily installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");
            
            _payment = (int)(_percentage * debtor.GetAmount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{debtor.GetName} chose the daily payment plan of paying N{_payment} till " +
                $"N{debtor.GetAmount} is completed\n");

            _startDate = debtor.GetDateTime.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{debtor.GetName} will pay total amount of{debtor.GetAmount} and it is due on {DateTime.Now.AddDays(_payment)}");

        }

        public void weeklyPayment()
        {
            _percentage = (decimal)(10d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{debtor.GetName} willl pay N{debtor.GetAmount} through the weekly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            _payment = (int)(_percentage * debtor.GetAmount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{debtor.GetName} chose the weekly payment plan of paying N{_payment} till " +
                $"N{debtor.GetAmount} is completed\n");

            _startDate = debtor.GetDateTime.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{debtor.GetName} will pay total amount of{debtor.GetAmount} and it is due on {DateTime.Now.AddDays(_payment)}");


        }

        public void biWeeklyPayment()
        {
            _percentage = (decimal)(10d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{debtor.GetName} willl pay N{debtor.GetAmount} through the bi-weekly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            _payment = (int)(_percentage * debtor.GetAmount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{debtor.GetName} chose the bi-weekly payment plan of paying N{_payment} till " +
                $"N{debtor.GetAmount} is completed\n");

            _startDate = debtor.GetDateTime.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{debtor.GetName} will pay total amount of{debtor.GetAmount} and it is due on {DateTime.Now.AddDays(_payment)}");

        }

        public void monthly()
        {
            _percentage = (decimal)(10d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{debtor.GetName} willl pay N{debtor.GetAmount} through the monthly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            _payment = (int)(_percentage * debtor.GetAmount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{debtor.GetName} chose the monthly payment plan of paying N{_payment} till " +
                $"N{debtor.GetAmount} is completed\n");

            _startDate = debtor.GetDateTime.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{debtor.GetName} will pay total amount of{debtor.GetAmount} and it is due on {DateTime.Now.AddDays(_payment)}");

        }

        public void sixMonths()
        {
            _percentage = (decimal)(10d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{debtor.GetName} willl pay N{debtor.GetAmount} through the 6-month installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            _payment = (int)(_percentage * debtor.GetAmount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{debtor.GetName} chose the 6-month payment plan of paying N{_payment} till " +
                $"N{debtor.GetAmount} is completed\n");

            _startDate = debtor.GetDateTime.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{debtor.GetName} will pay total amount of{debtor.GetAmount} and it is due on {DateTime.Now.AddDays(_payment)}");

        }

        public void yearly()
        {
            _percentage = (decimal)(10d / 100);
            Console.WriteLine("Record list");
            Console.WriteLine($"{debtor.GetName} willl pay N{debtor.GetAmount} through the yearly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            _payment = (int)(_percentage * debtor.GetAmount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{debtor.GetName} chose the yearly payment plan of paying N{_payment} till " +
                $"N{debtor.GetAmount} is completed\n");

            _startDate = debtor.GetDateTime.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{debtor.GetName} will pay total amount of{debtor.GetAmount} and it is due on {DateTime.Now.AddDays(_payment)}");

        }
    }
}
