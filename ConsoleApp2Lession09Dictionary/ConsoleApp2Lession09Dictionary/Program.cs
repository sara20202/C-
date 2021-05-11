using System;
using System.Collections.Generic;

namespace ConsoleApp2Lession09Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> importantYears = new Dictionary<int, string>();
            importantYears[2000] = "VITI 2000";
            importantYears[1996] = "SARA KA LINDUR";
            importantYears[1992] = "IMPORTANT YEAR FOR ROSE";

            Console.WriteLine($"VIT I RENDESISHEM: {importantYears[1992]}");
            Console.ReadLine();

        }
    }
}
