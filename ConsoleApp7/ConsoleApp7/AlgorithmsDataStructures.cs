using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class HashTable
    {
        public int size;
        public int step;
        public string[] slots;

        public HashTable(int sz, int stp)
        {
            size = sz;
            step = stp;
            slots = new string[size];
            for (int i = 0; i < size; i++) slots[i] = null;
        }

        public int HashFun(string value)
        {
            // всегда возвращает корректный индекс слота
            return value.Length * 2 % size;
        }

        public int SeekSlot(string value)
        {
            bool isFull = true;

            for (int i = 0; i < slots.Length; i++)
            {
                if(slots[i] == null)
                {
                    isFull = false;
                    break;
                }
            }

            if(isFull)
            {
                return -1;
            }

            int index = HashFun(value);

            while(true)
            {
                if (slots[index] == null)
                {
                    return index;
                }
                else
                {
                    if(index + step >= slots.Length)
                    {
                        index = index + step - slots.Length;
                    }
                    else
                    {
                        index += step;
                    }
                }
            }
            // находит индекс пустого слота для значения, или -1
        }

        public int Put(string value)
        {
            int slot = SeekSlot(value);

            if(slot == -1)
            {
                return -1;
            }
            else
            {
                slots[slot] = value;
                return slot;
            }
            // записываем значение по хэш-функции

            // возвращается индекс слота или -1
            // если из-за коллизий элемент не удаётся разместить
        }

        public int Find(string value)
        {
            int index = HashFun(value);

            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[index] == value)
                {
                    return index;
                }
                else
                {
                    if (index + step >= slots.Length)
                    {
                        index = index + step - slots.Length;
                    }
                    else
                    {
                        index += step;
                    }
                }
            }
            // находит индекс слота со значением, или -1
            return -1;
        }
    }
}