using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        static public int[] UFO(int N, int[] data, bool octal)
        {
            int[] resultArray = new int[N];

            if (octal)
            {
                resultArray = Converter(8, data);
            }
            else
            {
                resultArray = Converter(16, data);
            }

            return resultArray;
        }

        static public int[] Converter(int notation, int[] data)
        {
            int[] result = new int[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                string tempString = data[i].ToString();

                int[] array = new int[tempString.Length];

                for (int j = 0; j < tempString.Length; j++)
                {
                    array[j] = Convert.ToInt32(tempString.Substring(j, 1));
                }

                int counter = 0;
                int sum = 0;

                for (int k = array.Length - 1; k >= 0; k--)
                {
                    sum += array[counter] * (int)Math.Pow(notation, k);
                    counter++;
                }

                result[i] = sum;
            }

            return result;
        }
    }
}
