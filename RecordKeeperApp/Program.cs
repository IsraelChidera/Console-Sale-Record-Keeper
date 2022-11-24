namespace RecordKeeperApp
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Home.displayHome();

            Record recordInput = new();
            recordInput.collectRecords();
        }
    }
}