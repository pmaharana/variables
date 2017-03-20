using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassign1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string helloWorld = "Hello World!";
            

            int helloNumber = 1492;

           //Console.WriteLine("Do you have a dog at home?");
           //string dogAnswer = Console.ReadLine();

            DateTime today = DateTime.Now;
            string todayDate = today.ToShortDateString();

            double myDouble = 5.45;

            char letterX = 'X';

            // Practice problems

            //1

            Console.WriteLine(helloWorld);
            Console.ReadLine();

            //2

            string columbus = $"Columbus sailed the ocean blue in {helloNumber}";
            Console.WriteLine(columbus);
            Console.ReadLine();

            //3

            bool dogQuestion = true;
            Console.WriteLine($"It is {dogQuestion} that I have a dog at home");
            Console.ReadLine();

            //4

            Console.WriteLine("Today's date is " + todayDate);
            Console.ReadLine();

            //5

            Console.WriteLine($"I spent {myDouble:C} on a cheeseburger");
            Console.ReadLine();

            //6

            Console.WriteLine($"{letterX} marks the spot");
            Console.ReadLine();
            

            //Level 2 homie

            Console.WriteLine("Hello miss, may I get a random 7-digit number?");
            int phoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Is " + phoneNumber + " your real number, miss?");
            Console.ReadLine();
            */

            //level 3 homie

            Console.WriteLine("I am the great Manfred. Pick a number, any number");
            string userInput = Console.ReadLine();
            double value = 0;
            bool actualNumber = Double.TryParse(userInput, out value);
            if (actualNumber) {
                Console.WriteLine($"The number you picked is { value}");
            }
            else
            {
                while (actualNumber == false)
                {
                    Console.WriteLine("You didn't pick a number, please pick another");
                    string userInput1 = Console.ReadLine();
                    double value1 = 0;
                    bool actualNumber1 = Double.TryParse(userInput1, out value1);
                    if (actualNumber1)
                    {
                        Console.WriteLine($"Alright dude, you finally picked {value1}");
                        actualNumber = true;
                    }
                }
                
            }







        }
    }
}
