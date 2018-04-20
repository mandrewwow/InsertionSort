using System;
using InsertionSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsertionSort.Tests
{
    [TestClass]
    public class InsertionSortTests
    {
        private InsertionSorter sorter = new InsertionSorter();

        [TestMethod]
        public void TestEmpty()//тест пустого массива
        {
            int[] Arr1 = new int[0];
            sorter.InsSort(Arr1);
            int[] Exp = new int[0];
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void TestSingle()//тест массива с одним элементом
        {
            int[] Arr1 = new int[1] { 1 };
            sorter.InsSort(Arr1);
            int[] Exp = new int[1] { 1 };
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void TestSimple()//тест обычного массива
        {
            int[] Arr1 = new int[8] {0, 2, 3, 7, 6, 1, 5, 4};
            sorter.InsSort(Arr1);
            int[] Exp = new int[8] {0, 1, 2, 3, 4, 5, 6, 7, };
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void TestMinus()//тест массива с отрицательными элементами
        {
            int[] Arr1 = new int[5] { 2, -1, 1, 0, -2 };
            sorter.InsSort(Arr1);
            int[] Exp = new int[5] { -2, -1, 0, 1, 2 };
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void Test0()//тест массива с нулевыми элементами
        {
            int[] Arr1 = new int[6] { 0, 0, 0, 0, 0, 0 };
            sorter.InsSort(Arr1);
            int[] Exp = new int[6] { 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(Exp, Arr1);
        }
    }
}
