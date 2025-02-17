using System;

namespace PersonalFinanceTracker.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
