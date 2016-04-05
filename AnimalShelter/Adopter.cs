using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Adopter
    {
        public double Wallet;
        public string nameAnimal;

        public Adopter()
        {

        }

        public void PurchaseAnimal()
        {
            //include remove animal (dog or cat) from animalList
        }


        public void AdoptAnimal()
        {
            Console.WriteLine("What type of animal would you like to adopt?");
            Console.WriteLine("1.Dog");
            Console.WriteLine("2.Cat");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                //insert adopt dog function that removes dog from List of dogs
            }
            else if (choice == 2)
            {
                //insert adopt cat function that removes cat from List of cats
            }
            else
            {
                Console.WriteLine("Sorry I don't recgnize that command. Please enter the numerical value associated with your decision.");
                AdoptAnimal();
            }

        }




        public string NameAnimal()
        {
            Console.WriteLine("What would you like to name your new pet?");
            nameAnimal = Console.ReadLine();
            Console.WriteLine(nameAnimal+" is now a part of your family. Congratulations!");
            Console.ReadKey();
            return nameAnimal;


        }

    }
}
