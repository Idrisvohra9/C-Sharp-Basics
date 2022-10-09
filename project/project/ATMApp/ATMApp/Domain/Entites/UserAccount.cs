using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.Domain.Entites
{
   public class UserAccount
    {
        public int Id { get; set;  }
        public long CardNumber { get; set; }
        public int Cardpin { get; set; }
        public long AccountNumber { get; set; }
        public string FullName { get; set; }

        public decimal AccountBalance { get; set; }
        public int TotalLogin { get; set; }

        public bool IsLocked { get; set; }

    }
}
