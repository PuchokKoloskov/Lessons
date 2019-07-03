using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string[] ShopOLAP(int N, string[] items)
        {
            if (!(N >= 2))
            {
                return items;
            }
            int[] itemNums = new int[N];
            string[] itemNames = new string[N];
            Dictionary<string, int> itemDictionary = new Dictionary<string, int>();
            Dictionary<string, int> secondItemDictionary = new Dictionary<string, int>();

            for (int i = 0; i < N; i++)
            {
                string[] tempStrArray = items[i].Split(' ');

                itemNames[i] = tempStrArray[0];
                itemNums[i] = Convert.ToInt32(tempStrArray[1]);

                if (itemDictionary.ContainsKey(itemNames[i]))
                {
                    secondItemDictionary.Add(itemNames[i], itemNums[i]);
                }
                else
                {
                    itemDictionary.Add(itemNames[i], itemNums[i]);
                }
            }
            JoinTheIqual(itemDictionary, secondItemDictionary);
            string[] resultArray = GetConvertToStringArray(itemDictionary);
            Array.Sort(resultArray);

            return resultArray;
        }

        public static void JoinTheIqual(Dictionary<string, int> itemDictionary, Dictionary<string, int> secondItemDictionary)
        {
            foreach (var item in secondItemDictionary)
            {
                itemDictionary[item.Key] += item.Value;
            }
        }

        public static string[] GetConvertToStringArray(Dictionary<string, int> itemDictionary)
        {
            string[] stringArray = new string[itemDictionary.Count];
            List<string> itemList = new List<string>();

            foreach (var item in itemDictionary)
            {
                itemList.Add(item.ToString());
            }
            for (int i = 0; i < stringArray.Length; i++)
            {
                string tempStr = itemList[i];
                stringArray[i] = tempStr.Replace(", ", " ");
            }

            return stringArray;
        }
    }
}
