using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ShoppingAdventure
{
    class Program
    {



        public static decimal SetUserBudget()
        {


            Console.WriteLine("Hello user!, I am the Digitalized Shopping Service, or DSS for short. To start things off, please give Me Your Budget for the week.");
            var monies = Console.ReadLine();
            decimal moniesconverted = Decimal.Parse(monies);

            Console.WriteLine($"Ok, so We are working with a total of ${moniesconverted} dollars today, alright, let's head to to the store!");
            bool wantstoshop = true;

            if (moniesconverted > 0)
            {
                wantstoshop = true;
                Console.WriteLine("Alrighty!, Let's set everything up!");
                WhichDepartment();
            }

            else
            {
                Console.WriteLine("Oh... I see, well if You have no money to begin with, why even consider the thought?");
                wantstoshop = false;
                Console.ReadKey();
            }
            return moniesconverted;


        }

        public static void WhichDepartment()
        {

            bool saidyes = true;
            Console.WriteLine("Hello again! Here's a List of the departments in this store. ");

            IDictionary<int, string> departmentlist = new Dictionary<int, string>();
            departmentlist.Add(0, "Deli Department");
            departmentlist.Add(1, "Butcher Department");
            departmentlist.Add(2, "Bakery Department");

            Console.WriteLine("Here is a list of all the different Departments this store has:");

            foreach (KeyValuePair<int, string> depart in departmentlist)
            {
                Console.WriteLine($"Ok, so This store has a {depart.Value}");
            }


            Console.WriteLine("Are You ready to shop?");
            string reply = Console.ReadLine().ToLower();

            switch (reply)
            {
                case "yes":
                    Console.WriteLine("Excellent! Onwards!");
                    break;

                case "no":
                    Console.WriteLine("I see, well, thanks for wasting My time. :/");
                    saidyes = false;
                    break;
            }

            Console.WriteLine("Ok, so which department would You like to go to?\n Just type in the Type of Department and the 'Department' word.");

            string desireddepartment = Console.ReadLine().ToLower();


            switch (desireddepartment)
            {
                case "bakery department":
                    Console.WriteLine("OH, so You want to shop for some bread huh? ok, hold up.");
                    break;
                default:
                    Console.WriteLine("That is not a valid department. Terminating.");
                    break;

            }


            List<string> BakeryItems = new List<string>();
            BakeryItems.Add("French Bread Loaf");
            BakeryItems.Add("Kaiser Bread Loaf");




            List<double> Bakeryitemprices = new List<double>();
            Bakeryitemprices.Add(2.56);
            Bakeryitemprices.Add(1.89);

            foreach(string bakeryitem in BakeryItems)
                {


                foreach (int pricetag in Bakeryitemprices)
                {

                    Console.Write($"{bakeryitem}  {pricetag} ");
                }
            }

        }


    



        
        static void Main(string[] args)
        {
            SetUserBudget();
        }
    }
}
