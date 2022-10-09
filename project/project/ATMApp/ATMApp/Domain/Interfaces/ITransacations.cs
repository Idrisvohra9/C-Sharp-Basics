using ATMApp.Domain.Enums;

namespace ATMApp.Domain.Interfaces
{
     public interface ITransacations
    {
        void InsertTranscaction(long _UserBankAccountId, TransactionType _tranType, decimal _tranAmount, string _desc);
        void viewTransaction();
    }
}
