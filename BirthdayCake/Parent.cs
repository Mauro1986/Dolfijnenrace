using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayC
{
    class Parent
    {
        public void LightAllCandles(BirthdayCake birthdayCake)
        {
            //for (int i = 0; i < birthdayCake.NumberOfCandles; i++)    //in opgave spreekt men van een for loop?
            //{ }
                birthdayCake.NumberOfBurningCandles = birthdayCake.NumberOfCandles;          
        }
    }
}
