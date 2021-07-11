using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cafemoenen
{
    class Reserveerboek
    {
        private List<Restaurant> _restaurants { get; set; } = new List<Restaurant>();

        private void DisplayReservatieDetails(Restaurant restaurant)
        {
            Console.WriteLine($"Reservatie: {restaurant.GroepNaam}, {restaurant.TelefoonNummer}, {restaurant.AantalPersonen}, {restaurant.Binnen}");
        }

      public void AddReservatie(Restaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void DisplayReservatie(string GroepNaam)
        {
            var restaurant = _restaurants.FirstOrDefault(c => c.GroepNaam == GroepNaam);
            if (restaurant == null)
            {
                Console.WriteLine("Reservatie niet gevonden");
            } 
            else
            {
                DisplayReservatieDetails(restaurant);
            }
        }
        public void DisplayAllReservaties()
        {
            foreach (var restaurant in _restaurants)
            {
                DisplayReservatieDetails(restaurant);
            }
        }
    }
}
