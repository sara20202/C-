using System;
using System.Collections.Generic;
//Ask for the users name
//Add the name to the list of names
//Ask for the user's party count
//Add the party count to total party number
//Print all names
//Print out total party number

namespace ConsoleUI
{
    class Program
    {
        private static List<string> parties = new List<string>();
       private static string moreguestscoming = "";
        private static int totalGuest = 0;
        static void Main(string[] args)
        {

            LoadGuests();
            DisplayGuests();
            DisplayGuestCount();
         
            Console.ReadLine();
                 
        }
        private static void DisplayGuestCount()
        {
            Console.WriteLine();
            Console.WriteLine($"Total Guests{totalGuest}");
        }
        private static void DisplayGuests()
        {

            Console.WriteLine();
            Console.WriteLine("Guest Parties at event:");
            foreach (string name in parties)
            {
                Console.WriteLine(name);
            }
        }
        private static string GetInfoFromConsole(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }
        private static int GetPartySize()
        {
            bool isValidNumber = false;
            int output = 0;
            do
            {
                string partySizeText = GetInfoFromConsole("How many people are in your party:");
                isValidNumber = int.TryParse(partySizeText, out output);
            }
            while (isValidNumber == false);
            return output;
        }
        private static void LoadGuests()
        {
            
            do
            {
               
                string partyName = GetInfoFromConsole("What is your party/group name: ");
                parties.Add(partyName);
                totalGuest += GetPartySize();
                Console.WriteLine("Do you want to add another guest (yes/no)");
                moreguestscoming = GetInfoFromConsole("Do you want to add another guest (yes/no)");
            }
            while (moreguestscoming.ToLower() == "yes");
        }
    }
}
