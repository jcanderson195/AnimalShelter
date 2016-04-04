using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class PetShelter
    {

        public PetShelter()
        {

        }

        public void PetChoice()
        {
            Console.WriteLine("What kind of animal would you like to purchase?");
            Console.WriteLine("1.Dog");
            Console.WriteLine("2.Cat");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                //insert display for dog cages list
            }
            else if (choice == 2)
            {
                //insert display for cat cages list
            }
            else
            {
                Console.WriteLine("Sorry I don't recgnize that command. Please enter the numerical value associated with your decision.");
                PetChoice();
            }
        }

    }
}
