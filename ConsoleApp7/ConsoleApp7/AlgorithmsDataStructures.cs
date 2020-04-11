using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Queue<T>
    {
        List<T> list;

        public Queue()
        {
            list = new List<T>();
            // инициализация внутреннего хранилища очереди
        }

        public void Enqueue(T item)
        {
            list.Add(item);
            // вставка в хвост
        }

        public T Dequeue()
        {
            // выдача из головы
            if(list.Count == 0)
            {
                return default(T); // если очередь пустая
            }
            T item = list[0];
            list.RemoveAt(0);
            return item;
        }

        public int Size()
        {
            return list.Count; // размер очереди
        }

    }
}