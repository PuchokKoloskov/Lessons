using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    class Deque<T>
    {
        List<T> list;

        public Deque()
        {
            list = new List<T>();
            Size();
            // инициализация внутреннего хранилища
        }

        public void AddFront(T item)
        {
            if(item == null)
            {
                return;
            }

            List<T> tempList = new List<T>(list);
            list.Clear();
            list.Add(item);

            for (int i = 0; i < tempList.Count; i++)
            {
                list.Add(tempList[i]);
            }
            Size();
            // добавление в голову
        }

        public void AddTail(T item)
        {
            if (item == null)
            {
                return;
            }

            list.Add(item);
            Size();
            // добавление в хвост
        }

        public T RemoveFront()
        {
            if(list.Count == 0)
            {
                return default(T);
            }
            T item = list[0];
            list.RemoveAt(0);
            // удаление из головы
            Size();
            return item;
        }

        public T RemoveTail()
        {
            if (list.Count == 0)
            {
                return default(T);
            }
            T item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            // удаление из хвоста
            Size();
            return item;
            //return default(T);
        }

        public int Size()
        {
            return list.Count; // размер очереди
        }
    }
}