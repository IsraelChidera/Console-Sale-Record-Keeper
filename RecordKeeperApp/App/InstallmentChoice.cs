namespace RecordKeeperApp.App
{
    class InstallmentChoice
    {
        private Installmentals paymentInstallment = new();
        public void InstallmentalPayment()
        {
            Console.WriteLine("\nSelect a Plan ");
            Console.WriteLine("======> For a 5% installmental Payment via a Daily Plan, Type 1");
            Console.WriteLine("======> For a 10% installmental Payment via a Weekly Plan , Type 2");
            Console.WriteLine("======> For a 25% installmental Payment via a Bi-Weekly Plan , Type 3");
            Console.WriteLine("======> For a 30% installmental Payment via a Monthly Plan , Type 4");
            Console.WriteLine("======> For a 40% installmental Payment via a Six-Month Plan , Type 5");
            Console.WriteLine("======> For a 50% installmental Payment via a One-Year Plan , Type 5");

            Console.Write("\nSelect plan ------> ");
            int paymentChoice = Convert.ToInt32(Console.ReadLine());

            switch (paymentChoice)
            {
                case 1:
                    Console.WriteLine("Daily plan");
                    paymentInstallment.dailyPayment();
                    break;
                case 2:
                    Console.WriteLine("Weekly plan");
                    paymentInstallment.weeklyPayment();
                    break;
                case 3:
                    Console.WriteLine("Weekly plan");
                    Console.WriteLine("Bi-weekly plan");
                    paymentInstallment.biWeeklyPayment();
                    break;
                case 4:
                    Console.WriteLine("Monthyly plan");
                    paymentInstallment.monthly();
                    break;
                case 5:
                    Console.WriteLine("6-month plan");
                    paymentInstallment.sixMonths();
                    break;
                case 6:
                    Console.WriteLine("Yearly plan");
                    paymentInstallment.yearly();
                    break;
                default:
                    Console.WriteLine("Invalid plan");
                    break;
            }


        }
    }
}
