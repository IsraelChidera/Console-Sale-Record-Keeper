using RecordKeeperApp.App.PartialClasses;
using RecordKeeperApp.Design;

namespace RecordKeeperApp.App
{
    internal class Installmentals
    {
        private double _percentage;
        private DateTime _startDate;
        private int _payment;
        public CollectRecord debtor = new();

        public enum Percentage
        {
            dailyPercentage = 5,
            weeklyPercentage = 10,
            biWeeklyPercentage = 25,
            monthlyPercentage = 30,
            sixMonthsPercentage = 40,
            yearlyPercentage = 50,
        }

        public void dailyPayment()
        {
            double dailyPercentage = (double)Percentage.dailyPercentage;
            //double num = debtor.GetAmount / _payment;
            
            _percentage = (double)(dailyPercentage / 100);            
            Utility.RecordHeader();

            Console.WriteLine($"\n{debtor.GetName} will pay N{debtor.GetAmount} through the daily installmental plan");
            //Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            Console.WriteLine("\n************************************************************");
            _payment =(int)(_percentage * debtor.GetAmount);
            double num = debtor.GetAmount / _payment;

            /*Console.WriteLine(_payment);*/
            Console.WriteLine($"{debtor.GetName} chose the daily payment plan of paying N{_payment} till " +
                $"N{debtor.GetAmount} is completed");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n************************************************************");
            Console.WriteLine("****************************************************************");
            _startDate = debtor.GetDateTime.AddDays(1);
            Console.WriteLine("Number of installment to pay ==>");
            Console.Write($"{num} installment");
            Console.Write("\nStart date for installment repayment ==>");
            Console.WriteLine(_startDate);            
            Console.WriteLine($"{debtor.GetName}'s payment is due on {DateTime.Now.AddDays(_payment)}");
            Console.ResetColor();

            Utility.ReturnToMenu();
        }

        public void weeklyPayment()
        {
            double weeklyPercentage = (double)Percentage.weeklyPercentage;

            _percentage = (double)(weeklyPercentage / 100);
            Utility.RecordHeader();
            
            Console.WriteLine($"{debtor.GetName} willl pay N{debtor.GetAmount} through the weekly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            /*_payment = (int)(_percentage * debtor.GetAmount);*/

            Console.WriteLine(_payment);
            Console.WriteLine($"{debtor.GetName} chose the weekly payment plan of paying N{_payment} till " +
                $"N{debtor.GetAmount} is completed\n");

            _startDate = debtor.GetDateTime.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{debtor.GetName} will pay total amount of{debtor.GetAmount} and it is due on {DateTime.Now.AddDays(_payment)}");

            Utility.ReturnToMenu();
        }

        public void biWeeklyPayment()
        {
            double biWeeklyPercentage = (double)Percentage.biWeeklyPercentage;

            _percentage = (double)(biWeeklyPercentage / 100);
            Utility.RecordHeader();

            Console.WriteLine($"{debtor.GetName} willl pay N{debtor.GetAmount} through the bi-weekly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            //_payment = (int)(_percentage * debtor.GetAmount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{debtor.GetName} chose the bi-weekly payment plan of paying N{_payment} till " +
                $"N{debtor.GetAmount} is completed\n");

            _startDate = debtor.GetDateTime.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{debtor.GetName} will pay total amount of{debtor.GetAmount} and it is due on {DateTime.Now.AddDays(_payment)}");

            Utility.ReturnToMenu();
        }

        public void monthly()
        {
            double monthlyPercentage = (double)Percentage.monthlyPercentage;

            _percentage = (double)(monthlyPercentage / 100);
            Utility.RecordHeader();

            Console.WriteLine($"{debtor.GetName} willl pay N{debtor.GetAmount} through the monthly installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            //_payment = (int)(_percentage * debtor.GetAmount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{debtor.GetName} chose the monthly payment plan of paying N{_payment} till " +
                $"N{debtor.GetAmount} is completed\n");

            _startDate = debtor.GetDateTime.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{debtor.GetName} will pay total amount of{debtor.GetAmount} and it is due on {DateTime.Now.AddDays(_payment)}");

            Utility.ReturnToMenu();
        }

        public void sixMonths()
        {
            double sixMonthsPercentage = (double)Percentage.sixMonthsPercentage;

            _percentage = (double)(sixMonthsPercentage / 100);
            Utility.RecordHeader();

            Console.WriteLine($"{debtor.GetName} willl pay N{debtor.GetAmount} through the 6-month installmental plan");
            Console.WriteLine($"Date of purchase: {_startDate = DateTime.Now}");

            //_payment = (int)(_percentage * debtor.GetAmount);

            Console.WriteLine(_payment);
            Console.WriteLine($"{debtor.GetName} chose the 6-month payment plan of paying N{_payment} till " +
                $"N{debtor.GetAmount} is completed\n");

            _startDate = debtor.GetDateTime.AddDays(1);
            Console.WriteLine(_startDate);
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"{debtor.GetName} will pay total amount of{debtor.GetAmount} and it is due on {DateTime.Now.AddDays(_payment)}");


            Utility.ReturnToMenu();
        }

        public void yearly()
        {
            double yearlyPercentage = (double)Percentage.yearlyPercentage;

            _percentage = (double)(yearlyPercentage / 100);
            Utility.RecordHeader();

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

            Utility.ReturnToMenu();
        }

    }
}
