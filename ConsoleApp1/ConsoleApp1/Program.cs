using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*firstname = "";
             firstname = @"C:\Temp\Temp.txt";*/
           int firstname = 0 ;
            int lastname = 0; 
           int fullname = 0;
            firstname = 2;
            lastname = 6;
            fullname = $" { firstname} {lastname }";

            Console.WriteLine(fullname);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
} 
