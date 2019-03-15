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
                int tempSpeed = 0;
                int tempTime = 0;
                int distance = 0;

                for (int i = 0; i < oksana.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        tempSpeed = oksana[i];
                    }
                    else
                    {
                        tempTime = oksana[i];
                        distance += tempSpeed * tempTime;
                    }
                }
                return distance;
            }
        }
    }
}
