using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static bool Football(int[] F, int N)
        {
            int[] correctRangeArray = new int[N];
            Array.Copy(F, correctRangeArray, N);
            Array.Sort(correctRangeArray);

            if (IsCorrectSwapNumbers(F, correctRangeArray))
            {
                return true;
            }
            else if (IsCorrectReverseArray(F, correctRangeArray))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsCorrectSwapNumbers(int[] F, int[] correctRangeArray)
        {
            for (int i = 0; i < F.Length - 1; i++)
            {
                for (int j = i + 1; j < F.Length; j++)
                {
                    int[] tempArray = new int[F.Length];
                    Array.Copy(F, tempArray, F.Length);
                    int temp = tempArray[i];
                    tempArray[i] = tempArray[j];
                    tempArray[j] = temp;

                    if (IsEqual(tempArray, correctRangeArray))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool IsEqual(int[] tempArray, int[] correctRangeArray)
        {
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i] == correctRangeArray[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsCorrectReverseArray(int[] F, int[] correctRangeArray)
        {
            int[] tempArray = new int[F.Length];
            Array.Copy(F, tempArray, F.Length);
            Array.Reverse(tempArray);

            if (IsEqual(tempArray, correctRangeArray))
            {
                return true;
            }
            return false;
        }
    }
}
