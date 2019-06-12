using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        static public int Unmanned(int L, int N, int[][] track)
        {
            int timeCounter = 0;
            int roadCounter = 0;

            while (roadCounter < L)
            {
                for (int j = 0; j < N; j++)
                {
                    if (roadCounter == track[j][0])
                    {
                        while (!IsGreen(timeCounter, track[j]))
                        {
                            timeCounter++;
                        }
                    }
                }
                timeCounter++;
                roadCounter++;
            }
            return timeCounter;
        }

        static public bool IsGreen(int timeCounter, int[] track)
        {
            bool light = false;
            int lightCounter = 0;

            if (timeCounter < track[1])
            {
                return false;
            }
            else
            {
                while (timeCounter > lightCounter)
                {
                    if (light)
                    {
                        for (int i = 0; i < track[2]; i++)
                        {
                            if (timeCounter > lightCounter)
                            {
                                lightCounter++;
                            }
                            else
                            {
                                return light;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < track[1]; i++)
                        {
                            if (timeCounter > lightCounter)
                            {
                                lightCounter++;
                            }
                            else
                            {
                                return light;
                            }
                        }
                    }
                    light = !light;
                }
            }
            return light;
        }
    }
}
