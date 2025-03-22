using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Power
    {
        public static int CalPower(int Number, int Power)
        {
            //Time complexity is N
            if(Power == 1)
                return Number;

            int previousPower = CalPower(Number, Power - 1);
            return previousPower * Number;
        }

        public static int CalPowerOptimized(int Number, int Power)
        {
            //Time complexity is logN
            if (Power == 1)
                return Number;

            int previousPower = CalPowerOptimized(Number, Power / 2);
            if (Power % 2 == 0)
                return previousPower * previousPower;
            else
                return previousPower * previousPower * Number;
        }


    }
}
