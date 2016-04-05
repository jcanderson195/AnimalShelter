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

        List<string> ListOfDogs = new List<string>();
        


        public Dog()
        {
            ListOfDogs.Add("Charlie");
            ListOfDogs.Add("Spike");
            ListOfDogs.Add("Brian");
            ListOfDogs.Add("Blizzard");
            

        }

        public void DisplayListOfDogs()
        {
            Console.WriteLine("List of Dogs");
            for (int index = 0; index < ListOfDogs.Count; index++)
            {
                Console.WriteLine(ListOfDogs[index]);
            }
            
        }


        public string DonateDog()
        {
            
            Console.WriteLine("What's the dog's name?");
             dogName = Console.ReadLine();
            Console.WriteLine("Thank you for donating " + dogName + " to the shelter.");

            ListOfDogs.Add(dogName);
            Console.WriteLine("--------------------");
            DisplayListOfDogs();
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
            DisplayListOfDogs();
            Console.WriteLine("--------------------");

            Console.WriteLine("Please enter the name which dog you would like to adopt. Name is case sensitive!");

            string choice = Console.ReadLine();

            if (choice == "Charlie")
            {
                ListOfDogs.Remove("Charlie");
                Console.WriteLine("Thank you for adopting Charlie. I hope he brings you much enjoyment.");
                Console.WriteLine("--------------------");

                DisplayListOfDogs();
                Console.WriteLine("--------------------");

            }
            else if (choice == "Spike")
            {
                ListOfDogs.Remove("Spike");
                Console.WriteLine("Thank you for adopting Spike. I hope he brings you much enjoyment.");
                Console.WriteLine("--------------------");

                DisplayListOfDogs();
                Console.WriteLine("--------------------");
            }
            else if(choice == "Brian")
            {
                ListOfDogs.Remove("Brian");
                Console.WriteLine("Thank you for adopting Brian. I hope he brings you much enjoyment.");
                Console.WriteLine("--------------------");

                DisplayListOfDogs();
                Console.WriteLine("--------------------");
            }
            else if (choice == "Blizzard")
            {
                ListOfDogs.Remove("Blizzard");
                Console.WriteLine("Thank you for adopting Blizzard. I hope he brings you much enjoyment.");
                Console.WriteLine("--------------------");

                DisplayListOfDogs();
                Console.WriteLine("--------------------");
            }
            else if (choice == dogName)
            {
                ListOfDogs.Remove(dogName);
                Console.WriteLine("Thank you for adopting "+dogName+" . I hope he brings you much enjoyment.");
                Console.WriteLine("--------------------");

                DisplayListOfDogs();
                Console.WriteLine("--------------------");
            }
            else
            {
                Console.WriteLine("I'm sorry that dog is not in the system. Please choose a dog thats in the List of Dogs.");
            }

            return dogName;
        }
    }

            
        }

    


