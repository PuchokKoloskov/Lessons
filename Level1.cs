using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static bool TransformTransform(int[] A, int N)
        {
            List<int> listA = new List<int>();
            List<int> B = new List<int>();
            List<int> S = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                listA.Add(A[i]);
            }

            SpinMainCycle(listA, B, listA.Count);
            SpinMainCycle(B, S, B.Count);

            return IsEven(S);
        }

        public static void SpinMainCycle(List<int> listA, List<int> B, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                {
                    int k = i + j;
                    int max = GetMaxVal(listA, k, j);
                    B.Add(max);
                }
            }
        }

        public static bool IsEven(List<int> B)
        {
            int sum = 0;
            for (int i = 0; i < B.Count; i++)
            {
                sum += B[i];
            }
            return sum % 2 == 0;
        }

        public static int GetMaxVal(List<int> listA, int k, int j)
        {
            int max = listA[0];

            for (int i = j; i < k; i++)
            {
                if (listA[i] > listA[i + 1] && listA[i] > max)
                {
                    max = listA[i];
                }
                else if (listA[i + 1] > listA[i] && listA[i + 1] > max)
                {
                    max = listA[i + 1];
                }
            }
            return max;
        }
    }
}
