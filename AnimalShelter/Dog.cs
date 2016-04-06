using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
   public class Dog : Animal
    {
        public string dogName;
        public double dogPrice;

        List<string> ListOfDogs = new List<string>();

        
        
        List<bool> ShotsStatus = new List<bool>();

        Adopter newAdopter = new Adopter();

        public Dog()
        {
            ListOfDogs.Add("Charlie");
            ListOfDogs.Add("Spike");
            ListOfDogs.Add("Brian");
            ListOfDogs.Add("Blizzard");


            ShotsStatus.Add(true);
            ShotsStatus.Add(true);
            ShotsStatus.Add(true);
            ShotsStatus.Add(true);

            dogPrice = 200.00;

        }

        public void DisplayListOfDogs()
        {
            Console.WriteLine("List of Dogs");
            for (int index = 0; index < ListOfDogs.Count; index++)
            {
                Console.WriteLine(ListOfDogs[index]);
            }

            
        }

        public void DisplayShotStatusForDogs()
        {
            Console.WriteLine("Shots Status For Dogs");
            for (int index = 0; index < ShotsStatus.Count; index++)
            {
                Console.WriteLine(ShotsStatus[index]);
            }

        }

        public string DonateDog()
        {

            Console.WriteLine("What's the dog's name?");
            dogName = Console.ReadLine();
            Console.WriteLine("Thank you for donating " + dogName + " to the shelter.");

            ListOfDogs.Add(dogName);
            ShotsStatus.Add(false);
            Console.WriteLine("--------------------");
            DisplayListOfDogs();
            Console.WriteLine("--------------------");
            DisplayShotStatusForDogs();
            Console.WriteLine("--------------------");


            return dogName;
        }

        public void DonateDogOption()
        {
            Console.WriteLine("Are you donating a dog?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {

                DonateDog();

            }

            else if (choice == 2)
            {
                Console.WriteLine("Thank you for visiting DevCodeCamp Animal Shelter!");
                Environment.Exit(0);
                Console.ReadKey();
            }
        }

        public void AdoptDogOption()
        {
            
            Console.WriteLine("Are you adopting a dog?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {

                AdoptDog();

            }

            else if (choice == 2)
            {
                Console.WriteLine("Thank you for visiting DevCodeCamp Animal Shelter!");
                Environment.Exit(0);
                Console.ReadKey();
            }
        }

        public string AdoptDog()
        {
            newAdopter.AdopterProfile();
            newAdopter.AdopterBudget();
            Console.WriteLine("--------------------");
            DisplayListOfDogs();
            Console.WriteLine("--------------------");
            DisplayShotStatusForDogs();
            Console.WriteLine("--------------------");

            Console.WriteLine("Please enter the name of which dog you would like to adopt. Name is case sensitive!");

            string choice = Console.ReadLine();

            if (choice == "Charlie")
            {
                Console.WriteLine("Charlie costs " + dogPrice + " dollars. Are you buying Charlie today?");
                Console.WriteLine("1.Yes");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    newAdopter.PurchaseDog();
                    newAdopter.WalletBalanceTracker();
                    ListOfDogs.Remove("Charlie");
                    ShotsStatus.Remove(true);
                    Console.WriteLine("Thank you for adopting Charlie. I hope he brings you much enjoyment.");
                    Console.WriteLine("--------------------");
                    DisplayListOfDogs();
                    Console.WriteLine("--------------------");
                    DisplayShotStatusForDogs();
                    Console.WriteLine("--------------------");
                }

            }
            else if (choice == "Spike")
            {
                Console.WriteLine("Spike costs " + dogPrice + " dollars. Are you buying Spike today?");
                Console.WriteLine("1.Yes");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    newAdopter.PurchaseDog();
                    newAdopter.WalletBalanceTracker();
                    ListOfDogs.Remove("Spike");
                    ShotsStatus.Remove(true);
                    Console.WriteLine("Thank you for adopting Spike. I hope he brings you much enjoyment.");
                    Console.WriteLine("--------------------");
                    DisplayListOfDogs();
                    Console.WriteLine("--------------------");
                    DisplayShotStatusForDogs();
                    Console.WriteLine("--------------------");
                }

            }
            else if (choice == "Brian")
            {
                Console.WriteLine("Brian costs " + dogPrice + " dollars. Are you buying Brian today?");
                Console.WriteLine("1.Yes");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    newAdopter.PurchaseDog();
                    newAdopter.WalletBalanceTracker();
                    ListOfDogs.Remove("Brian");
                    ShotsStatus.Remove(true);
                    Console.WriteLine("Thank you for adopting Brian. I hope he brings you much enjoyment.");
                    Console.WriteLine("--------------------");
                    DisplayListOfDogs();
                    Console.WriteLine("--------------------");
                    DisplayShotStatusForDogs();
                    Console.WriteLine("--------------------");
                }

            }
            else if (choice == "Blizzard")
            {
                Console.WriteLine("Blizzard costs " + dogPrice + " dollars. Are you buying Blizzard today?");
                Console.WriteLine("1.Yes");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    newAdopter.PurchaseDog();
                    newAdopter.WalletBalanceTracker();
                    ListOfDogs.Remove("Blizzard");
                    ShotsStatus.Remove(true);
                    Console.WriteLine("Thank you for adopting Blizzard. I hope he brings you much enjoyment.");
                    Console.WriteLine("--------------------");
                    DisplayListOfDogs();
                    Console.WriteLine("--------------------");
                    DisplayShotStatusForDogs();
                    Console.WriteLine("--------------------");
                }

            }
            else if (choice == dogName)
            {
                Console.WriteLine(dogName+" costs "+dogPrice+" dollars. Are you buying "+dogName+" today?");
                Console.WriteLine("1.Yes");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                    if (choice2 == 1)
                    {
                    newAdopter.PurchaseDog();
                    newAdopter.WalletBalanceTracker();
                    Console.WriteLine("--------------------");
                Console.WriteLine(dogName+" does not have all of his/her shots. Would you like to give him/her their shots free of cost?");
                Console.WriteLine("1.Yes");
                int choice3 = Convert.ToInt32(Console.ReadLine());

                    if (choice3 == 1)
                    {
                    ShotsStatus.Remove(false);
                    Console.WriteLine("Applying shots..........");
                    Console.WriteLine("--------------------");
                    Console.WriteLine(dogName+" is now up to date with his/her shots.");

                    }

                ListOfDogs.Remove(dogName);
                Console.WriteLine("--------------------");

                Console.WriteLine("Thank you for adopting " + dogName + ". I hope he/she brings you much enjoyment.");
                Console.WriteLine("--------------------");

                DisplayListOfDogs();
                Console.WriteLine("--------------------");
                DisplayShotStatusForDogs();
                Console.WriteLine("--------------------");


                }


            }
            else
            {
                Console.WriteLine("I'm sorry that dog is not in the system. Please choose a dog thats in the List of Dogs.");
            }

            return dogName;
        }
    }
}

            
        

    


