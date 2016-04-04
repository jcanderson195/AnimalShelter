using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class SystemOperations
    {

        public SystemOperations()
        {

        }

        public void SystemFlow()
        {
            Console.WriteLine("Welcome DevCodeCamp Animal Shelter!");
            Console.WriteLine("----------------------");
            Console.WriteLine("Are you looking to adopt a pet?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2.No");

            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                //insert animal shelter function
            }
            else if (choice == 2)
            {
                

                Console.WriteLine("What are you here for then?");
                Console.WriteLine("1. View Animals");
                Console.WriteLine("2.Exit");
                Console.WriteLine("----------------------");

                int choice2;
                choice2 = Convert.ToInt32(Console.ReadLine());

                if (choice2 == 1)
                {
                    //display list of animals
                }
                else if (choice2 == 2)
                {
                    Console.WriteLine("Thank you for visiting DevCodeCamp Animal Shelter!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sorry I don't recgnize that command. Please enter the numerical value associated with your decision.");
                    SystemFlow();
                }
          
            }
            else
            {
                Console.WriteLine("Sorry I don't recgnize that command. Please enter the numerical value associated with your decision.");
                SystemFlow();
            }


        }

    }
}
