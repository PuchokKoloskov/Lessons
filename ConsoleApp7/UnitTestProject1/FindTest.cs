using System;
using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoublyLinkedListTests
{
    [TestClass]
    public class FindTest
    {
        [TestMethod]
        public void FindInEmptyList()
        {
            LinkedList2 list = new LinkedList2();
            Assert.IsTrue(list.Find(0) == null);
        }

        [TestMethod]
        public void FindInFilledList()
        {
            LinkedList2 list = new LinkedList2();
            Node testNode = new Node(12);
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(11));
            list.AddInTail(testNode);
            Assert.IsTrue(list.Find(13) == null && list.Find(12) == testNode);
        }
    }
}
