using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string Keymaker(int k)
        {
            char[] doorsAr = new char[k];
            for (int i = 0; i < doorsAr.Length; i++)
            {
                doorsAr[i] = '1';
            }

            for (int i = 1; i < doorsAr.Length; i += 2)
            {
                doorsAr[i] = '0';
            }

            for (int i = 2; i < doorsAr.Length; i += 3)
            {
                if (doorsAr[i] == '1')
                {
                    doorsAr[i] = '0';
                }
                else
                {
                    doorsAr[i] = '1';
                }
            }

            for (int i = 4; i < doorsAr.Length + 1; i++)
            {
                for (int j = i - 1; j < doorsAr.Length; j += i)
                {
                    if (doorsAr[j] == '1')
                    {
                        doorsAr[j] = '0';
                    }
                    else
                    {
                        doorsAr[j] = '1';
                    }
                }
            }

            string result = new string(doorsAr);
            return result;
        }
    }
}
