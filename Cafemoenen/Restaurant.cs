using System;
using System.Collections.Generic;
using System.Text;

namespace Cafemoenen
{
    class Restaurant
    {
        public Restaurant(string GroepNaam, string AantalPersonen, string Binnen, string TelefoonNummer)
        {
            this.GroepNaam = GroepNaam;
            this.Binnen = Binnen;
            this.AantalPersonen = AantalPersonen;
            this.TelefoonNummer = TelefoonNummer;
        }
        public string GroepNaam { get; set; }
        public string Binnen { get; set; }
        public string AantalPersonen { get; set; }
        public string TelefoonNummer { get; set; }
    }

}
