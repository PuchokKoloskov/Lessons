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
            List<string> stringList = new List<string>();
            List<string> stringList2 = new List<string>();
            string str = "";
            string tempString = "";
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

                    for (int count = s.Length - 1; count >= 0; count--)
                    {
                        tempString += indexes[count];
                    }

                    for (int countForIndex = 0; countForIndex < tempString.Length - 1; countForIndex++)
                    {
                        char[] ca = tempString.ToCharArray();

                        if (ca[countForIndex] < ca[countForIndex + 1] && !stringList.Contains(tempString))
                        {
                            colibrate++;
                        }
                    }
                    if (colibrate == tempString.Length - 1)
                    {
                        result++;
                        stringList.Add(tempString);
                    }
                }


                stringList2.Add(str);
                str = "";
                tempString = "";
                countForIndexes = 0;
                tempInt = 0;
            }

            return result;
        }
    }
}
