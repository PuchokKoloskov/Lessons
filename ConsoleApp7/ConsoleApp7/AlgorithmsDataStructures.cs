using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class NativeDictionary<T>
    {
        public int size;
        public string[] slots;
        public T[] values;
         public int _age;

        public NativeDictionary(int sz)
        {
            size = sz;
            slots = new string[size];
            values = new T[size];
        }

        public int HashFun(string key)
        {
            return key.Length * 2 % size;

            // всегда возвращает корректный индекс слота
        }

        public int SeekSlot(string value)
        {
        //    bool isFull = true;

        //    for (int i = 0; i < slots.Length; i++)
        //    {
        //        if (slots[i] == null)
        //        {
        //            isFull = false;
        //            break;
        //        }
        //    }

        //    if (isFull)
        //    {
        //        return -1;
        //    }

            int index = HashFun(value);

            while (true)
            {
                if (slots[index] == null)
                {
                    return index;
                }
                else
                {
                    if (index + 3 >= slots.Length)
                    {
                        index = index + 3 - slots.Length;
                    }
                    else
                    {
                        index += 3;
                    }
                }
            }
            // находит индекс пустого слота для значения, или -1
        }

        public bool IsKey(string key)
        {
            // возвращает true если ключ имеется,
            // иначе false
            for (int i = 0; i < size; i++)
            {
                if (slots[i] == key)
                {
                    return true;
                }
            }
            return false;
        }

        public void Put(string key, T value)
        {
            if(IsKey(key))
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if(slots[i] == key) values[i] = value;
                    return;
                }

                //values[SeekSlot(key)] = value;
            }

            int slot = SeekSlot(key);
            
                slots[slot] = key;
            values[slot] = value;
            // гарантированно записываем 
            // значение value по ключу key
        }

        public T Get(string key)
        {
            if(IsKey(key))
            {
                return default(T);
            }

            return values[SeekSlot(key)];
            // возвращает value для key, 
            // или null если ключ не найден
        }
    }

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