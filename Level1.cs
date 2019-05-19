using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        static int CoverWithTiles(int len)
        {
            if (len % 2 != 0)
            {
                return -1;
            }

            int result = rec(11, 3, len, 4);

            return result;
        }

        static int rec(int n, int previousN, int checkingN, int length)
        {
            int nextN = n;

            if (checkingN == 2)
            {
                nextN = previousN;
            }
            else if (checkingN == 4)
            {
                nextN = n;
            }
            else if (length < checkingN)
            {
                nextN = n * 4 - previousN;
                length += 2;

                nextN = rec(nextN, n, checkingN, length);
            }

            return nextN;
        }
    }
}
