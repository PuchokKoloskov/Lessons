using System;
using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoublyLinkedListTests
{
    [TestClass]
    public class ClearTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedList2 list = new LinkedList2();
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(11));
            list.AddInTail(new Node(12));
            list.Clear();
            Assert.IsTrue(list.head == null && list.tail == null);
        }
    }
}
