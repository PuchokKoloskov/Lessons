using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static List<string> resultList = new List<string>();
        public static string result = "";
        public static string indexChar = "";
        public static bool flag = true;
        //public static bool intByIndex = false;
        public static bool undo = false;
        public static int commandNumber = 0;
        public static int cursor = 0;

        static public string BastShoe(string command)
        {
            flag = true;
            CommandControl(command);
            if (flag)
            {
                if (commandNumber == 3)
                {
                    return indexChar;
                }
                return result;
            }
            else
            {
                //intByIndex = false;
                return "";
            }
        }

        static public void CommandControl(string command)
        {
            if (command.Length <= 1 || command[1] != ' ')
            {
                if (command != "4" && command != "5")
                {
                    Console.Write("Неправильные значения!");
                    flag = false;
                    return;
                }
            }
            commandNumber = Convert.ToInt32(command.Substring(0, 1));
            string content = "";
            if (commandNumber == 1 || commandNumber == 2 || commandNumber == 3)
            {
                content = command.Remove(0, 2);
            }
            switch (commandNumber)
            {
                case 1:
                    AddString(content);
                    break;
                case 2:
                    RemoveString(content);
                    break;
                case 3:
                    GetChar(content);
                    break;
                case 4:
                    Undo();
                    break;
                case 5:
                    Redo();
                    break;
                default:
                    Console.WriteLine("Неправильные значения!");
                    break;
            }
        }

        public static void AddString(string s)
        {
            if (undo == true)
            {
                resultList.Clear();
                resultList.Add(result);
                cursor = 1;
                undo = false;
            }
            result += s;
            resultList.Add(result);
            cursor++;
        }

        public static void RemoveString(string content)
        {
            if (undo == true)
            {
                resultList.Clear();
                resultList.Add(result);
                cursor = 1;
                undo = false;
            }
            int length = 0;

            try
            {
                length = Convert.ToInt32(content);
            }
            catch
            {
                Console.WriteLine("Неправильные значения!");
                flag = false;
                return;
            }
            if (length > result.Length)
            {
                result = "";
                return;
            }
            result = result.Remove(result.Length - length);
            resultList.Add(result);
            cursor++;
        }

        public static void GetChar(string content)
        {
            //intByIndex = true;
            int index = 0;

            try
            {
                index = Convert.ToInt32(content);
            }
            catch
            {
                Console.WriteLine("Неправильные значения!");
                flag = false;
            }
            if (index > result.Length - 1)
            {
                Console.WriteLine("");
            }
            char[] caArray = result.ToCharArray();
            //Console.WriteLine(caArray[index].ToString());
            indexChar = caArray[index].ToString();
        }

        public static void Undo()
        {
            undo = true;
            if (cursor <= 1)
            {
                return;
            }
            result = resultList[cursor - 2];
            cursor--;
        }

        public static void Redo()
        {
            if (cursor - 1 >= resultList.Count - 1)
            {
                return;
            }
            result = resultList[cursor];
            cursor++;
        }
    }
}
