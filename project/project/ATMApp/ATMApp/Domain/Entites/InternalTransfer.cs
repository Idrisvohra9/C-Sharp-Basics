using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.Domain.Entites
{
   public class InternalTransfer
    {
       public decimal TransferAmount { get; set; }
        public long ReciepintBankAccountNumber{ get; set; }

        public string RecipientBankAccountName { get; set; }


    }
}
