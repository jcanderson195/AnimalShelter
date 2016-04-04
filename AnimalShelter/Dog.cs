using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
   public class Dog : Animal
    {
        

        List<string> ListOfDogs = new List<string>();
        


        public Dog()
        {
            
            
        }

        public void DisplayListOfDogs()
        {
            
            for (int index = 0; index < ListOfDogs.Count; index++)
            {
                Console.WriteLine(ListOfDogs[index]);
            }
            
        }

        public string DonateDog()
        {
            Console.WriteLine("What's the dog's name?");
            string dogName = Console.ReadLine();
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

            
        }

    }


