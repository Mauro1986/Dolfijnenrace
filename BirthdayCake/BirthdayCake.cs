using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayC
{
    class BirthdayCake
    {
        public int NumberOfCandles;
        public int NumberOfBurningCandles;

        //public void Birthdaycake()      //niet zeker van cake met kleine C 
        //{
        // voorlopig ongebruikt :-)
        //}
        //public void Birthdaycake(int lightCandle) // ""
        //{
        // voorlopig ongebruikt :-)
        //}
        public void LightCandle()
        {
            NumberOfBurningCandles = NumberOfBurningCandles + 1;
        }
        public void BlowOutCandle()
        {
            NumberOfBurningCandles = NumberOfBurningCandles - 1;
        }
        //public void GetNumberOfCandles(int numberOfCandles, int numberOfBuringCandles)
        //{
        // voorlopig ongebruikt :-)
        //}
        //public void GetNumberOfBurningCandles(int numberOfCandles, int numberOfBuringCandles)
        //{
        // voorlopig ongebruikt :-)
        //}
    }
}
