using System;

namespace Cafemoenen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom bij cafe moenen.");
            Console.WriteLine("Opties:");
            Console.WriteLine("1. Maak een Reservatie");
            Console.WriteLine("2. Zie alle reservaties");
            Console.WriteLine("Druk x om te stoppen");

            var userInput = Console.ReadLine();

            var reserveerboek = new Reserveerboek();

            while(true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Groep naam:");
                        var groepnaam = Console.ReadLine();
                        Console.WriteLine("Contact nummer:");
                        var telefoonnummer = Console.ReadLine();
                        Console.WriteLine("Aantaal personen:");
                        var aantalpersonen = Console.ReadLine();
                        Console.WriteLine("Binnen of Buiten:");
                        var binnen = Console.ReadLine();



                        var newReservatie = new Restaurant(groepnaam, telefoonnummer, aantalpersonen, binnen);
                        reserveerboek.AddReservatie(newReservatie);
                        break;
                    case "2":
                        reserveerboek.DisplayAllReservaties();
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Selecteer een optie.");
                        break;
                }
                Console.WriteLine("Selecteer een operatie");
                userInput = Console.ReadLine();
            }
        }
    }
}
