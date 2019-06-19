using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        static public int MaximumDiscount(int N, int[] price)
        {
            int sum = 0;

            for (int i = N; i >= 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (price[j] < price[j + 1])
                    {
                        int tempInt = price[j];
                        price[j] = price[j + 1];
                        price[j + 1] = tempInt;
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                if ((i + 1) % 3 == 0)
                {
                    sum += price[i];
                }
            }

            return sum;
        }
    }
}
