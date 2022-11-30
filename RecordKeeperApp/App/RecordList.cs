using RecordKeeperApp.App.PartialClasses;
using RecordKeeperApp.Design;

namespace RecordKeeperApp.App
{
    /*class Record
    {
        CollectRecord records = new();

        public void display()
        {
            //displaying
            Console.WriteLine("displaying");
            Console.WriteLine(records.GetAmount);
            Console.WriteLine(records.GetAmount);
        }
    }*/

    internal class RecordList
    {

        public CollectRecord recording = new();

        public void useList()
        {
            List<CollectRecord> records = new();
            

            records.Add(new CollectRecord()
            {
                GetName = recording.GetName,
                GetAmount = recording.GetAmount,
                GetDateTime = recording.GetDateTime
            });

            Utility.RecordHeader();
            foreach(var record in records)
            {
                Console.WriteLine($"\t{record.GetName}--------{record.GetAmount}");
            }
        }
    }
}
