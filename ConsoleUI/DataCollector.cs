using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using GuestBookLibrary.Models;

namespace ConsoleUI
{
    public class DataCollector
    {
        public static void GuestDetails(List<GuestModel> guests, string endRSVP)
        {

            do
            {
                GuestModel guest = new GuestModel();


                guest.FirstName = GetInfoFromConsole("What is your first name? ");
                guest.LastName = GetInfoFromConsole("What is your last name? ");
                guest.MessageToHost = GetInfoFromConsole("What is your message to the host? ");
                endRSVP = GetInfoFromConsole("Would you like to add another RSVP for the party? (yes/no) ");
                
                guests.Add(guest);

                Console.Clear();


            } while (endRSVP.ToLower() != "no");
        }

        public static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}
