using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int PrintingCosts(string Line)
        {
            char[] charLine = Line.ToCharArray();
            int toner = 0;
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            charDictionary.Add(' ', 0);
            charDictionary.Add('&', 24);
            charDictionary.Add(',', 7);
            charDictionary.Add('2', 22);
            charDictionary.Add('8', 23);
            charDictionary.Add('>', 10);
            charDictionary.Add('D', 26);
            charDictionary.Add('J', 18);
            charDictionary.Add('P', 23);
            charDictionary.Add('V', 19);
            charDictionary.Add('\\', 10);
            charDictionary.Add('b', 25);
            charDictionary.Add('h', 21);
            charDictionary.Add('n', 18);
            charDictionary.Add('t', 17);
            charDictionary.Add('z', 19);

            charDictionary.Add('!', 9);
            charDictionary.Add('\u0027', 3);
            charDictionary.Add('-', 7);
            charDictionary.Add('3', 23);
            charDictionary.Add('9', 26);
            charDictionary.Add('?', 15);
            charDictionary.Add('E', 26);
            charDictionary.Add('K', 21);
            charDictionary.Add('Q', 31);
            charDictionary.Add('W', 26);
            charDictionary.Add(']', 18);
            charDictionary.Add('c', 17);
            charDictionary.Add('i', 15);
            charDictionary.Add('o', 20);
            charDictionary.Add('u', 17);
            charDictionary.Add('{', 18);

            charDictionary.Add('"', 6);
            charDictionary.Add('(', 12);
            charDictionary.Add('.', 4);
            charDictionary.Add('4', 21);
            charDictionary.Add(':', 8);
            charDictionary.Add('@', 32);
            charDictionary.Add('F', 20);
            charDictionary.Add('L', 16);
            charDictionary.Add('R', 28);
            charDictionary.Add('X', 18);
            charDictionary.Add('^', 7);
            charDictionary.Add('d', 25);
            charDictionary.Add('j', 20);
            charDictionary.Add('p', 25);
            charDictionary.Add('v', 13);
            charDictionary.Add('|', 12);

            charDictionary.Add('#', 24);
            charDictionary.Add(')', 12);
            charDictionary.Add('/', 10);
            charDictionary.Add('5', 27);
            charDictionary.Add(';', 11);
            charDictionary.Add('A', 24);
            charDictionary.Add('G', 25);
            charDictionary.Add('M', 28);
            charDictionary.Add('S', 25);
            charDictionary.Add('Y', 14);
            charDictionary.Add('_', 8);
            charDictionary.Add('e', 23);
            charDictionary.Add('k', 21);
            charDictionary.Add('q', 25);
            charDictionary.Add('w', 19);
            charDictionary.Add('}', 18);

            charDictionary.Add('$', 29);
            charDictionary.Add('*', 17);
            charDictionary.Add('0', 22);
            charDictionary.Add('6', 26);
            charDictionary.Add('<', 10);
            charDictionary.Add('B', 29);
            charDictionary.Add('H', 25);
            charDictionary.Add('N', 25);
            charDictionary.Add('T', 16);
            charDictionary.Add('Z', 22);
            charDictionary.Add('`', 3);
            charDictionary.Add('f', 18);
            charDictionary.Add('l', 16);
            charDictionary.Add('r', 13);
            charDictionary.Add('x', 13);
            charDictionary.Add('~', 9);

            charDictionary.Add('%', 22);
            charDictionary.Add('+', 13);
            charDictionary.Add('1', 19);
            charDictionary.Add('7', 16);
            charDictionary.Add('=', 14);
            charDictionary.Add('C', 20);
            charDictionary.Add('I', 18);
            charDictionary.Add('O', 26);
            charDictionary.Add('U', 23);
            charDictionary.Add('[', 18);
            charDictionary.Add('a', 23);
            charDictionary.Add('g', 30);
            charDictionary.Add('m', 22);
            charDictionary.Add('s', 21);
            charDictionary.Add('y', 24);

            for (int i = 0; i < charLine.Length; i++)
            {
                if (charDictionary.ContainsKey(charLine[i]))
                {
                    toner += charDictionary[charLine[i]];
                }
                else
                {
                    toner += 23;
                }
            }

            return toner;
        }
    }
}
