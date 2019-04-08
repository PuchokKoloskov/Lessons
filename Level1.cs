using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int SumOfThe(int N, int[] data)
        {
            if (N < 2)
            {
                return data[0];
            }

            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum += data[i];
            }

            return sum / 2;
        }
    }
}
