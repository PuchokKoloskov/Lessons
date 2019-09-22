using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static bool SherlockValidString(string s)
        {
            bool isValid = false;

            List<int> quantitiesListOfChars = new List<int>();

            char[] caArray = s.ToCharArray();
            FillTheList(quantitiesListOfChars, caArray);
            quantitiesListOfChars.Sort();

            isValid = CheckTheValid(quantitiesListOfChars);

            return isValid;
        }

        public static void FillTheList(List<int> quantitiesListOfChars, char[] caArray)
        {
            List<char> charList = new List<char>();

            for (int i = 0; i < caArray.Length; i++)
            {
                if (charList.Contains(caArray[i]))
                {
                    quantitiesListOfChars[charList.IndexOf(caArray[i])]++;
                }
                else
                {
                    charList.Add(caArray[i]);
                    quantitiesListOfChars.Add(1);
                }
            }
        }

        public static bool CheckTheValid(List<int> quantitiesListOfChars)
        {
            if (quantitiesListOfChars[quantitiesListOfChars.Count - 1] - quantitiesListOfChars[0] > 1)
            {
                return false;
            }
            else
            {
                int[] intArray = quantitiesListOfChars.ToArray();
                char[] caArray = new char[intArray.Length];
                List<int> quantitiesOfQuantitiesListOfChars = new List<int>();

                for (int i = 0; i < intArray.Length; i++)
                {
                    caArray[i] = Convert.ToChar(intArray[i]);
                }

                FillTheList(quantitiesOfQuantitiesListOfChars, caArray);
                quantitiesOfQuantitiesListOfChars.Sort();

                if (quantitiesOfQuantitiesListOfChars[0] == 1 || quantitiesOfQuantitiesListOfChars[0] == 1 || quantitiesOfQuantitiesListOfChars.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
