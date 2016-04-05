using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Cat : Animal
    {

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

            for (int index = 0; index < ListOfCats.Count; index++)
            {
                Console.WriteLine(ListOfCats[index]);
            }

        }

        public string DonateCat()
        {

            Console.WriteLine("What's the cat's name?");
            string catName = Console.ReadLine();
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
    }
}
