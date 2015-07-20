using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Library;

namespace Task1.Tests
{
    [TestClass]
    public class SortingJaggedArraysTests
    {
        [TestMethod]
        public void SortingForJaggedArrays_GivenSortingByMaxAbsOfElements_ReturnSortedByMaxAbsArrayByAscending()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] { 1, 3, 5, 7, 9 };
                arr[1] = new[] { 0, 2, 4, 6 };
                arr[2] = new[] { 11, 22 };
                arr[3] = new[] { 11, 22, 54, 66 };
                arr[4] = new[] { 11 };
            }
            var arrResult = new int[5][];
            {
                arrResult[0] = new[] { 0, 2, 4, 6 };
                arrResult[1] = new[] { 1, 3, 5, 7, 9 };
                arrResult[2] = new[] { 11 };
                arrResult[3] = new[] { 11, 22 };
                arrResult[4] = new[] { 11, 22, 54, 66 };
            }
            SortingForJaggedArrays.Sort(arr, new SortingByMaxAbsOfElements());
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Assert.AreEqual(arrResult[i][j], arr[i][j]);
                }
            }
        }

        [TestMethod]
        public void SortingForJaggedArrays_GivenSortingByMaxAbsOfElementsAndTrue_ReturnSortedByMaxAbsArrayByDescending()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] { 1, 3, 5, 7, 9 };
                arr[1] = new[] { 0, 2, 4, 6 };
                arr[2] = new[] { 11, 22 };
                arr[3] = new[] { 11, 22, 54, -66 };
                arr[4] = new[] { 11 };
            }
            var arrResult = new int[5][];
            {
                arrResult[4] = new[] { 0, 2, 4, 6 };
                arrResult[3] = new[] { 1, 3, 5, 7, 9 };
                arrResult[2] = new[] { 11 };
                arrResult[1] = new[] { 11, 22 };
                arrResult[0] = new[] { 11, 22, 54, -66 };
            }
            SortingForJaggedArrays.Sort(arr, new SortingByMaxAbsOfElements(), Order.Descending);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Assert.AreEqual(arrResult[i][j], arr[i][j]);
                }
            }
        }

        [TestMethod]
        public void SortingForJaggedArrays_GivenSortingBySumOfElements_ReturnSortedByMaxAbsArrayByAscending()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] { 1, 3, 5, 7, 9 };
                arr[1] = new[] { 0, 2, 4, 6 };
                arr[2] = new[] { 11, 22 };
                arr[3] = new[] { 11, 22, 54, 66 };
                arr[4] = new[] { 11 };
            }
            var arrResult = new int[5][];
            {
                arrResult[0] = new[] { 11 };
                arrResult[1] = new[] { 0, 2, 4, 6 };
                arrResult[2] = new[] { 1, 3, 5, 7, 9 };
                arrResult[3] = new[] { 11, 22 };
                arrResult[4] = new[] { 11, 22, 54, 66 };
            }
            SortingForJaggedArrays.Sort(arr, new SortingBySumOfElements());
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Assert.AreEqual(arrResult[i][j], arr[i][j]);
                }
            }
        }

        [TestMethod]
        public void SortingForJaggedArrays_GivenSortingBySumOfElementsAndTrue_ReturnSortedByMaxAbsArrayByDescending()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] { 1, 3, 5, 7, 9 };
                arr[1] = new[] { 0, 2, 4, 6 };
                arr[2] = new[] { 11, 22 };
                arr[3] = new[] { 11, 22, 54, 66 };
                arr[4] = new[] { 11 };
            }
            var arrResult = new int[5][];
            {
                arrResult[4] = new[] { 11 };
                arrResult[3] = new[] { 0, 2, 4, 6 };
                arrResult[2] = new[] { 1, 3, 5, 7, 9 };
                arrResult[1] = new[] { 11, 22 };
                arrResult[0] = new[] { 11, 22, 54, 66 };
            }
            SortingForJaggedArrays.Sort(arr, new SortingBySumOfElements(), Order.Descending);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Assert.AreEqual(arrResult[i][j], arr[i][j]);
                }
            }
        }
    }
}
