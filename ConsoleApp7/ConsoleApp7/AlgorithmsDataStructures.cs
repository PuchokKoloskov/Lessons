using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Node<T>
    {
        public T value;
        public Node<T> next, prev;

        public Node(T _value)
        {
            value = _value;
            next = null;
            prev = null;
        }
    }

    public class OrderedList<T>
    {
        public Node<T> head, tail;
        private bool _ascending;

        public OrderedList(bool asc)
        {
            head = null;
            tail = null;
            _ascending = asc;
        }

        public int Compare(T v1, T v2)
        {
            int result = 0;
            if (typeof(T) == typeof(String))
            {
                return String.Compare(v1.ToString(), v2.ToString());
                // версия для лексикографического сравнения строк
            }
            else
            {
                int intV1 = Convert.ToInt32(v1);
                int intV2 = Convert.ToInt32(v2);

                if(intV1 < intV2)
                {
                    return -1;
                }
                else if(intV1 == intV2)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
                // универсальное сравнение
            }

            return result;
            // -1 если v1 < v2
            // 0 если v1 == v2
            // +1 если v1 > v2
        }

        public void Add(T value)
        {
            Node<T> addNode = new Node<T>(value);

                if(head == null)
                {
                    head = addNode;
                    tail = addNode;
                    return;
                }
                else
                {
                    Node<T> node = head;
                    Node<T> tempNode;

                    for (int i = 0; i < Count(); i++)
                    {
                        int compare = Compare(addNode.value, node.value);
                        if (_ascending)
                        {
                            if (compare == 1 && node != tail)
                            {
                                node = node.next;
                                continue;
                            }
                            else if(compare == 1 && node == tail)
                            {
                                node.next = addNode;
                                addNode.prev = node;
                                tail = addNode;
                                return;
                            }
                            else
                            {
                                if (node == head)
                                {
                                    addNode.next = node;
                                    node.prev = addNode;
                                    head = addNode;
                                    addNode.prev = null;
                                    head.prev = null;
                                    return;
                                }
                                else
                                {
                                    tempNode = node.prev;
                                    tempNode.next = addNode;
                                    addNode.prev = tempNode;
                                    addNode.next = node;
                                    node.prev = addNode;
                                    return;
                                }
                            }
                        }
                        else
                        {
                            if (compare == -1 && node != tail)
                            {
                                node = node.next;
                                continue;
                            }
                            else if (compare == -1 && node == tail)
                            {
                                node.next = addNode;
                                addNode.prev = node;
                                tail = addNode;
                                tail.next = null;
                                return;
                            }
                            else
                            {
                            if (node == head)
                            {
                                node.prev = addNode;
                                addNode.next = node;
                                head = addNode;
                                addNode.prev = null;
                                head.prev = null;
                                return;
                            }
                            else
                            {
                                tempNode = node.prev;
                                tempNode.next = addNode;
                                addNode.prev = tempNode;
                                addNode.next = node;
                                node.prev = addNode;
                                return;
                            }
                            }
                        }
                    }
                }
            // автоматическая вставка value 
            // в нужную позицию
        }

        public Node<T> Find(T val)
        {
            Node<T> node = head;
            

            while (node != null)
            {
                int compare = Compare(node.value, val);
                if (compare == 0)
                {
                    return node;
                }
                else
                {
                    node = node.next;
                }
            }

            return null; // здесь будет ваш код
        }

        public void Delete(T val)
        {
            Node<T> node = head;
            Node<T> tempNode;

            while (node != null)
            {
                int compare = Compare(node.value, val);
                if (compare == 0)
                {
                    if(node == head)
                    {
                        head = node.next;
                        head.prev = null;
                        return;
                    }
                    else if(node == tail)
                    {
                        tail = node.prev;
                        tail.next = null;
                        return;
                    }
                    else
                    {
                        tempNode = node.prev;
                        tempNode.next = node.next;
                        tempNode = tempNode.next;
                        tempNode.prev = node.prev;
                        return;
                    }
                }
                else
                {
                    node = node.next;
                }
            }
            // здесь будет ваш код
        }

        public void Clear(bool asc)
        {
            _ascending = asc;
            head = null;
            tail = null;
            // здесь будет ваш код
        }

        public int Count()
        {
            int count = 0;
            Node<T> node = head;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            return count; // здесь будет ваш код подсчёта количества элементов в списке
        }

        List<Node<T>> GetAll() // выдать все элементы упорядоченного 
                               // списка в виде стандартного списка
        {
            List<Node<T>> r = new List<Node<T>>();
            Node<T> node = head;
            while (node != null)
            {
                r.Add(node);
                node = node.next;
            }
            return r;
        }
    }
}