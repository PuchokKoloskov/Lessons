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

            int result = rec(11, 3, len, 2);

            return 0;
        }

        static int rec(int n, int previousN, int checkingN, int length)
        {
            int nextN = n * 4 - previousN;
            length += 2;

            if (length < checkingN)
            {
                rec(nextN, n, checkingN, length);
            }

            return nextN;
        }
    }
}
