using ATMApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.Domain.Entites
{
     public class Transaction
    {
        public long TransactionId { get; set; }

        public long UserBankAccountId { get; set; }

        public DateTime  TransactionDate { get; set; }

        public TransactionType Transactiontype { get; set; }

        public string Descriprion { get; set; }

        public decimal TransactionAmount { get; set; }





    }
}
