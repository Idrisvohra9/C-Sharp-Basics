using ATMApp.UI;

namespace ATMApp.App
{
    class Entry
    {
        static void Main(string[] args)
        {
            ATMApp make = new ATMApp();
            
            make.InitializeData();
            make.Run();

            Utility.PressEnterToContinue();


        }

    }
}
