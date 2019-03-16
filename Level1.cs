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
                int speed = 0;
                int time = 0;

                for (int i = 0; i < oksana.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        speed = oksana[i];
                    }
                    else
                    {
                        if (i != 1)
                        {
                            time = oksana[i] - oksana[i - 2];
                            distance += speed * time;
                        }
                        else
                        {
                            time = oksana[i] - time;
                            distance += speed * time;
                        }
                    }
                }
                return distance;
            }
        }
    }
}
