using System;
using System.Collections.Generic;

namespace ConsoleApp2esson08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List <string> firstName = new List<string>();
            firstName.Add("sara");
            firstName.Add("anxh");

            Console.WriteLine($"list item 1 {firstName[0]}");
      
            firstName.Remove("sara");
            Console.WriteLine($"list item 1 {firstName[0]}");
            Console.ReadLine();
        }
    }
}
