using System;

namespace ConsoleApp2Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User");
            Console.WriteLine("Write a number from one to three");
            string numtext = Console.ReadLine();
            bool numIsValid = int.TryParse(numtext, out int num);
            string[] nome = new string[] { "sara", "anxh", "jula" };


            if (numIsValid == true)
            {
                if (num == 1)
                {
                    Console.WriteLine($"useri juaj eshte {nome[0]}");
                }
                else if (num == 2)
                {
                    Console.WriteLine($"useri juaj eshte {nome[1]}");
                }
                else if (num == 3)
                {
                    Console.WriteLine($"useri juaj eshte {nome[2]}");
                }

            }
            else
            {

                Console.WriteLine("put a valit number between 1 to 3");
            }

        }
    }
}
