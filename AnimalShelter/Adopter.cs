using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Adopter
    {
        public double walletBalance;
        public double dogPrice;
        public double catPrice;
        public string adopterName;
       

        public Adopter()
        {
            
            
        }


        public string AdopterProfile()
        {
            Console.WriteLine("What is your name?");
            adopterName = Console.ReadLine();
            Console.WriteLine("----------------------");
            return adopterName;

        }

        public void GetWalletBalance()
        {
            walletBalance = Convert.ToDouble(Console.ReadLine());
            
        }


        public double AdopterBudget()
        {
            Console.WriteLine("How much money do you have to spend with us today? Our dogs are $200.00 and our cats are $150.00 ");
            GetWalletBalance();
            Console.WriteLine("----------------------");


            return walletBalance;
        }

        public double WalletBalanceTracker()
        {
            Console.WriteLine(adopterName+", you now have "+walletBalance+ " dollars in your wallet.");
            return walletBalance;
        }


        public double PurchaseDog()
        {
            dogPrice = 200.00;
            walletBalance = walletBalance - dogPrice;

            return walletBalance;

        }

        public double PurchaseCat()
        {
            catPrice = 150.00;
            walletBalance = walletBalance - catPrice;

            return walletBalance;
        }



       

    }
}
