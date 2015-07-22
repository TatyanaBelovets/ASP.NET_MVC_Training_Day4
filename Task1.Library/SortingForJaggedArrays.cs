using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Library
{
    public interface IComparer
    {
        int Compare(int[] lhs, int[] rhs);
    }

    public class SortingBySumOfElementsByAscending : IComparer
    {
        /// <summary>
        /// Sort matrix by sum of elements in rows by ascending.
        /// </summary>
        /// <param name="lhs">Left operand</param>
        /// <param name="rhs">Right operand</param>
        /// <returns>0 if the objects are considered equal; -1 if lhs greater than rhs; 1 otherwise 
        /// If both lhs and rhs are null, the method returns 0.</returns>
        public int Compare(int[] lhs, int[] rhs)
        {
            if (lhs == null && rhs == null) return 0;
            if (lhs == null || rhs == null) return lhs == null ? 1 : -1;
            var lhsSum = 0;
            var rhsSum = 0;
            foreach (var element in lhs)
            {
                lhsSum += element; 
            }
            foreach (var element in rhs)
            {
                rhsSum += element; 
            }
            if (lhsSum == rhsSum) return 0;
            return lhsSum < rhsSum ? 1 : -1;
        }
    }

    public class SortingBySumOfElementsByDescending : IComparer
    {
        /// <summary>
        /// Sort matrix by sum of elements in rows by descending.
        /// </summary>
        /// <param name="lhs">Left operand</param>
        /// <param name="rhs">Right operand</param>
        /// <returns>0 if the objects are considered equal; 1 if lhs greater than rhs; -1 otherwise 
        /// If both lhs and rhs are null, the method returns 0.</returns>
        public int Compare(int[] lhs, int[] rhs)
        {
            if (lhs == null && rhs == null) return 0;
            if (lhs == null || rhs == null) return rhs == null ? 1 : -1;
            var lhsSum = 0;
            var rhsSum = 0;
            foreach (var element in lhs)
            {
                lhsSum += element;
            }
            foreach (var element in rhs)
            {
                rhsSum += element;
            }
            if (lhsSum == rhsSum) return 0;
            return lhsSum > rhsSum ? 1 : -1;
        }
    }

    public class SortingByMaxAbsOfElementsByAscending : IComparer
    {
        /// <summary>
        /// Sort matrix by max abs of elements in rows by ascending.
        /// </summary>
        /// <param name="lhs">Left operand</param>
        /// <param name="rhs">Right operand</param>
        /// <returns>0 if the objects are considered equal; -1 if lhs greater than rhs; 1 otherwise 
        /// If both lhs and rhs are null, the method returns 0.</returns>
        public int Compare(int[] lhs, int[] rhs)
        {
            if (lhs == null && rhs == null) return 0;
            if (lhs == null || rhs == null) return lhs == null ? 1 : -1;
            var lhsMaxModule = 0; 
            var rhsMaxModule = 0;
            for (int i = 0; i < lhs.Length; i++)
            {
                lhsMaxModule = lhsMaxModule < lhs[i] ? lhs[i] : lhsMaxModule;
            }
            for (int i = 0; i < rhs.Length; i++)
            {
                rhsMaxModule = rhsMaxModule < rhs[i] ? rhs[i] : rhsMaxModule;
            }
            if (lhsMaxModule == rhsMaxModule) return 0;
            return lhsMaxModule < rhsMaxModule ? 1 : -1;
        }
    }

    public class SortingByMaxAbsOfElementsByDescending : IComparer
    {
        /// <summary>
        /// Sort matrix by max abs of elements in rows by descending.
        /// </summary>
        /// <param name="lhs">Left operand</param>
        /// <param name="rhs">Right operand</param>
        /// <returns>0 if the objects are considered equal; 1 if lhs greater than rhs; -1 otherwise 
        /// If both lhs and rhs are null, the method returns 0.</returns>
        public int Compare(int[] lhs, int[] rhs)
        {
            if (lhs == null && rhs == null) return 0;
            if (lhs == null || rhs == null) return rhs == null ? 1 : -1;
            var lhsMaxModule = 0;
            var rhsMaxModule = 0;
            for (int i = 0; i < lhs.Length; i++)
            {
                lhsMaxModule = lhsMaxModule < lhs[i] ? lhs[i] : lhsMaxModule;
            }
            for (int i = 0; i < rhs.Length; i++)
            {
                rhsMaxModule = rhsMaxModule < rhs[i] ? rhs[i] : rhsMaxModule;
            }
            if (lhsMaxModule == rhsMaxModule) return 0;
            return lhsMaxModule > rhsMaxModule ? 1 : -1;
        }
    }
    public class SortingForJaggedArrays
    {
        /// <summary>
        /// Method for sort matrix.
        /// </summary>
        /// <param name="array">Matrix for sorting</param>
        /// <param name="comparer">Rule of sorting</param>
        /// <returns>Sorted jagged array</returns>
        public static void Sort(int[][] array, IComparer comparer)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var nMaxLine = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    nMaxLine = comparer.Compare(array[nMaxLine], array[j]) == 1 ? nMaxLine : j;
                }
                var temp = array[i];
                array[i] = array[nMaxLine];
                array[nMaxLine] = temp;
            }
        }
    }
}
