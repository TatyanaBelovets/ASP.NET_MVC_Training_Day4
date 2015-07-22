using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Library;

namespace Task1.Tests
{
    [TestClass]
    public class SortingJaggedArraysTests
    {
        [TestMethod]
        public void Sort_GivenSortingByMaxAbsOfElementsByAscending_ReturnSortedByMaxAbsArrayByAscending()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] {1, 3, 5, 7, 9};
                arr[1] = new[] {0, 2, 4, 6};
                arr[2] = new[] {11, 22};
                arr[3] = new[] {11, 22, 54, 66};
                arr[4] = new[] {11};
            }
            var arrResult = new int[5][];
            {
                arrResult[0] = new[] {0, 2, 4, 6};
                arrResult[1] = new[] {1, 3, 5, 7, 9};
                arrResult[2] = new[] {11};
                arrResult[3] = new[] {11, 22};
                arrResult[4] = new[] {11, 22, 54, 66};
            }
            SortingForJaggedArrays.Sort(arr, new SortingByMaxAbsOfElementsByAscending());
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr[i].Length; j++)
                {
                    Assert.AreEqual(arrResult[i][j], arr[i][j]);
                }
            }
        }

        [TestMethod]
        public void Sort_GivenSortingByMaxAbsOfElementsByDescending_ReturnSortedByMaxAbsArrayByDescending()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] {1, 3, 5, 7, 9};
                arr[1] = new[] {0, 2, 4, 6};
                arr[2] = new[] {11, 22};
                arr[3] = new[] {11, 22, 54, -66};
                arr[4] = new[] {11};
            }
            var arrResult = new int[5][];
            {
                arrResult[4] = new[] {0, 2, 4, 6};
                arrResult[3] = new[] {1, 3, 5, 7, 9};
                arrResult[2] = new[] {11};
                arrResult[1] = new[] {11, 22};
                arrResult[0] = new[] {11, 22, 54, -66};
            }
            SortingForJaggedArrays.Sort(arr, new SortingByMaxAbsOfElementsByDescending());
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr[i].Length; j++)
                {
                    Assert.AreEqual(arrResult[i][j], arr[i][j]);
                }
            }
        }

        [TestMethod]
        public void Sort_GivenSortingBySumOfElementsByAscending_ReturnSortedByMaxAbsArrayByAscending()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] {1, 3, 5, 7, 9};
                arr[1] = new[] {0, 2, 4, 6};
                arr[2] = new[] {11, 22};
                arr[3] = new[] {11, 22, 54, 66};
                arr[4] = new[] {11};
            }
            var arrResult = new int[5][];
            {
                arrResult[0] = new[] {11};
                arrResult[1] = new[] {0, 2, 4, 6};
                arrResult[2] = new[] {1, 3, 5, 7, 9};
                arrResult[3] = new[] {11, 22};
                arrResult[4] = new[] {11, 22, 54, 66};
            }
            SortingForJaggedArrays.Sort(arr, new SortingBySumOfElementsByAscending());
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr[i].Length; j++)
                {
                    Assert.AreEqual(arrResult[i][j], arr[i][j]);
                }
            }
        }

        [TestMethod]
        public void Sort_GivenSortingBySumOfElementsByDescending_ReturnSortedByMaxAbsArrayByDescending()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] {1, 3, 5, 7, 9};
                arr[1] = new[] {0, 2, 4, 6};
                arr[2] = new[] {11, 22};
                arr[3] = new[] {11, 22, 54, 66};
                arr[4] = new[] {11};
            }
            var arrResult = new int[5][];
            {
                arrResult[4] = new[] {11};
                arrResult[3] = new[] {0, 2, 4, 6};
                arrResult[2] = new[] {1, 3, 5, 7, 9};
                arrResult[1] = new[] {11, 22};
                arrResult[0] = new[] {11, 22, 54, 66};
            }
            SortingForJaggedArrays.Sort(arr, new SortingBySumOfElementsByDescending());
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr[i].Length; j++)
                {
                    Assert.AreEqual(arrResult[i][j], arr[i][j]);
                }
            }
        }

        [TestMethod]
        public void
            Sort_GivenArrayWithNullRowsAndSortingByMaxAbsOfElementsByAscending_ReturnSortedByMaxAbsArrayByDescending()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] {1, 3, 5, 7, 9};
                arr[1] = null;
                arr[2] = new[] {11, 22};
                arr[3] = new[] {11, 22, 54, -66};
                arr[4] = new[] {11};
            }
            var arrResult = new int[5][];
            {
                arrResult[0] = null;
                arrResult[1] = new[] {1, 3, 5, 7, 9};
                arrResult[2] = new[] {11};
                arrResult[3] = new[] {11, 22};
                arrResult[4] = new[] {11, 22, 54, -66};
            }
            SortingForJaggedArrays.Sort(arr, new SortingByMaxAbsOfElementsByAscending());
            for (var i = 0; i < arr.Length; i++)
            {
                if (arrResult[i] == null)
                {
                    Assert.AreEqual(arrResult[i], arr[i]);
                }
                else
                {
                    for (var j = 0; j < arr[i].Length; j++)
                    {
                        Assert.AreEqual(arrResult[i][j], arr[i][j]);
                    }
                }
            }
        }

        [TestMethod]
        public void
            Sort_GivenGivenArrayWithNullRowsAndSortingByMaxAbsOfElementsByDescending_ReturnSortedByMaxAbsArrayByDescending
            ()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] {1, 3, 5, 7, 9};
                arr[1] = new[] {0, 2, 4, 6};
                arr[2] = null;
                arr[3] = new[] {11, 22, 54, -66};
                arr[4] = new[] {11};
            }
            var arrResult = new int[5][];
            {
                arrResult[0] = new[] {11, 22, 54, -66};
                arrResult[1] = new[] {11};
                arrResult[2] = new[] {1, 3, 5, 7, 9};
                arrResult[3] = new[] {0, 2, 4, 6};
                arrResult[4] = null;
            }
            SortingForJaggedArrays.Sort(arr, new SortingByMaxAbsOfElementsByDescending());
            for (var i = 0; i < arr.Length; i++)
            {
                if (arrResult[i] == null)
                {
                    Assert.AreEqual(arrResult[i], arr[i]);
                }
                else
                {
                    for (var j = 0; j < arr[i].Length; j++)
                    {
                        Assert.AreEqual(arrResult[i][j], arr[i][j]);
                    }
                }
            }
        }

        [TestMethod]
        public void
            Sort_GivenArrayWithNullRowsAndSortingBySumOfElementsByAscending_ReturnSortedByMaxAbsArrayByDescending()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] {1, 3, 5, 7, 9};
                arr[1] = null;
                arr[2] = new[] {11, 22};
                arr[3] = new[] {11, 22, 54, 66};
                arr[4] = new[] {11};
            }
            var arrResult = new int[5][];
            {
                arrResult[0] = null;
                arrResult[1] = new[] {11};
                arrResult[2] = new[] {1, 3, 5, 7, 9};
                arrResult[3] = new[] {11, 22};
                arrResult[4] = new[] {11, 22, 54, 66};
            }
            SortingForJaggedArrays.Sort(arr, new SortingBySumOfElementsByAscending());
            for (var i = 0; i < arr.Length; i++)
            {
                if (arrResult[i] == null)
                {
                    Assert.AreEqual(arrResult[i], arr[i]);
                }
                else
                {
                    for (var j = 0; j < arr[i].Length; j++)
                    {
                        Assert.AreEqual(arrResult[i][j], arr[i][j]);
                    }
                }
            }
        }

        [TestMethod]
        public void
            Sort_GivenArrayWithNullRowsAndSortingBySumOfElementsByDescending_ReturnSortedByMaxAbsArrayByDescending()
        {
            var arr = new int[5][];
            {
                arr[0] = new[] {1, 3, 5, 7, 9};
                arr[1] = null;
                arr[2] = new[] {11, 22};
                arr[3] = new[] {11, 22, 54, 66};
                arr[4] = new[] {11};
            }
            var arrResult = new int[5][];
            {
                arrResult[4] = null;
                arrResult[3] = new[] {11};
                arrResult[2] = new[] {1, 3, 5, 7, 9};
                arrResult[1] = new[] {11, 22};
                arrResult[0] = new[] {11, 22, 54, 66};
            }
            SortingForJaggedArrays.Sort(arr, new SortingBySumOfElementsByDescending());
            for (var i = 0; i < arr.Length; i++)
            {
                if (arrResult[i] == null)
                {
                    Assert.AreEqual(arrResult[i], arr[i]);
                }
                else
                {
                    for (var j = 0; j < arr[i].Length; j++)
                    {
                        Assert.AreEqual(arrResult[i][j], arr[i][j]);
                    }
                }
            }
        }
    }
}