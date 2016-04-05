using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
   public class Cat : Animal
    {
        public string catName;

        List<string> ListOfCats = new List<string>();

        public Cat()
        {
            ListOfCats.Add("Milo");
            ListOfCats.Add("Smoky");
            ListOfCats.Add("Rocky");
            ListOfCats.Add("Winter");
        }

        public void DisplayListOfCats()
        {
            Console.WriteLine("List of Cats");
            for (int index = 0; index < ListOfCats.Count; index++)
            {
                Console.WriteLine(ListOfCats[index]);
            }

        }

        public string DonateCat()
        {

            Console.WriteLine("What's the cat's name?");
            catName = Console.ReadLine();
            Console.WriteLine("Thank you for donating " + catName + " to the shelter.");

            ListOfCats.Add(catName);
            Console.WriteLine("--------------------");
            DisplayListOfCats();
            Console.WriteLine("--------------------");


            return catName;
        }

        public void DonateCatOption()
        {
            Console.WriteLine("Are you donating a cat?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {

                DonateCat();

            }

            else if (choice == 2)
            {
                Console.WriteLine("Thank you for visiting DevCodeCamp Animal Shelter!");
                Environment.Exit(0);
                Console.ReadKey();
            }
        }

        public void AdoptCatOption()
        {
            Console.WriteLine("Are you adopting a cat?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {

                AdoptCat();

            }

            else if (choice == 2)
            {
                Console.WriteLine("Thank you for visiting DevCodeCamp Animal Shelter!");
                Environment.Exit(0);
                Console.ReadKey();
            }
        }

        public string AdoptCat()
        {
            Console.WriteLine("--------------------");
            DisplayListOfCats();
            Console.WriteLine("--------------------");

            Console.WriteLine("Please enter the name which cat you would like to adopt. Name is case sensitive! ");

            string choice = Console.ReadLine();

            if (choice == "Milo")
            {
                ListOfCats.Remove("Milo");
                Console.WriteLine("Thank you for adopting Milo. I hope he brings you much enjoyment.");
                Console.WriteLine("--------------------");

                DisplayListOfCats();
                Console.WriteLine("--------------------");

            }
            else if (choice == "Smoky")
            {
                ListOfCats.Remove("Smoky");
                Console.WriteLine("Thank you for adopting Smoky. I hope he brings you much enjoyment.");
                Console.WriteLine("--------------------");

                DisplayListOfCats();
                Console.WriteLine("--------------------");
            }
            else if (choice == "Rocky")
            {
                ListOfCats.Remove("Rocky");
                Console.WriteLine("Thank you for adopting Rocky. I hope he brings you much enjoyment.");
                Console.WriteLine("--------------------");

                DisplayListOfCats();
                Console.WriteLine("--------------------");
            }
            else if (choice == "Winter")
            {
                ListOfCats.Remove("Winter");
                Console.WriteLine("Thank you for adopting Winter. I hope he brings you much enjoyment.");
                Console.WriteLine("--------------------");

                DisplayListOfCats();
                Console.WriteLine("--------------------");
            }
            else if (choice == catName)
            {
                ListOfCats.Remove(catName);
                Console.WriteLine("Thank you for adopting " + catName + " . I hope he brings you much enjoyment.");
                Console.WriteLine("--------------------");

                DisplayListOfCats();
                Console.WriteLine("--------------------");
            }
            else
            {
                Console.WriteLine("I'm sorry that dog is not in the system. Please choose a dog thats in the List of Dogs.");
            }

            return catName;
        }

    }
}
