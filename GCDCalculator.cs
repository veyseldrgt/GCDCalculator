using System;

namespace GCDLib
{
    public class GCDCalculator
    {
        // Method using subtraction
        public static int GCD_subtraction(int a, int b)
        {
            while (b != 0)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        // Method using modulo division
        public static int GCD_modulo(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
