using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        static public string[] ShopOLAP(int N, string[] items)
        {
            if (!(N >= 2))
            {
                return items;
            }

            int[] itemNums = new int[N];
            string[] itemNames = new string[N];
            Dictionary<string, int> itemDictionary = new Dictionary<string, int>();
            Dictionary<string, int> secondItemDictionary = new Dictionary<string, int>();
            List<string> doubleNamesList = new List<string>();
            List<int> doubleNumsList = new List<int>();

            for (int i = 0; i < N; i++)
            {
                string[] tempStrArray = items[i].Split(' ');

                itemNames[i] = tempStrArray[0];
                itemNums[i] = Convert.ToInt32(tempStrArray[1]);

                if (itemDictionary.ContainsKey(itemNames[i]))
                {
                    doubleNamesList.Add(itemNames[i]);
                    doubleNumsList.Add(itemNums[i]);
                }
                else
                {
                    itemDictionary.Add(itemNames[i], itemNums[i]);
                }
            }

            JoinTheIqual(itemDictionary, doubleNamesList, doubleNumsList);
            string[] resultArray = SortArrayBySell(itemDictionary);

            return resultArray;
        }

        public static void JoinTheIqual(Dictionary<string, int> itemDictionary, List<string> doubleNamesList, List<int> doubleNumsList)
        {
            for (int i = 0; i < doubleNamesList.Count; i++)
            {
                itemDictionary[doubleNamesList[i]] += doubleNumsList[i];
            }
        }

        public static string[] SortArrayBySell(Dictionary<string, int> itemDictionary)
        {
            List<string> namesList = new List<string>();
            List<int> numsList = new List<int>();
            string[] resultStringArray = new string[itemDictionary.Count];

            foreach (var item in itemDictionary)
            {
                namesList.Add(item.Key);
                numsList.Add(item.Value);
            }

            for (int i = itemDictionary.Count - 1; i >= 0; i--) // Цикл сортировки по показателям продаж
            {
                for (int j = 0; j < i; j++)
                {
                    if (numsList[j] < numsList[j + 1])
                    {
                        string tempName;
                        int tempNum;

                        tempNum = numsList[j + 1];
                        tempName = namesList[j + 1];

                        numsList[j + 1] = numsList[j];
                        namesList[j + 1] = namesList[j];

                        numsList[j] = tempNum;
                        namesList[j] = tempName;
                    }
                }
            }

            for (int i = 0; i < itemDictionary.Count; i++) // Конвертация с конкатенацией в строку
            {
                resultStringArray[i] = namesList[i] + ' ' + numsList[i];
            }

            for (int i = 0; i < itemDictionary.Count - 1; i++) // Проверка на наличие одинаковых показателей в продажах
            {
                List<int> tempIntList = new List<int>();
                tempIntList.Clear();
                tempIntList.Add(i);

                for (int j = i + 1; j < itemDictionary.Count; j++)
                {
                    if (numsList[i] == numsList[j])
                    {
                        tempIntList.Add(j);
                    }
                }

                if (tempIntList.Count > 1)
                {
                    resultStringArray = SortByLexOrder(tempIntList, resultStringArray); // Сортировка по лексикографическому порядку
                }
            }

            return resultStringArray;
        }

        public static string[] SortByLexOrder(List<int> indexesList, string[] resultStringArray)
        {
            List<string> tempList = new List<string>();

            for (int i = 0; i < indexesList.Count; i++)
            {
                tempList.Add(resultStringArray[indexesList[i]]);
            }

            tempList.Sort();

            for (int i = 0; i < indexesList.Count; i++)
            {
                resultStringArray[indexesList[i]] = tempList[i];
            }

            return resultStringArray;
        }
    }
}
