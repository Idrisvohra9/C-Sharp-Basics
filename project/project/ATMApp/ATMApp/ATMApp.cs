using ATMApp.Domain.Entites;
using ATMApp.Domain.Enums;
using ATMApp.Domain.Interfaces;
using ATMApp.UI;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATMApp
{
    public class ATMApp : IUserLogin, IUserAccountActions, ITransacations
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;
        private List<Transaction> _listoftransactions;
        private const decimal minimumKeptAmount = 500;
        private readonly AppSceen screen;


        public ATMApp()
        {
            screen = new AppSceen();
        }



        public void Run()
        {
            AppSceen.Welcome();
            CheckUserCardNumAndPassword();
            AppSceen.WelcomeCustmer(selectedAccount.FullName);
            while (true)
            {
                AppSceen.DisplayMenu();
                ProcessMenuOption();
            }
        }

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount {Id =1, FullName ="Idris Vohra",AccountNumber =9876,CardNumber=123456,Cardpin=123456,AccountBalance=19000,IsLocked=false },
                new UserAccount {Id =2, FullName ="Haider",AccountNumber =4567,CardNumber=654321,Cardpin=7943,AccountBalance=20000,IsLocked=false },
                new UserAccount {Id =3, FullName ="Haider D.Souza",AccountNumber =1234,CardNumber=543210,Cardpin=1511,AccountBalance=15000,IsLocked=true },

            };
            _listoftransactions = new List<Transaction>();
            
        }

        public void CheckUserCardNumAndPassword()
        {
            bool isCorrectLogin = false;
            while (!isCorrectLogin)
            {
                UserAccount inputAccount = AppSceen.UserLogin();
                AppSceen.LoginProgress();
                foreach (UserAccount account in userAccountList)
                {
                    selectedAccount = account;
                    if (inputAccount.CardNumber.Equals(selectedAccount.CardNumber))
                    {
                        selectedAccount.TotalLogin++;
                        if (inputAccount.Cardpin.Equals(selectedAccount.Cardpin))
                        {
                            selectedAccount = account;
                            if (selectedAccount.IsLocked || selectedAccount.TotalLogin > 3)
                            {
                                AppSceen.PrintLockscreen();
                            }
                            else
                            {
                                selectedAccount.TotalLogin = 0;
                                isCorrectLogin = true;
                                break;
                            }
                        }
                    }
                }
            }
            if (!isCorrectLogin)
            {
                Utility.PrintMsg("\n Invalid card number or PIN", false);
                selectedAccount.IsLocked = selectedAccount.TotalLogin == 3;
                if (selectedAccount.IsLocked)
                {
                    AppSceen.PrintLockscreen();
                }
            }
            Console.Clear();
        }
        private void ProcessMenuOption()
        {
            switch (Validator.Convert<int>("an option:"))
            {
                case (int)AppMenu.CheckBalance:
                    CheckBalance();
                    break;
                case (int)AppMenu.PlaceDeposit:
                    PlaceDeposit();
                    break;
                case (int)AppMenu.MakeWithdrawal:
                    MakeWithDrawal();
                    break;
                case (int)AppMenu.InternalTransfer:
                    var internalTransfer = screen.InternalTransferForm();
                    ProcessInternalTransfer(internalTransfer);
                    break;
                case (int)AppMenu.ViewTransaction:
                    viewTransaction();
                    break;
                case (int)AppMenu.Logout:
                    AppSceen.LogOutprogress();
                    Utility.PrintMsg("You have successfully logged out. " +
                        "please collect your ATM card..");
                    Run();
                    break;

                default:

                    Console.WriteLine("default action.....");
                    Utility.PrintMsg("Invalid option.", false);
                    break;
            }
        }

        public void CheckBalance()
        {

            Utility.PrintMsg($" Your account balance is: {Utility.FormatAmount(selectedAccount.AccountBalance)}");
        }

        public void PlaceDeposit()
        {
            Console.WriteLine("\n Only multiples of 500 and 1000." +
                " allowed.\n");
            var transcation_amt = Validator.Convert<int>($"amount{AppSceen.cur}");

            Console.WriteLine("\n Checking and counting Bank Notes..");
            Utility.DoProcess();
            Console.WriteLine("");

            if (transcation_amt <= 0)
            {
                Utility.PrintMsg("Amount need to be greter than zero. Try again.", false);
                return;
            }
            if (transcation_amt % 500 != 0)
            {
                Utility.PrintMsg($" Enter deposit amount in multiples of 500  or 1000 ruppes");
                return;
            }
            if (previewBankNotesCount(transcation_amt) == false)
            {
                Utility.PrintMsg($"You have cancelled Your action:", false);
                return;
            }
            InsertTranscaction(selectedAccount.Id, TransactionType.Deposit, transcation_amt, "");

            selectedAccount.AccountBalance += transcation_amt;

            Utility.PrintMsg($" Your deposit of {Utility.FormatAmount(transcation_amt)}" +
                $"works succesful.", true);
        }

        public void MakeWithDrawal()
        {
            var transaction_amt = 0;
            int selectedAmount = AppSceen.SelectAmount();
            if (selectedAmount == -1)
            {
                MakeWithDrawal();
                return;
            }
            else if (selectedAmount != 0)
            {
                transaction_amt = selectedAmount;
            }
            else
            {
                transaction_amt = Validator.Convert<int>($"amount{AppSceen.cur}");

            }


            if (transaction_amt <= 0)
            {
                Utility.PrintMsg("Amount needs to be greater than zero.Try again", false);
                return;
            }
            if (transaction_amt % 500 != 0)
            {
                Utility.PrintMsg("You can only Withdraw amount in multiples of 500  or 1000 ruppes.Try again", false);
                return;
            }

            //bussiness logic validations.
            if (transaction_amt > selectedAccount.AccountBalance)
            {
                Utility.PrintMsg($"Withdrawal failed.Your balance is too low to Withdrawal" +
                    $"amount{Utility.FormatAmount(transaction_amt)}", false);
                return;

            }
            if ((selectedAccount.AccountBalance - transaction_amt) < minimumKeptAmount)
            {
                Utility.PrintMsg($"Withdrawal failed. Your account needs to have" +
                    $"minimum{Utility.FormatAmount(minimumKeptAmount)}");
                return;

            }
            InsertTranscaction(selectedAccount.Id, TransactionType.Withdrawal, transaction_amt, "");
            {
                selectedAccount.AccountBalance -= transaction_amt;
                Utility.PrintMsg($"You have Succesfully Withdrawn" +
                    $"{Utility.FormatAmount(transaction_amt)}.", true);
            }

        }
        private bool previewBankNotesCount(int amount)
        {
            int thousandNotesCount = amount / 1000;
            int fiveHundredNotesCount = (amount % 1000) / 500;
            int twothousandNotesCount = amount / 2000;

            Console.WriteLine("\n Summary");
            Console.WriteLine("------");
            Console.WriteLine($"{AppSceen.cur}1000 X {thousandNotesCount} = {1000 * thousandNotesCount}");
            Console.WriteLine($"{AppSceen.cur}500 X {fiveHundredNotesCount} = {500 * fiveHundredNotesCount}");
            Console.WriteLine($"{AppSceen.cur}2000 X {twothousandNotesCount} = {2000 * twothousandNotesCount}");
            Console.WriteLine($"Total amount:{Utility.FormatAmount(amount)}");

            int opt = Validator.Convert<int>(" 1. Confirm");
            return opt.Equals(1);
        }

        public void InsertTranscaction(long _UserBankAccountId, TransactionType _tranType, decimal _tranAmount, string _desc)
        {
            var transaction = new Transaction()
            {
                TransactionId = Utility.GetTransactionId(),
                UserBankAccountId = _UserBankAccountId,
                TransactionDate = DateTime.Now,
                Transactiontype = _tranType,
                TransactionAmount = _tranAmount,
                Descriprion = _desc

            };
            _listoftransactions.Add(transaction);
        }

        public void viewTransaction()
        {
            var filteredTransactionList = _listoftransactions.Where(t => t.UserBankAccountId == selectedAccount.Id).ToList();
            if (filteredTransactionList.Count <= 0)
            {
                Utility.PrintMsg("You have no trasaction Yet..", true);
            }
            else
            {
                var table = new ConsoleTable("Id", "Transaction Date", "Type", "Descriptions", "Amount" + AppSceen.cur);
                foreach (var tran in filteredTransactionList)
                {
                    table.AddRow(tran.TransactionId, tran.TransactionDate, tran.Transactiontype, tran.Descriprion, tran.TransactionAmount);

                }
                table.Options.EnableCount = false;
                table.Write();
                Utility.PrintMsg($"You have {filteredTransactionList.Count}trasaction(s)", true);
            }
        }
        private void ProcessInternalTransfer(InternalTransfer internalTransfer)
        {
            if (internalTransfer.TransferAmount <= 0)
            {
                Utility.PrintMsg("Amount needs to be more than zero..Try again.", false);
                return;

            }

            if (internalTransfer.TransferAmount > selectedAccount.AccountBalance)
            {
                Utility.PrintMsg($"Transfer failed..You do not have enough balance to " +
                    $"transfer {Utility.FormatAmount(internalTransfer.TransferAmount)}", false);
                return;
            }
            if ((selectedAccount.AccountBalance - internalTransfer.TransferAmount) < minimumKeptAmount)
            {
                Utility.PrintMsg($"Transfer failed . Your account needs to have minimum {Utility.FormatAmount(minimumKeptAmount)}", false);
                return;
            }
            var selBankAccRec = (from userAcc in userAccountList
                                              where userAcc.AccountNumber == internalTransfer.ReciepintBankAccountNumber
                                              select userAcc).FirstOrDefault();
            if (selBankAccRec == null)
            {
                Utility.PrintMsg("Transfer failed..Recipient's Bank account  number is invalid.", false);
                return;
            }
            if (selBankAccRec.FullName != internalTransfer.RecipientBankAccountName)
            {
                Utility.PrintMsg("Transfer failed Recipient's Bank account name does not match. ", false);
                return;
            }
            InsertTranscaction(selectedAccount.Id, TransactionType.Tranfer, -internalTransfer.TransferAmount, "" +
                $"to{selBankAccRec.AccountNumber}({selBankAccRec.FullName}");


            selectedAccount.AccountBalance -= internalTransfer.TransferAmount;

            InsertTranscaction(selBankAccRec.Id, TransactionType.Tranfer, internalTransfer.TransferAmount, "Transfered " +
                $"{selectedAccount.AccountNumber}({selectedAccount.FullName}");

            selBankAccRec.AccountBalance += internalTransfer.TransferAmount;

            Utility.PrintMsg($"You have succesfully transfered" +
                $"{Utility.FormatAmount(internalTransfer.TransferAmount)} to" +
                $"{internalTransfer.RecipientBankAccountName}", true);
        }
    }
}
