using CsvHelper.Configuration.Attributes;
using System;

namespace SmartSaver.entities
{
    class Transaction
    {
        [Index(0)]
        public DateTime Date { get; set; }
        [Index(1)]
        public /*decimal*/ string Amount { get; set; }
        [Index(2)]
        public string Details { get; set; }
        [Index(3)]
        public string CounterParty { get; set; }

        public Transaction(DateTime aDate, string aAmount, string aDetails, string aCounterParty)
        {
            this.Date = aDate;
            this.Amount = aAmount;
            this.Details = aDetails;
            this.CounterParty = aCounterParty;
        }

        override
        public string ToString() => 
            Date.ToShortDateString() + "; " 
            + Amount + "; " 
            + Details + "; " 
            + CounterParty;
    }
}
