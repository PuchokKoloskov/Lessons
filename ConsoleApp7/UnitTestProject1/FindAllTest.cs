using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;

namespace DoublyLinkedListTests
{
    /// <summary>
    /// Сводное описание для FindAllTest
    /// </summary>
    [TestClass]
    public class FindAllTest
    {
        [TestMethod]
        public void FindAllInEmptyList()
        {
            LinkedList2 list = new LinkedList2();
            List<Node> nodeList = list.FindAll(10);
            Assert.IsTrue(nodeList.Count == 0);
        }

        [TestMethod]
        public void FindAllInFilledList()
        {
            LinkedList2 list = new LinkedList2();
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(20));
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(30));
            list.AddInTail(new Node(10));
            List<Node> nodeList = list.FindAll(10);
            Assert.IsTrue(nodeList.Count == 3);
        }
        
    }
}
