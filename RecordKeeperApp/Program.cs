using RecordKeeperApp.App;
using RecordKeeperApp.Design;

namespace RecordKeeperApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.LoadingAnimation();
            Home.displayHome();

            Record recordInput = new();
            recordInput.CollectRecords();
        }
    }
}