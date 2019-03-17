using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
        {
            if (L >= 1)
            {
                bool[,] map = new bool[N, M];
                int day = 1;
                int count = 0;

                for (int i = 0; i < battalion.Length; i += 2)
                {
                    map[battalion[i], battalion[i + 1]] = true;
                }

                while (count != map.Length)
                {
                    bool flag = false;

                    for (int i = 0; i < map.GetLength(0) && flag == false; i++)
                    {
                        for (int j = 0; j < map.GetLength(1) && flag == false; j++)
                        {
                            if (map[i, j] == true)
                            {
                                count++;
                            }
                            else
                            {
                                map = _getCapturedField(map);
                                day++;
                                count = 0;
                                flag = true;
                            }
                        }
                    }
                }
                return day;
            }
            else
            {
                return 0;
            }
        }

        private static bool[,] _getCapturedField(bool[,] map)
        {
            bool[,] tempMap = new bool[map.GetLength(0), map.GetLength(1)];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    tempMap[i, j] = map[i, j];
                }
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == true)
                    {
                        if (i != 0 && i != map.GetLength(0) - 1 && j != 0 && j != map.GetLength(1) - 1)
                        {
                            tempMap[i, j + 1] = true;
                            tempMap[i, j - 1] = true;
                            tempMap[i + 1, j] = true;
                            tempMap[i - 1, j] = true;
                        }
                        else if (i == 0 && j != 0 && j != map.GetLength(1) - 1)
                        {
                            tempMap[i, j + 1] = true;
                            tempMap[i, j - 1] = true;
                            tempMap[i + 1, j] = true;
                        }
                        else if (i == map.GetLength(0) - 1 && j != 0 && j != map.GetLength(1) - 1)
                        {
                            tempMap[i, j + 1] = true;
                            tempMap[i, j - 1] = true;
                            tempMap[i - 1, j] = true;
                        }
                        else if (j == 0 && i != 0 && i != map.GetLength(0) - 1)
                        {
                            tempMap[i + 1, j] = true;
                            tempMap[i - 1, j] = true;
                            tempMap[i, j + 1] = true;
                        }
                        else if (j == map.GetLength(1) - 1 && i != 0 && i != map.GetLength(0) - 1)
                        {
                            tempMap[i + 1, j] = true;
                            tempMap[i - 1, j] = true;
                            tempMap[i, j - 1] = true;
                        }
                        else if (i == 0 && j == 0)
                        {
                            tempMap[i + 1, j] = true;
                            tempMap[i, j + 1] = true;
                        }
                        else if (i == 0 && j == map.GetLength(1) - 1)
                        {
                            tempMap[i + 1, j] = true;
                            tempMap[i, j - 1] = true;
                        }
                        else if (i == map.GetLength(0) - 1 && j == map.GetLength(1) - 1)
                        {
                            tempMap[i - 1, j] = true;
                            tempMap[i, j - 1] = true;
                        }
                        else if (i == map.GetLength(0) - 1 && j == 0)
                        {
                            tempMap[i - 1, j] = true;
                            tempMap[i, j + 1] = true;
                        }
                    }
                }
            }

            map = new bool[map.GetLength(0), map.GetLength(1)];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = tempMap[i, j];
                }
            }

            return map;
        }

    }
}
