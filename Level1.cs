using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string MassVote(int N, int[] Votes)
        {
            if (N < 1)
            {
                return "";
            }

            int indexOfMax = 0;
            int indexOfAnotherMax = 1;
            string result = "";

            double[] percentArray = new double[N];
            double voteSum = 0;

            for (int i = 0; i < N; i++)
            {
                voteSum += Votes[i];
            }

            for (int i = 0; i < N; i++)
            {
                if (Votes[i] == 0)
                {
                    percentArray[i] = 0;
                }
                else
                {
                    percentArray[i] = Votes[i] / (voteSum / 100);

                    string tempString = Convert.ToString(percentArray[i]);
                    string[] tempStringArray = tempString.Split(',');

                    if (tempStringArray.Length > 1)
                    {
                        if (tempStringArray[1].Length > 2)
                        {
                            tempStringArray[1].Remove(2);
                        }

                        tempString = tempStringArray[0] + ',' + tempStringArray[1];
                        percentArray[i] = Convert.ToDouble(tempString);
                    }
                }
            }

            for (int i = 0; i < N - 1; i++)
            {

                if (percentArray[indexOfMax] < percentArray[i + 1])
                {
                    indexOfAnotherMax = indexOfMax;
                    indexOfMax = i + 1;
                }
                else if (percentArray[indexOfMax] > percentArray[i + 1])
                {
                    if (percentArray[indexOfAnotherMax] < percentArray[i + 1])
                    {
                        indexOfAnotherMax = i + 1;
                    }
                }
                else if (percentArray[indexOfMax] == percentArray[i + 1])
                {
                    indexOfAnotherMax = i + 1;
                }
            }

            if (percentArray[indexOfMax] == percentArray[indexOfAnotherMax])
            {
                result = "no winner";
            }
            else if (percentArray[indexOfMax] > 50)
            {
                result = "majority winner" + " " + (indexOfMax + 1).ToString();
            }
            else if (percentArray[indexOfMax] <= 50)
            {
                result = "minority winner" + " " + (indexOfMax + 1).ToString();
            }

            return result;
        }
    }
}
