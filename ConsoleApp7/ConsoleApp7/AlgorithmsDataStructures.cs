using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

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
            return false;
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
                        if (current.next == null)
                        {
                            tail = previous;
                            current = null;
                            tail.next = null;
                        }
                        else
                        {
                            current = current.next;
                            previous.next = current;
                        }
                        continue;
                    }
                    else
                    {
                        head = head.next;
                        current = head;

                        if (head == null)
                        {
                            tail = null;
                            current = null;
                        }
                        continue;
                    }
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
            int count =  this.Count();
            
            if(count == 0)
            {
                _nodeToInsert.next = head;
                head = _nodeToInsert;
                tail = _nodeToInsert;
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
                            _nodeToInsert.next = head.next;
                            head.next = _nodeToInsert;
                            if(tail == _nodeAfter)
                            {
                                tail = _nodeToInsert;
                            }
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
                _nodeToInsert.next = head;
                head = _nodeToInsert;
            }
            // здесь будет ваш код вставки узла после заданного

            // если _nodeAfter = null , 
            // добавьте новый элемент первым в списке 
        }
    }

    public class Node
    {
        public int value;
        public Node next, prev;

        public Node(int _value)
        {
            value = _value;
            next = null;
            prev = null;
        }
    }

    public class LinkedList2
    {
        public Node head;
        public Node tail;

        public LinkedList2()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (head == null)
            {
                head = _item;
                head.next = null;
                head.prev = null;
            }
            else
            {
                tail.next = _item;
                _item.prev = tail;
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
            while (node != null)
            {
                if (node.value == _value)
                {
                    nodes.Add(node);
                }
                node = node.next;
            }
            return nodes;
        }

        public bool Remove(int _value)
        {
            if (head == null)
            {
                return false;
            }
            Node node = head;
            node.prev = null;
            while (node != null)
            {
                if (node.value == _value)
                {
                    if (node.prev != null)
                    {
                        if(node.next != null)
                        {
                            Node previous = node.prev;
                            Node next = node.next;
                            previous.next = next;
                            next.prev = previous;
                            if (next.next == null)
                            {
                                tail = next;
                            }
                        }
                        else
                        {
                            Node previous = node.prev;
                            Node next = node.next;
                            previous.next = null;
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.next;
                        if (head != null)
                            head.prev = null;

                        if (head == null)
                            tail = null;
                    }
                    return true;
                }
                node = node.next;
                
            }
            return false;
        }

        public void RemoveAll(int _value)
        {
            if (head == null)
            {
                return;
            }

            Node node = head;
            node.prev = null;
            while (node != null)
            {
                if (node.value == _value)
                {
                    if (node.prev != null)
                    {
                        if (node.next != null)
                        {
                            Node previous = node.prev;
                            Node next = node.next;
                            previous.next = next;
                            next.prev = previous;
                            if (next.next == null)
                            {
                                tail = next;
                            }
                        }
                        else
                        {
                            Node previous = node.prev;
                            Node next = node.next;
                            previous.next = null;
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.next;
                        if(head != null)
                            head.prev = null;

                        if (head == null)
                            tail = null;
                    }
                }
                node = node.next;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
        }

        public int Count()
        {
            int count = 0;
            Node node = head;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            return count;
        }

        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
        {
            int count = this.Count();

            if (count == 0)
            {
                _nodeToInsert.next = head;
                head = _nodeToInsert;
                tail = _nodeToInsert;
                return;
            }
            else if(_nodeAfter == null)
            {
                _nodeToInsert.next = head;
                head.prev = _nodeToInsert;
                head = _nodeToInsert;
                head.prev = null;
                return;
            }
            else
            {
                Node node = head;

                while (node != null)
                {
                    if (node == _nodeAfter)
                    {
                        if (node == head)
                        {
                            Node tempNode = head.next;
                            _nodeToInsert.next = tempNode;
                            tempNode.prev = _nodeToInsert;

                            head.next = _nodeToInsert;
                            _nodeToInsert.prev = head;
                            if (tail == _nodeAfter)
                            {
                                tail = _nodeToInsert;
                            }
                            return;
                        }
                        else
                        {
                            if (node.next == null)
                            {
                                node.next = _nodeToInsert;
                                _nodeToInsert.prev = node;
                                tail = _nodeToInsert;
                                return;
                            }
                            else
                            {
                                Node tempNode = node.next;
                                _nodeToInsert.next = tempNode;
                                tempNode.prev = _nodeToInsert;
                                node.next = _nodeToInsert;
                                _nodeToInsert.prev = node;
                                return;
                            }
                        }
                    }
                    node = node.next;
                }
                _nodeToInsert.next = head;
                head.prev = _nodeToInsert;
                head = _nodeToInsert;
                head.prev = null;
            } 
        }
    }
}