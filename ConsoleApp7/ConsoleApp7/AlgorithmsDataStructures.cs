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

        public void TestOfRemove()
        {
            LinkedList list = new LinkedList();
            list.Clear();

            Console.WriteLine("Тестирование удаления:");

            if(list.Remove(1) == false)
            {
                Console.WriteLine("Удаление из пустого списка корректно!");
            }
            else
            {
                Console.WriteLine("Удаление из пустого списка некорректно!");
            }

            list.AddInTail(new Node(10));

            if(list.Remove(10) == true)
            {
                if(list.head == null && list.tail == null)
                {
                    Console.WriteLine("Удаление единственного узла корректно!");
                }
                else
                {
                    Console.WriteLine("Удаление единственного узла некорректно!");
                }
            }

            list.Clear();

            list.AddInTail(new Node(10));
            list.AddInTail(new Node(11));
            list.AddInTail(new Node(12));
            list.AddInTail(new Node(13));
            list.AddInTail(new Node(14));
            list.AddInTail(new Node(15));
            list.AddInTail(new Node(16));
            

            if (list.Remove(10) == true)
            {
                if(list.head.value == 11)
                {
                    Console.WriteLine("Удаление первого узла корректно!");
                }
                else
                {
                    Console.WriteLine("Удаление первого узла некорректно!");
                }
            }
            else
            {
                Console.WriteLine("Удаление первого узла некорректно!");
            }

            if (list.Remove(16) == true)
            {
                if (list.tail.value == 15)
                {
                    Console.WriteLine("Удаление последнего узла корректно!");
                }
                else
                {
                    Console.WriteLine("Удаление последнего узла некорректно!");
                }
            }
            else
            {
                Console.WriteLine("Удаление последнего узла некорректно!");
            }

        }

        public void TestOfRemoveAll()
        {
            LinkedList list = new LinkedList();
            list.Clear();

            Console.WriteLine("Тестирование удаления всех узлов:");

            list.RemoveAll(10);

            if (list.head == null && list.tail == null)
            {
                Console.WriteLine("Удаление всех узлов из пустого списка корректно!");
            }
            else
            {
                Console.WriteLine("Удаление всех узлов из пустого списка некорректно!");
            }

            list.AddInTail(new Node(10));
            list.AddInTail(new Node(11));
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(12));
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(13));

            list.RemoveAll(10);

            if (list.head.value == 11 && list.head.next.value == 12 && list.tail.value == 13)
            {
                Console.WriteLine("Удаление всех узлов корректно!");
            }
            else
            {
                Console.WriteLine("Удаление всех узлов некорректно!");
            }
        }

        public void TestOfFind()
        {
            LinkedList list = new LinkedList();
            list.Clear();

            Console.WriteLine("Тестирование поиска узла:");

            if (list.Find(0) == null)
            {
                Console.WriteLine("Поиск в пустом списке корректный");
            }
            else
            {
                Console.WriteLine("Поиск в пустом списке некорректный");
            }

            Node testNode = new Node(12);

            list.AddInTail(new Node(10));
            list.AddInTail(new Node(11));
            list.AddInTail(testNode);

            if (list.Find(13) == null && list.Find(12) == testNode)
            {
                Console.WriteLine("Поиск в непустом списке корректный");
            }
            else
            {
                Console.WriteLine("Поиск в непустом списке некорректный");
            }
        }

        public void TestOfInsertAFter()
        {
            LinkedList list = new LinkedList();
            list.Clear();

            Node testNodeToInsert = new Node(11);
            Node testNodeAfter = new Node(10);

            Console.WriteLine("Тестирование вставки узла после:");

            list.InsertAfter(testNodeAfter, testNodeToInsert);

            if (list.head == testNodeToInsert && list.tail == testNodeToInsert)
            {
                Console.WriteLine("Вставка узла в пустой список корректна");
            }
            else
            {
                Console.WriteLine("Вставка узла в пустой список некорректна");
            }

            list.Clear();
            testNodeAfter.next = null;
            testNodeToInsert.next = null;

            list.AddInTail(testNodeAfter);
            list.InsertAfter(testNodeAfter, testNodeToInsert);
                
            if (list.head == testNodeAfter && list.tail == testNodeToInsert)
            {
                Console.WriteLine("Вставка узла в список с одним узлом корректна");
            }
            else
            {
                Console.WriteLine("Вставка узла в список с одним узлом некорректна");
            }

            list.Clear();
            testNodeAfter.next = null;
            testNodeToInsert.next = null;

            list.AddInTail(new Node(12));
            list.AddInTail(new Node(13));
            list.AddInTail(new Node(14));

            list.InsertAfter(testNodeAfter, testNodeToInsert);

            if (list.head == testNodeToInsert && list.head.next.value == 12 && list.tail.value == 14)
            {
                Console.WriteLine("Вставка узла в список с отсутствующим указанным узлом корректна");
            }
            else
            {
                Console.WriteLine("Вставка узла в список с отсутствующим указанным узлом некорректна");
            }

            list.Clear();
            testNodeAfter.next = null;
            testNodeToInsert.next = null;

            list.AddInTail(testNodeAfter);
            list.AddInTail(new Node(12));
            list.AddInTail(new Node(13));
            list.AddInTail(new Node(14));
            list.InsertAfter(testNodeAfter, testNodeToInsert);

            if (list.head == testNodeAfter && list.head.next == testNodeToInsert && list.tail.value == 14)
            {
                Console.WriteLine("Вставка узла после указанного первого узла корректна");
            }
            else
            {
                Console.WriteLine("Вставка узла после указанного первого узла некорректна");
            }

            list.Clear();
            testNodeAfter.next = null;
            testNodeToInsert.next = null;

            list.AddInTail(new Node(12));
            list.AddInTail(new Node(13));
            list.AddInTail(new Node(14));
            list.AddInTail(testNodeAfter);
            list.InsertAfter(testNodeAfter, testNodeToInsert);

            if (list.tail == testNodeToInsert && testNodeAfter.next == testNodeToInsert)
            {
                Console.WriteLine("Вставка узла после указанного последнего узла корректна");
            }
            else
            {
                Console.WriteLine("Вставка узла после указанного последнего узла некорректна");
            }
        }
    }
}