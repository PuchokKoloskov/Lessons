using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int HowManyTimes(string s, string s_generic)
        {

            var digits = new int[s.Length];
            char[] charS = s_generic.ToCharArray();
            List<int[]> stringList = new List<int[]>();
            string str = "";
            int result = 0;
            int[] indexes = new int[s.Length];
            int countForIndexes = 0;
            int tempInt = 0;

            for (int i = 0; i < Math.Pow(charS.Length, s.Length); i++)
            {
                int ii = i;
                for (int j = 0; j < s.Length; j++)
                {
                    str = charS[ii % charS.Length] + str;
                    tempInt = ii % charS.Length;
                    indexes[countForIndexes] = tempInt;
                    ii /= charS.Length;

                    countForIndexes++;
                }

                if (s == str)
                {
                    int colibrate = 0;

                    for (int countForIndex = indexes.Length - 1; countForIndex >= 1; countForIndex--)
                    {
                        if (indexes[countForIndex] < indexes[countForIndex - 1]/* && !stringList.Contains(tempString)*/)
                        {
                            colibrate++;
                        }
                    }
                    if (colibrate == indexes.Length - 1)
                    {
                        result++;
                    }
                }

                stringList.Add(indexes);
                //stringList2.Add(str);
                str = "";
                countForIndexes = 0;
            }

            return result;
        }
    }
}
