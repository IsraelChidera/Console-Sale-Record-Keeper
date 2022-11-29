using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperApp.App.PartialClasses
{
    public class RecordCollection
    {
    }

    public partial class CollectRecord
    {
        private static string _name;
        private static decimal _amount;
        public DateTime date;

        public string? GetName
        {
            get { return _name; }
            //set { _name = value; }
            
        }
       
        public decimal GetAmount
        {
            get { return _amount; }
            //set { _amount = value; }
        }

        public DateTime GetDateTime
        {
            get { return date; }
            set { date = value; }
        }

        public enum PaymentMade
        {
            minimumPayment = 10000,
            minuimumNameLength = 3
        }

        public CollectRecord()
        {

        }

        public CollectRecord(string name, decimal amount)
        {
            _name = name;
            _amount = amount;
        }
    }
    
}
