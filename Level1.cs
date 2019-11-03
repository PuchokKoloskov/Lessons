using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string BalancedParentheses(int N)
        {
            char[] caAr = new char[N * 2];
            List<string> parenList = new List<string>();
            addParen(parenList, N, N, caAr, 0);
            string result = "";

            foreach (string item in parenList)
            {
                result += " " + item;
            }

            return result;
        }

        public static void addParen(List<string> parenList, int leftParen, int rightParen, char[] caAr, int index)
        {
            if (leftParen < 0 || rightParen < leftParen) return;

            if (leftParen == 0 && rightParen == 0)
            {
                if (parenList.Contains(caAr.ToString()))
                {
                    return;
                }
                string temp = new string(caAr);
                parenList.Add(temp);
            }
            else
            {
                caAr[index] = '(';
                addParen(parenList, leftParen - 1, rightParen, caAr, index + 1);

                caAr[index] = ')';
                addParen(parenList, leftParen, rightParen - 1, caAr, index + 1);
            }
        }
    }
}
