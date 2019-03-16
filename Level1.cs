using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int odometer(int[] oksana)
        {
            if (oksana.Length < 2)
            {
                return oksana[0];
            }
            else
            {
                int distance = 0;

                for (int i = 0; i < oksana.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        distance += oksana[i];
                    }
                }
                return distance;
            }
        }
    }
}
