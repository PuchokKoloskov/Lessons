using AlgorithmsDataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class LinkedListTest
    {
        public void TestOfRemove()
        {
            LinkedList list = new LinkedList();
            list.Clear();

            Console.WriteLine("Тестирование удаления:");

            if (list.Remove(1) == false)
            {
                Console.WriteLine("Удаление из пустого списка корректно!");
            }
            else
            {
                Console.WriteLine("Удаление из пустого списка некорректно!");
            }

            list.AddInTail(new Node(10));

            if (list.Remove(10) == true)
            {
                if (list.head == null && list.tail == null)
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
                if (list.head.value == 11)
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

        public void TestOfClear()
        {
            LinkedList list = new LinkedList();
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(10));

            Console.WriteLine("Тестирование очистки всего списка:");

            list.Clear();

            if (list.head == null && list.tail == null)
            {
                Console.WriteLine("Очистка списка корректна");
            }
             else
            {
                Console.WriteLine("Очистка списка некорректна");
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

        public void TestOfCount()
        {
            LinkedList list = new LinkedList();

            Console.WriteLine("Тестирование подсчета всех узлов:");

            list.AddInTail(new Node(10));
            list.AddInTail(new Node(11));
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(12));
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(13));

            if(list.Count() == 6)
            {
                Console.WriteLine("Подсчет узлов в списке корректный");
            }
            else
            {
                Console.WriteLine("Подсчет узлов в списке некорректный");
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

        public LinkedList IsLengthsIsEqual(LinkedList firstList, LinkedList secondList)
        {
            LinkedList resultList = new LinkedList();
            Node firstNode = firstList.head;
            Node secondNode = secondList.head;

            if (firstList.Count() == secondList.Count())
            {
                while (firstNode != null)
                {
                    resultList.AddInTail(new Node(firstNode.value + secondNode.value));

                    firstNode = firstNode.next;
                    secondNode = secondNode.next;
                }
            }

            return resultList;
        }
    }
}
