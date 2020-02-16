using System;
using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoublyLinkedListTests
{
    [TestClass]
    public class AddInHeadTest
    {
        [TestMethod]
        public void AddInEmptyList()
        {
            LinkedList2 list = new LinkedList2();
            Node node = new Node(10);
            list.AddInHead(node);
            Assert.IsTrue(list.head == node && list.tail == node);
        }
    }
}
