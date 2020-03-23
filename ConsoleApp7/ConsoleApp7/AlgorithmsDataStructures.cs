using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Stack<T>
    {
        List<T> list;

        public Stack()
        {
            list = new List<T>();
            // инициализация внутреннего хранилища стека
        }

        public int Size()
        {
            // размер текущего стека		  
            return list.Count;
        }

        public T Pop()
        {
            if(list.Count == 0)// null, если стек пустой
                return default(T);
        
            T lastItem = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return lastItem; 
        }

        public void Push(T val)
        {
            list.Add(val);
            // ваш код
        }

        public T Peek()
        {
            if (list.Count == 0)// null, если стек пустой
                return default(T);

            T lastItem = list[list.Count - 1];
            return lastItem;
        }
    }
}