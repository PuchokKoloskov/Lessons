using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] SynchronizingTables(int N, int[] ids, int[] salary)
        {
            int[] sortedIds = new int[ids.Length];
            sortedIds = Level1.Sorter(ids);

            int[] sortedSalaries = new int[ids.Length];
            sortedSalaries = Level1.Sorter(salary);

            int[] indexesForId = new int[ids.Length];
            indexesForId = Level1.SearchIndexByEntry(ids, sortedIds);

            int[] reSalary = new int[salary.Length];

            for (int i = 0; i < salary.Length; i++)
            {
                for (int j = 0; j < salary.Length; j++)
                {
                    if (indexesForId[i] == j)
                    {
                        reSalary[i] = sortedSalaries[j];
                    }
                }
            }

            return reSalary;
        }

        public static int[] Sorter(int[] array)
        {
            int[] sortArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                sortArray[i] = array[i];
            }

            for (int i = sortArray.Length; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    int tempInteger = 0;

                    if (sortArray[j] > sortArray[j + 1])
                    {
                        tempInteger = sortArray[j];
                        sortArray[j] = sortArray[j + 1];
                        sortArray[j + 1] = tempInteger;
                    }
                }
            }
            return sortArray;
        }

        public static int[] SearchIndexByEntry(int[] idsOrigin, int[] orderedIds)
        {
            int[] indexes = new int[orderedIds.Length];

            for (int i = 0; i < orderedIds.Length; i++)
            {
                for (int j = 0; j < idsOrigin.Length; j++)
                {
                    if (idsOrigin[j] == orderedIds[i])
                    {
                        indexes[i] = j;
                        break;
                    }
                }
            }

            int[] idIndexesOrigin = new int[idsOrigin.Length];

            for (int i = 0; i < idsOrigin.Length; i++)
            {
                for (int j = 0; j < idsOrigin.Length; j++)
                {
                    if (indexes[j] == i)
                    {
                        idIndexesOrigin[i] = j;
                    }
                }
            }

            return idIndexesOrigin;
        }
    }
}
