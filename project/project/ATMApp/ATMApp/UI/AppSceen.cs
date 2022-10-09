
using ATMApp.Domain.Entites;
using System;

namespace ATMApp.UI
{

    public class AppSceen
    {
        internal const string cur = "₹";
        internal static void Welcome()
        {
            Console.Clear();
            Console.Title = "MY ATM APP";

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("\nWelcome to My ATM APP\n");
            Console.WriteLine("PLEASE INSERT YOUR ATM CARD  :");

            Utility.PressEnterToContinue();
            Console.ForegroundColor = ConsoleColor.White;
        }
        internal static UserAccount UserLogin()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("Your Card number: ");
            tempUserAccount.Cardpin = Convert.ToInt32(Utility.GetSecretInput("Enter Your PIN: "));
            return tempUserAccount;

        }
        internal static void LoginProgress()
        {
            Console.WriteLine("\nChecking card number and PIN..");
            Utility.DoProcess();
        }
        internal static void PrintLockscreen()
        {
            Console.Clear();
            Utility.PrintMsg("Your Account is locked ...Please go to the nearest branch" +
                " to unlock your Account..Thank YOU..:", true);
            Utility.PressEnterToContinue();
            Environment.Exit(1);
        }
        internal static void WelcomeCustmer(string fullName)
        {
            Console.WriteLine($"Welcome back,  {fullName}");
            Utility.PressEnterToContinue();
        }

        internal static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("---------My ATM App Menu----------");
            Console.WriteLine(":                            :");
            Console.WriteLine("1.Account Balance            :");
            Console.WriteLine("2.Cash Deposit               :");
            Console.WriteLine("3.Withdrwal                  :");
            Console.WriteLine("4.Transfer                   :");
            Console.WriteLine("5.Transacation               :");
            Console.WriteLine("6.Logout                     :");
        }
        internal static void LogOutprogress()
        {
            Console.WriteLine("Thank you for using My ATM App.");
            Utility.DoProcess();
            Console.Clear();
        }
        internal static int SelectAmount()
        {
            Console.WriteLine();
            Console.WriteLine(":1.{0}500   5.{0}10,000   ", cur);
            Console.WriteLine(":2.{0}1000  6.{0}15,000   ", cur);
            Console.WriteLine(":3.{0}2000   7.{0}20,000  ", cur);
            Console.WriteLine(":4.{0}5000   8.{0}40,000", cur);
            Console.WriteLine(":0.other");
            Console.WriteLine();

            int SelectedAmount = Validator.Convert<int>(" option:");
            switch (SelectedAmount)
            {
                case 1:
                    return 500;
                case 2:
                    return 1000;
                case 3:
                    return 2000;
                case 4:
                    return 5000;
                case 5:
                    return 10000;
                case 6:
                    return 15000;
                case 7:
                    return 20000;
                case 8:
                    return 40000;
                default:
                    Utility.PrintMsg("Invalid input .Try again..", false);

                    return -1;
            }


        }
        internal InternalTransfer InternalTransferForm()
        {
            var internalTransfer = new InternalTransfer
            {
                ReciepintBankAccountNumber = Validator.Convert<long>("recipient's account number:"),
                TransferAmount = Validator.Convert<decimal>($"amount {cur}"),
                RecipientBankAccountName = Utility.GetUserInput("recipient's name :")
            };
            return internalTransfer;
        }
    }
}

