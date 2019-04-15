using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int HowManyTimes(string s, string s_generic)
        {
            char[] charS = s.ToCharArray();
            char[] charS_generic = s_generic.ToCharArray();

            int[] entries = new int[charS.Length];
            int result = 0;

            for (int i = 0; i < charS.Length; i++)
            {
                for (int j = 0; j < charS_generic.Length; j++)
                {
                    if (charS[i] == charS_generic[j])
                    {
                        entries[i]++;
                    }
                }
            }

            for (int i = 0; i < entries.Length - 1; i++)
            {
                if (result == 0)
                {
                    result = entries[i] * entries[i + 1];
                }
                else
                {
                    result *= entries[i + 1];
                }
            }

            return result;
        }
    }
}
