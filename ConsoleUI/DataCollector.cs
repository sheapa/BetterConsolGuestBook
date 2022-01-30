using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                

                Console.Write("What is your first name? ");
                string userInput = Console.ReadLine();
                guest.FirstName = userInput;


                Console.Write("What is your last name? ");
                userInput = Console.ReadLine();
                guest.LastName = userInput;


                Console.Write("What is your message to the host? ");
                userInput = Console.ReadLine();
                guest.MessageToHost = userInput;

                Console.Write("Would you like to add another RSVP for the party? (yes/no) ");
                endRSVP = Console.ReadLine();

                guests.Add(guest);

                Console.Clear();


            } while (endRSVP.ToLower() != "no");
        }
    }
}
