using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayC
{
   public class Program//niet zeker of public er bij moet en of dit mij constructor is? vermoedelijk wel
    {
        static void Main(string[] args)
        {
            BirthdayCake theCake = new BirthdayCake();
            Parent parentNew = new Parent();
            Kid kidNew = new Kid();

            Console.WriteLine("Hoe oud is het kind geworden: ");
            theCake.NumberOfCandles = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //Console.WriteLine("Ouders druk op enter om een kaars aan te steken");
            //theCake.LightCandle();

            Console.WriteLine($"Aantal kaarsen: {theCake.NumberOfCandles}");
            Console.WriteLine($"Aantal brandende kaarsen: {theCake.NumberOfBurningCandles}");

            Console.WriteLine("Ouders druk op enter om alle kaarsen aan te steken!");
            Console.ReadKey();
            parentNew.LightAllCandles(theCake);
            Console.Clear();

            Console.WriteLine($"Aantal kaarsen: {theCake.NumberOfCandles}");
            Console.WriteLine($"Aantal brandende kaarsen: {theCake.NumberOfBurningCandles}");

            Console.WriteLine("Kido druk op enter om alle kaarsen uit te blazen!");
            Console.ReadKey();
            kidNew.BlowOutAllCandles(theCake);
            Console.Clear();

            Console.WriteLine($"Aantal kaarsen: {theCake.NumberOfCandles}");
            Console.WriteLine($"Aantal brandende kaarsen: {theCake.NumberOfBurningCandles}");

        }
    }
}
