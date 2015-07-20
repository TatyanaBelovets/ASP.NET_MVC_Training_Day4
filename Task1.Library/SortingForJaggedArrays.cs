using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Library
{
    public interface IJaggedArrayComparable
    {
        bool Compare(int[] left, int[] right, Order order);
    }

    public enum Order
    {
        Ascending = 1,
        Descending = -1
    }
    public class SortingBySumOfElements : IJaggedArrayComparable
    {
        /// <summary>
        /// Sort matrix by sum of elements in rows.
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <param name="order">Parameter for direction of sorting; default: by ascending </param>
        public bool Compare(int[] left, int[] right, Order order = Order.Ascending)
        {
            return order == Order.Descending ? left.Sum() > right.Sum() : left.Sum() < right.Sum();
        }
    }

    public class SortingByMaxAbsOfElements : IJaggedArrayComparable
    {
        /// <summary>
        /// Sort matrix by max abs of elements in rows.
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <param name="order">Parameter for direction of sorting; default: by ascending</param>
        public bool Compare(int[] left, int[] right, Order order = Order.Ascending)
        {
            var leftMaxModule = 0; 
            var rightMaxModule = 0;
            for (int i = 0; i < left.Length; i++)
            {
                leftMaxModule = leftMaxModule < left[i] ? left[i] : leftMaxModule;
            }
            for (int i = 0; i < right.Length; i++)
            {
                rightMaxModule = rightMaxModule < right[i] ? right[i] : rightMaxModule;
            }
            return order == Order.Descending ? leftMaxModule > rightMaxModule : leftMaxModule < rightMaxModule;
        }
    }
    public class SortingForJaggedArrays
    {
        /// <summary>
        /// Method for sort matrix.
        /// </summary>
        /// <param name="array">Matrix for sorting</param>
        /// <param name="compare">Rule of sorting</param>
        /// <param name="order">Parameter for direction of sorting; default: by ascending</param>
        public static void Sort(int[][] array, IJaggedArrayComparable compare, Order order = Order.Ascending)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var nMaxLine = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    nMaxLine = compare.Compare(array[nMaxLine], array[j], order) ? nMaxLine : j;
                }
                var temp = array[i];
                array[i] = array[nMaxLine];
                array[nMaxLine] = temp;
            }
        }
    }
}
