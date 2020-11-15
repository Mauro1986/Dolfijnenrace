using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{

    class Dolfijn
    {
        public int Afstand =0 ;
        public int Luchtvoorraad =35;
        public bool Dood;

        Random randomNumb = new Random();

    public void Zwem()
    {
            Random randomNumb = new Random();

            Afstand = Afstand + randomNumb.Next(10, 35);
        Luchtvoorraad = Luchtvoorraad - randomNumb.Next(5, 35);
           
    }
    public void Paklucht()
    {
            Random randomNumb = new Random();

           // Afstand = Afstand + randomNumb.Next(10, 35);
        Luchtvoorraad = Luchtvoorraad + randomNumb.Next(15, 45);
        if (Luchtvoorraad >= 60)
        {
            Luchtvoorraad = 60;
        }
    }
}
}
