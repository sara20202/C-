using System;

namespace ConsoleApp2syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your age: ");
            //string ageText = Console.ReadLine();

            //bool isValidAge = int.TryParse(ageText, out int age); //KTHEN STRINGU NE INT
            //if (isValidAge == true)
            //{
            //    age += 10;
            //    Console.WriteLine($"YOU ARE GOING TO BE {age} years old after 10 years");

            //}
            //else
            //{
            //    Console.WriteLine("THAT IS NOT A VALID AGE");
            //}
            Console.WriteLine("What is your age: ");
            string ageText = Console.ReadLine();
            bool isValidAge = int.TryParse(ageText, out int age);
            if (isValidAge == true)
            {
                age -= 21;
                if(age > 0)
                {
                    Console.WriteLine($"You have been {age} years old in 2000");
                }
               else
                {
                    Console.WriteLine("You havent born yet");
                }
            }
        }
    }
}
