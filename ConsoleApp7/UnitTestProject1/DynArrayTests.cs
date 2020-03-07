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
            Assert.IsTrue(array.array[0] == 1 && array.array[1] == 2 && array.array[2] == 3);
            array.Insert(100, 2);
            Assert.IsTrue(array.array[2] == 100 && array.capacity == 16);
        }

        [TestMethod]
        public void InsertWithOverwflow()
        {
            DynArray<int> array = new DynArray<int>();
            for (int i = 1; i <= 16; i++)
            {
                array.Append(i);
            }
            Assert.IsTrue(array.array[0] == 1 && array.array[15] == 16);
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
            Assert.IsTrue(array.array[0] == 1 && array.array[1] == 2 && array.array[2] == 3);
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
            Assert.IsTrue(array.array[0] == 1 && array.array[1] == 2 && array.array[2] == 3);

            array.Remove(1);
            Assert.IsTrue(array.array[1] == 3 && array.capacity == 16);
        }

        [TestMethod]
        public void RemoveWithBufferDecrease()
        {
            DynArray<int> array = new DynArray<int>();
            for (int i = 1; i <= 17; i++)
            {
                array.Append(i);
            }
            Assert.IsTrue(array.array[0] == 1 && array.array[15] == 16);
            array.Remove(3);
            array.Remove(3);
            Assert.IsTrue(array.array[3] == 6 && array.capacity == 21);
        }

        [TestMethod]
        public void RemoveInUnacceptablePosition()
        {
            DynArray<int> array = new DynArray<int>();
            array.Append(1);
            array.Append(2);
            array.Append(3);
            Assert.IsTrue(array.array[0] == 1 && array.array[1] == 2 && array.array[2] == 3);
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                array.Remove(10);
            });
        }
    }
}
