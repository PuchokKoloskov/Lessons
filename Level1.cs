using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] WordSearch(int len, string s, string subs)
        {
            if (s.Contains("  "))
            {
                return null;
            }

            string[] stringArray = Level1._stringSeparator(len, s);
            char[] charArryay = subs.ToCharArray();
            int[] intArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                char[] tempCharArray = stringArray[i].ToCharArray();

                if (stringArray[i].Contains(subs))
                {
                    string[] tempStringArray = stringArray[i].Split(' ');

                    for (int j = 0; j < tempStringArray.Length; j++)
                    {
                        if (tempStringArray[j] == subs)
                        {
                            intArray[i] = 1;
                        }
                    }
                }
            }

            return intArray;
        }

        static private string[] _stringSeparator(int len, string s)
        {
            char[] ca = s.ToCharArray();
            List<char> charList = new List<char>();
            List<string> stringList = new List<string>();

            for (int i = 0; i < ca.Length; i++)
            {
                charList.Add(ca[i]);
            }

            for (int i = 0; i < s.Length; i++)
            {
                int mark = 0;
                bool flag = false;

                if (charList.Count > len)
                {
                    if (charList[len] != ' ')
                    {
                        for (int j = len - 1; j > 0; j--)
                        {
                            if (charList[j] == ' ')
                            {
                                mark = j;
                                flag = true;
                                break;
                            }
                            else
                            {
                                flag = false;
                            }
                        }

                        if (flag == false)
                        {
                            mark = len;
                        }
                    }
                    else
                    {
                        mark = len;
                    }
                }
                else
                {
                    mark = charList.Count;
                }

                char[] tempCa = new char[mark];

                for (int j = 0; j < mark; j++)
                {
                    tempCa[j] = charList[j];
                }
                stringList.Add(new string(tempCa));

                if (charList.Count > len && charList[mark] == ' ')
                {
                    charList.RemoveRange(0, mark + 1);
                }
                else if (charList.Count > len)
                {
                    charList.RemoveRange(0, mark);
                }
                else
                {
                    charList.RemoveRange(0, mark);
                }

                if (charList.Count == 0)
                {
                    break;
                }
            }

            string[] array = new string[stringList.Count];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = stringList[i];
            }

            return array;
        }
    }
}
