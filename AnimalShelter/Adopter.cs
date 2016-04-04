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
