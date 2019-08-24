using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string BiggerGreater(string input)
        {
            char[] ca = input.ToCharArray();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (string.Compare(ca[i].ToString(), ca[j].ToString()) == 1)
                    {
                        char temp = ca[i];
                        ca[i] = ca[j];
                        ca[j] = temp;

                        sortCharsOnRight(ca, j + 1);
                        string result = new string(ca);
                        return result;
                    }
                }
            }
            return "";
        }

        public static void sortCharsOnRight(char[] charArray, int indexOfLeftMutable)
        {
            char[] tempChar = new char[charArray.Length - indexOfLeftMutable];

            for (int i = 0; i < tempChar.Length; i++)
            {
                tempChar[i] = charArray[indexOfLeftMutable + i];
            }
            Array.Sort(tempChar);

            for (int i = 0; i < tempChar.Length; i++)
            {
                charArray[i + indexOfLeftMutable] = tempChar[i];
            }
        }
    }
}
