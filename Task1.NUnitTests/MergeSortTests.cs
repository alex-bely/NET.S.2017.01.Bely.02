using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;

namespace Task1.NUnitTests
{
    [TestFixture]
    public class MergeSortTests
    {
        #region Positive
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[]{1, 2, 3, 4, 5, 6, 7, 8})]
        [TestCase(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9})]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 2, 2 }, new int[] { 2, 2 })]

        public void Sort_NormalIntegerArray_PositiveTest(int[] array, int[] result)
        {
            MergeSort.Sort(array);
            Assert.AreEqual(array, result);
            
        }
        #endregion

        #region ArgumentNullException
        [TestCase(null)]

        public void Sort_ArgumentArrayIsNullReferenced_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => MergeSort.Sort(array)); 
        }
        #endregion

        #region ArgumentOutOfRangeException
        [TestCase(new int[] { })]

        public void Sort_ArgumentArrayIsEmpty_ThrowsArgumentOutOfRangeException(int[] array)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MergeSort.Sort(array));
        }
        #endregion
    }
}
