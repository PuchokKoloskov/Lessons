using System;
using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class DynArrayTests
    {
        [TestMethod]
        public void InsertWithoutOverwflow()
        {
            DynArray<int> array = new DynArray<int>();

            array.Append(1);
            array.Append(2);
            array.Append(3);
            array.Append(4);
            array.Append(5);

            array.Insert(100, 3);

            Assert.IsTrue(array.array[3] == 100 && array.capacity == 16);
        }

        [TestMethod]
        public void InsertWithOverwflow()
        {
            DynArray<int> array = new DynArray<int>();
            for (int i = 0; i < 16; i++)
            {
                array.Append(i);
            }
            array.Insert(100, 7);
            Assert.IsTrue(array.array[7] == 100 && array.capacity == 32);
        }

        [TestMethod]
        public void InsertInUnacceptablePosition()
        {
            DynArray<int> array = new DynArray<int>();
            array.Append(1);
            array.Append(2);
            array.Append(3);
            array.Append(4);
            array.Append(5);
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                array.Insert(100, 10);
            });
        }

        [TestMethod]
        public void RemoveWithoutBufferDecrease()
        {
            DynArray<int> array = new DynArray<int>();
            array.Append(1);
            array.Append(2);
            array.Append(3);
            array.Append(4);
            array.Append(5);

            array.Remove(3);
            Assert.IsTrue(array.array[3] == 5 && array.capacity == 16);
        }

        [TestMethod]
        public void RemoveWithBufferDecrease()
        {
            DynArray<int> array = new DynArray<int>();
            for (int i = 0; i < 17; i++)
            {
                array.Append(i);
            }
            array.Remove(3);
            array.Remove(3);
            Assert.IsTrue(array.array[3] == 5 && array.capacity == 21);
        }

        [TestMethod]
        public void RemoveInUnacceptablePosition()
        {
            DynArray<int> array = new DynArray<int>();
            array.Append(1);
            array.Append(2);
            array.Append(3);
            array.Append(4);
            array.Append(5);
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                array.Remove(10);
            });
        }
    }
}
