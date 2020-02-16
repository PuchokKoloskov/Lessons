using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace DoublyLinkedListTests
{
    [TestClass]
    public class InsertAfterTest
    {
        [TestMethod]
        public void InsertInEmptyList()
        {
            LinkedList2 list = new LinkedList2();
            Node node = new Node(10);
            Node node2 = new Node(20);
            list.InsertAfter(node2, node);
            Assert.IsTrue(list.head == node && list.tail == node);
        }

        [TestMethod]
        public void InsertInFilledOneList()
        {
            LinkedList2 list = new LinkedList2();
            Node node = new Node(10);
            Node node2 = new Node(20);
            list.AddInTail(node2);
            list.InsertAfter(node2, node);
            Assert.IsTrue(list.head == node2 && list.tail == node);
        }

        [TestMethod]
        public void InsertInFilledOneListWithoutNodeAfter()
        {
            LinkedList2 list = new LinkedList2();
            Node node = new Node(10);
            Node node2 = new Node(20);
            list.AddInTail(node2);
            list.InsertAfter(null, node);
            Assert.IsTrue(list.head == node && list.tail == node2);
        }
    }
}
