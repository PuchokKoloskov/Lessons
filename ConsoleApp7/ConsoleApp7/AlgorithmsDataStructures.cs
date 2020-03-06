using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class DynArray<T>
    {
        public T[] array;
        public int count;
        public int capacity;

        public DynArray()
        {
            count = 0;
            MakeArray(16);
        }

        public void MakeArray(int new_capacity)
        {
            if(array == null) // если создаём объект
            {
                array = new T[new_capacity];
                capacity = new_capacity;
                return;
            }
            
            T[] tempAr = new T[array.Length];
            Array.Copy(array, tempAr, array.Length);
            array = new T[new_capacity];

            if (new_capacity > capacity)
            {
                capacity = new_capacity;
                Array.Copy(tempAr, array, tempAr.Length);
            }
            else
            {
                capacity = new_capacity;
                Array.Copy(tempAr, array, array.Length);
            }
        }

        public T GetItem(int index)
        {
            if(index >= count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return array[index];
            }
        }

        public void Append(T itm)
        {
            if(capacity == count)
            {
                MakeArray(capacity * 2);
            }
            array[count] = itm;
            count++;
        }

        public void Insert(T itm, int index)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if(index == count)
            {
                Append(itm);
            }
            else
            {
                if (capacity == count)
                {
                    MakeArray(capacity * 2);
                }

                for (int i = count; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = itm;
                count++;
            }
        }

        public void Remove(int index)
        {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    for (int i = index; i < count - 1; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    array[count - 1] = default(T);
                    count--;

                    if(capacity / 2 > count)
                    {
                        if(capacity / 1.5 < 16)
                        {
                            MakeArray(16);
                        }
                        else
                        {
                            double temp = capacity / 1.5;
                            MakeArray((int)temp);
                        }
                    }
                }
            // ваш код
        }
    }
}