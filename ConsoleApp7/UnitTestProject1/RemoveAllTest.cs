using System;
using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoublyLinkedListTests
{
    [TestClass]
    public class RemoveAllTest
    {
        [TestMethod]
        public void RemoveInEmptyList()
        {
            LinkedList2 list = new LinkedList2();
            list.RemoveAll(10);
            Assert.IsTrue(list.head == null && list.tail == null);
        }

        [TestMethod]
        public void RemoveAll_10()
        {
            LinkedList2 list = new LinkedList2();
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(11));
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(12));
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(13));
            list.RemoveAll(10);
            Assert.IsTrue(list.head.value == 11 && list.head.next.value == 12 && list.tail.value == 13);
        }
    }
}
