using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node
    {
        public int value;
        public Node next;

        public Node(int _value)
        {
            value = _value;
        }
    }

    public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (head == null)
            {
                head = _item;
            }
            else
            {
                tail.next = _item;
            }

            tail = _item;
        }

        public Node Find(int _value)
        {
            Node node = head;

            while (node != null)
            {
                if (node.value == _value)
                {
                    return node;
                }
                node = node.next;
            }

            return null;
        }

        public List<Node> FindAll(int _value)
        {
            List<Node> nodes = new List<Node>();
            Node node = head;

            while(node!= null)
            {
                if(node.value == _value)
                {
                    nodes.Add(node);
                }
                node = node.next;
            }

            // здесь будет ваш код поиска всех узлов по заданному значению
            return nodes;
        }

        public bool Remove(int _value)
        {
            if(head == null)
            {
                return false;
            }

            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (current.value == _value)
                {
                    if(previous != null)
                    {
                        previous.next = current.next;
                        if (current.next == null)
                        {
                            tail = previous;
                        }  
                    }
                    else
                    {
                        head = head.next;

                        if (head == null)
                            tail = null;
                    }

                    return true;
                }
                previous = current;
                current = current.next;
            }

            // здесь будет ваш код удаления одного узла по заданному значению
            return false; // если узел был удалён
        }

        public void RemoveAll(int _value)
        {
            if (head == null)
            {
                return;
            }

            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (current.value == _value)
                {
                    if (previous != null)
                    {
                        previous.next = current.next;
                        if (current.next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.next;

                        if (head == null)
                            tail = null;
                    }
                    previous = current;
                    current = current.next;

                    continue;
                }
                previous = current;
                current = current.next;
            }

            // здесь будет ваш код удаления всех узлов по заданному значению
        }

        public void Clear()
        {
            head = null;
            tail = null;
            // здесь будет ваш код очистки всего списка
        }

        public int Count()
        {
            int count = 0;
            Node node = head;

            while(node != null)
            {
                count++;
                node = node.next;
            }
            return count; // здесь будет ваш код подсчёта количества элементов в списке
        }

        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
        {
            if(_nodeAfter == null)
            {
                _nodeToInsert.next = head;
                head = _nodeToInsert;
                return;
            }
            else
            {
                Node node = head;

                while(node != null)
                {
                    if(node == _nodeAfter)
                    {
                        if(node == head)
                        {
                            _nodeToInsert.next = head;
                            head = _nodeToInsert;
                            return;
                        }
                        else
                        {
                            if(node.next == null)
                            {
                                node.next = _nodeToInsert;
                                tail = _nodeToInsert;
                                return;
                            }
                            else
                            {
                                _nodeToInsert.next = node.next;
                                node.next = _nodeToInsert;
                                return;
                            }
                        }
                    }
                    node = node.next;
                }
            }
            // здесь будет ваш код вставки узла после заданного

            // если _nodeAfter = null , 
            // добавьте новый элемент первым в списке 
        }
    }
}