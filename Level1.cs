using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string PatternUnlock(int N, int[] hits)
        {
            double length = 0;
            int count = 0;
            int[] coordinates = new int[hits.Length * 2];
            int[,] keyBoard = new int[3, 3]
           {
                { 6, 1, 9 },
                { 5, 2, 8 },
                { 4, 3, 7 }
           };

            coordinates = Level1.SearchKey(hits, keyBoard);

            for (int i = 0; i < N - 1; i++)
            {
                if (Math.Abs(coordinates[count] - coordinates[count + 2]) + Math.Abs(coordinates[count + 1] - coordinates[count + 3]) == 1)
                {
                    length += 1;
                }
                else if (Math.Abs(coordinates[count] - coordinates[count + 2]) + Math.Abs(coordinates[count + 1] - coordinates[count + 3]) == 2)
                {
                    length += Math.Sqrt(2);
                }
                else
                {
                    return null;
                }
                count += 2;
            }

            length = (int)(length * Math.Pow(10, 5));
            string str = Convert.ToString(length);
            string hack = str.Trim('0');

            return hack;
        }

        public static int[] SearchKey(int[] hit, int[,] keyBoard)
        {
            int[] coordinatesOfKeys = new int[hit.Length * 2];
            int count = 0;

            for (int i = 0; i < hit.Length; i++)
            {
                for (int j = 0; j < keyBoard.GetLength(0); j++)
                {
                    for (int k = 0; k < keyBoard.GetLength(1); k++)
                    {
                        if (hit[i] == keyBoard[j, k])
                        {
                            coordinatesOfKeys[count] = j;
                            coordinatesOfKeys[count + 1] = k;
                            count += 2;
                        }
                    }
                }
            }

            return coordinatesOfKeys;
        }
    }
}
