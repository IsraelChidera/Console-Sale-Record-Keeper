using RecordKeeperApp.App;
using RecordKeeperApp.App.PartialClasses;
using RecordKeeperApp.Design;

namespace RecordKeeperApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.LoadingAnimation();
            Home.displayHome();

            CollectRecord records = new();
            records.CollectRecords();

            InstallmentChoice paymentChoice = new();
            paymentChoice.InstallmentalPayment();

        }
    }
}