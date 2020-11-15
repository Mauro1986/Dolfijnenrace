using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        { 
            int keuzeS1;
            int keuzeS2;

            Dolfijn dolfijn1 = new Dolfijn();
            Dolfijn dolfijn2 = new Dolfijn();

            Console.WriteLine("Dolfijnenrace: de eerste dolfijn die 120 meter zwemt, wint.\n" +
            "Luchtvoorraad is nooit meer dan 60, een dolfijn zonder lucht gaat dood.\n" +
            "Zwemmen verbruikt 5 tot 35 luchteenheden.\n" +
            "Wanneer de dolfijn lucht hapt verhogen de luchteenheden met 15 tot 45.\n\n");
            Console.ReadKey();
          

            while (dolfijn1.Afstand < 200 || dolfijn2.Afstand < 200)
            {

                #region Dolfijn 1
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\nSpeler 1");
                Console.ResetColor();
                Console.WriteLine(", wat wilt u doen?\n" +
                  "1.     Mijn dolfijn laten zwemmen\n" +
                  "2.     Mijn dolfijn adem laten pakken\n\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Dolfijn 1:");
                Console.ResetColor();
                Console.WriteLine($"Luchtvoorraad 1: {dolfijn1.Luchtvoorraad}");
                Console.WriteLine($"Afstand 1: {dolfijn1.Afstand}");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Dolfijn 2:");
                Console.ResetColor();
                Console.WriteLine($"Luchtvoorraad: {dolfijn2.Luchtvoorraad}");
                Console.WriteLine($"Afstand: {dolfijn2.Afstand}");

                keuzeS1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (keuzeS1)
                {
                    case 1:
                        dolfijn1.Zwem();                       
                        break;
                    case 2:
                        dolfijn1.Paklucht();
                        break;
                }
                #endregion

                #region Dolfijn 2
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nSpeler 2");
                Console.ResetColor();
                Console.WriteLine(", wat wilt u doen?\n" +
                  "1.     Mijn dolfijn laten zwemmen\n" +
                  "2.     Mijn dolfijn adem laten pakken\n\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Dolfijn 1:");
                Console.ResetColor();
                Console.WriteLine($"Luchtvoorraad 1: {dolfijn1.Luchtvoorraad}");
                Console.WriteLine($"Afstand 1: {dolfijn1.Afstand}");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Dolfijn 2:");
                Console.ResetColor();
                Console.WriteLine($"Luchtvoorraad: {dolfijn2.Luchtvoorraad}");
                Console.WriteLine($"Afstand: {dolfijn2.Afstand}");

                keuzeS2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (keuzeS2)
                {
                    case 1:
                        dolfijn2.Zwem();
                        break;
                    case 2:
                        dolfijn2.Paklucht();
                        break;
                }
                #endregion


                if (dolfijn1.Afstand >= 200 && dolfijn2.Afstand < dolfijn1.Afstand)
                {
                    Console.WriteLine("Speler 1 wint, dolfijn 1 was als eerste over de finish");
                }
                else if (dolfijn2.Afstand >= 200 && dolfijn1.Afstand < dolfijn2.Afstand)
                {
                    Console.WriteLine("Speler 2 wint, dolfijn 2 was als eerste over de finish");
                }
                else if ((dolfijn2.Afstand >= 200) && (dolfijn1.Afstand >= 200))
                {
                    Console.WriteLine("Dolfijn 1 en dolfijn 2 zijn allebei gefinisht... iedereen wint");
                }

                if (dolfijn1.Luchtvoorraad < 1)
                {
                    Console.WriteLine("Speler 2 wint, dolfijn 1 is dood");
                }
                else if (dolfijn2.Luchtvoorraad < 1)
                {
                    Console.WriteLine("Speler 1 wint, dolfijn 2 is dood");
                }
                else if (dolfijn2.Luchtvoorraad < 1 && dolfijn1.Luchtvoorraad < 1)
                {
                    Console.WriteLine("Beide dolfijnen zijn dood... niemand wint");
                }

            }
            Console.ReadKey();

        }
    }
}



