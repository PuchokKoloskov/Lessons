using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int squirrel(int N)
        {
            decimal factorial = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
            }

            decimal firstNumber = factorial;

            while (firstNumber > 10)
            {
                firstNumber /= 10;
            }

            return (int)firstNumber;
        }
    }
}
