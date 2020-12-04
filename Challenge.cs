using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenger_11_12_2020
{
    [TestClass]
    public class Challenge
    {
        [TestMethod]
        public void NameAge()
        {
            int age = 33;
            string firstName = "Jon";
            string lastName = "Kinne";
            Console.WriteLine(firstName + " " + lastName + " " + age);
        }

        [TestMethod]
        public void Arrays()
        {
            string[] books = { "Farenheight 451", "Animal Farm", "1984", "A Brave New World" };
            Console.WriteLine(books);

            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void Dates()
        { 
            DateTime birthday = new DateTime(1987, 3, 20);
            DateTime now = DateTime.Now;
            List<DateTime> listOfDateTime = new List<DateTime>();
            listOfDateTime.Add(birthday);
            listOfDateTime.Add(now);

            foreach (var item in listOfDateTime)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void Calculations()
        {
            int age = 33;
            int sum = age + 7;
            int sub = age - 7;
            int mult = age * 7;
            int div = age / 7;
            int rem = age % 7;
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            Console.WriteLine(rem);
        }

        [TestMethod]
        public void Conditional()
        {
            int sleep = -1;
            if (sleep >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (sleep >= 8 && sleep < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (sleep >= 4 && sleep < 8)
            {
                Console.WriteLine("Bummer");
            }
            else if (sleep >= 0 && sleep < 4)
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }

        [TestMethod]
        public void Switch()
        {
            string mood = "Bad";
            switch (mood)
            {
                case "Great":
                    Console.WriteLine("That is Awesome to hear!"); 
                    break;
                case "Good":
                    Console.WriteLine("What was so good about it?");
                    break;
                case "Okay":
                    Console.WriteLine("At least nothing bad happened");
                    break;
                case "Bad":
                    Console.WriteLine("Things can only get better");
                    break;
            }
        }
    }

  
}
