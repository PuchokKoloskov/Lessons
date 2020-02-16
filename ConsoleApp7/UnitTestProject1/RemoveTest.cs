using System;
using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoublyLinkedListTests
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void RemoveInEmptyList()
        {
            LinkedList2 list = new LinkedList2();
            Assert.IsTrue(list.Remove(1) == false);
        }

        [TestMethod]
        public void RemoveSingleNode()
        {
            LinkedList2 list = new LinkedList2();
            list.AddInTail(new Node(10));

            if (list.Remove(10) == true)
            {

                Assert.IsTrue(list.head == null);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void RemoveFirstNode()
        {
            LinkedList2 list = new LinkedList2();
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(11));
            list.AddInTail(new Node(12));
            if (list.Remove(10) == true)
            {
                Assert.IsTrue(list.head.value == 11);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void RemoveLastNode()
        {
            LinkedList2 list = new LinkedList2();
            list.AddInTail(new Node(10));
            list.AddInTail(new Node(11));
            list.AddInTail(new Node(12));
            if (list.Remove(12) == true)
            {
                Assert.IsTrue(list.tail.value == 11);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
