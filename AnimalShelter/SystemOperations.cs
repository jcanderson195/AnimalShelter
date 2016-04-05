using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class SystemOperations
    {
        Dog dog = new Dog();
        Cat cat = new Cat();
        public SystemOperations()
        {
           
        }



        public void Introduction()
        {
            Console.WriteLine("Welcome DevCodeCamp Animal Shelter!");
            Console.WriteLine("----------------------");
        }

        public void SystemFlow()
        {
            
            Console.WriteLine("Are you looking to adopt a pet or donate an animal?");
            Console.WriteLine("1. Adopt a pet");
            Console.WriteLine("2. Donate an animal");
            Console.WriteLine("3. Other");

            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            

            if (choice == 1)
            {
                Console.WriteLine("Are you adopting a dog or a cat?");
                Console.WriteLine("1. Dog");
                Console.WriteLine("2. Cat");

                int choice2 = Convert.ToInt32(Console.ReadLine());

                if (choice2 == 1)
                {

                    dog.AdoptDogOption();
                    SystemFlow();
                }
                else if (choice2 == 2)
                {
                    cat.AdoptCatOption();
                    SystemFlow();
                }
                else
                {
                    Console.WriteLine("Sorry I don't recognize that command. Please enter the numerical value associated with your decision.");
                    SystemFlow();
                }
            }
            else if(choice == 2)
            {
                Console.WriteLine("Are you donating a dog or a cat?");
                Console.WriteLine("1. Dog");
                Console.WriteLine("2. Cat");

                int choice2 = Convert.ToInt32(Console.ReadLine());
                
                if (choice2 == 1)
                {
                    
                    dog.DonateDogOption();
                    SystemFlow();
                }
                else if (choice2 == 2)
                {
                    cat.DonateCatOption();
                    SystemFlow();
                }
                else
                {
                    Console.WriteLine("Sorry I don't recognize that command. Please enter the numerical value associated with your decision.");
                    SystemFlow();
                }


            }
            else if (choice == 3)
            {
                

                Console.WriteLine("What are you here for then?");
                Console.WriteLine("1. View Animals");
                Console.WriteLine("2.Exit");
                Console.WriteLine("----------------------");

                int choice3;
                choice3 = Convert.ToInt32(Console.ReadLine());

                if (choice3 == 1)
                {
                    //display list of animals
                }
                else if (choice3 == 2)
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
