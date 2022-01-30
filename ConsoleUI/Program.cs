// capture the information about each guest
// info to capture: First Name, Last Name, Message to Host
// Once done, loop through each guest and print their info

using System.Diagnostics.CodeAnalysis;
using ConsoleUI;
using GuestBookLibrary;
using GuestBookLibrary.Models;

List<GuestModel> guests = new List<GuestModel>();

string endRSVP = null;

DataCollector.GuestDetails(guests, endRSVP);

ProcessGuests.iterateGuests(guests);




