﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
   public class Cat : Animal
    {
        public string catName;
        public double catPrice;

        List<string> ListOfCats = new List<string>();

        List<bool> ShotsStatus = new List<bool>();

        public Cat()
        {
            ListOfCats.Add("Milo");
            ListOfCats.Add("Smoky");
            ListOfCats.Add("Rocky");
            ListOfCats.Add("Winter");

            ShotsStatus.Add(true);
            ShotsStatus.Add(true);
            ShotsStatus.Add(true);
            ShotsStatus.Add(true);

            catPrice = 150.00;

        }

        public void DisplayListOfCats()
        {
            Console.WriteLine("List of Cats");
            for (int index = 0; index < ListOfCats.Count; index++)
            {
                Console.WriteLine(ListOfCats[index]);
            }

        }

        public void DisplayShotStatusForCats()
        {
            Console.WriteLine("Shots Status For Cats");
            for (int index = 0; index < ShotsStatus.Count; index++)
            {
                Console.WriteLine(ShotsStatus[index]);
            }
        }


        public string DonateCat()
        {

            Console.WriteLine("What's the cat's name?");
            catName = Console.ReadLine();
            Console.WriteLine("Thank you for donating " + catName + " to the shelter.");

            ListOfCats.Add(catName);
            ShotsStatus.Add(false);
            Console.WriteLine("--------------------");
            DisplayListOfCats();
            Console.WriteLine("--------------------");
            DisplayShotStatusForCats();
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
            DisplayListOfCats();
            Console.WriteLine("--------------------");
            DisplayShotStatusForCats();
            Console.WriteLine("--------------------");

            Console.WriteLine("Please enter the name of which cat you would like to adopt. Name is case sensitive!");

            string choice = Console.ReadLine();

            if (choice == "Milo")
            {
                Console.WriteLine("Milo costs "+catPrice+" dollars. Are you buying Milo today?");
                Console.WriteLine("1.Yes");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    //insert function to subtract money from adopter wallet
                    //display function for adopter current wallet balance
                    ListOfCats.Remove("Milo");
                    ShotsStatus.Remove(true);
                    Console.WriteLine("Thank you for adopting Milo. I hope he brings you much enjoyment.");
                    Console.WriteLine("--------------------");
                    DisplayListOfCats();
                    Console.WriteLine("--------------------");
                    DisplayShotStatusForCats();
                    Console.WriteLine("--------------------");
                }
            }
            else if (choice == "Smoky")
            {
                Console.WriteLine("Smoky costs " + catPrice + " dollars. Are you buying Smoky today?");
                Console.WriteLine("1.Yes");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    //insert function to subtract money from adopter wallet
                    //display function for adopter current wallet balance
                    ListOfCats.Remove("Smoky");
                    ShotsStatus.Remove(true);
                    Console.WriteLine("Thank you for adopting Smoky. I hope he brings you much enjoyment.");
                    Console.WriteLine("--------------------");
                    DisplayListOfCats();
                    Console.WriteLine("--------------------");
                    DisplayShotStatusForCats();
                    Console.WriteLine("--------------------");
                }
            }
            else if (choice == "Rocky")
            {
                Console.WriteLine("Rocky costs " + catPrice + " dollars. Are you buying Rocky today?");
                Console.WriteLine("1.Yes");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    //insert function to subtract money from adopter wallet
                    //display function for adopter current wallet balance
                    ListOfCats.Remove("Rocky");
                    ShotsStatus.Remove(true);
                    Console.WriteLine("Thank you for adopting Rocky. I hope he brings you much enjoyment.");
                    Console.WriteLine("--------------------");
                    DisplayListOfCats();
                    Console.WriteLine("--------------------");
                    DisplayShotStatusForCats();
                    Console.WriteLine("--------------------");
                }
            }
            else if (choice == "Winter")
            {
                Console.WriteLine("Winter costs " + catPrice + " dollars. Are you buying Winter today?");
                Console.WriteLine("1.Yes");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    //insert function to subtract money from adopter wallet
                    //display function for adopter current wallet balance
                    ListOfCats.Remove("Winter");
                    ShotsStatus.Remove(true);
                    Console.WriteLine("Thank you for adopting Winter. I hope he brings you much enjoyment.");
                    Console.WriteLine("--------------------");
                    DisplayListOfCats();
                    Console.WriteLine("--------------------");
                    DisplayShotStatusForCats();
                    Console.WriteLine("--------------------");
                }
            }
            else if (choice == catName)
            {
                Console.WriteLine(catName + " costs " + catPrice + " dollars. Are you buying " + catName + " today?");
                Console.WriteLine("1.Yes");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    //insert function to subtract money from adopter wallet
                    //display function for adopter current wallet balance
                    Console.WriteLine("--------------------");
                    Console.WriteLine(catName + " does not have all of his/her shots. Would you like to give him/her their shots free of cost?");
                    Console.WriteLine("1.Yes");
                    int choice3 = Convert.ToInt32(Console.ReadLine());

                    if (choice3 == 1)
                    {
                        ShotsStatus.Remove(false);
                        Console.WriteLine("Applying shots..........");
                        Console.WriteLine("--------------------");
                        Console.WriteLine(catName + " is now up to date with his/her shots.");

                    }

                    ListOfCats.Remove(catName);
                    Console.WriteLine("--------------------");

                    Console.WriteLine("Thank you for adopting " + catName + ". I hope he/she brings you much enjoyment.");
                    Console.WriteLine("--------------------");

                    DisplayListOfCats();
                    Console.WriteLine("--------------------");
                    DisplayShotStatusForCats();
                    Console.WriteLine("--------------------");


                }
            }
            else
            {
                Console.WriteLine("I'm sorry that cat is not in the system. Please choose a cat thats in the List of Cats.");
            }

            return catName;
        }

    }
}
