using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        static public bool LineAnalysis(string line)
        {
            char[] charArray = line.ToCharArray();

            if (charArray[0] != '*' || charArray[charArray.Length - 1] != '*')
            {
                return false;
            }

            string tempString = line.Trim(new char[] { '*', '*' });
            string[] tempArrayString = tempString.Split('*');

            if (tempArrayString.Length == 1)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < tempArrayString.Length - 1; i++)
                {
                    if (tempArrayString[i] != tempArrayString[i + 1])
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                return true;
            }
        }

        static public void Test1()
        {
            if (LineAnalysis("*......*.......*"))
            {
                Console.WriteLine("FAIL");
            }
            else
            {
                Console.WriteLine("PASS");
            }
        }
    }
}
