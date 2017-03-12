using System;


namespace Task1
{

    /// <summary>
    /// Provides method that 
    /// implements merge sorting algorithm. 
    /// </summary>
    public static class MergeSort
    {
        /// <summary>
        /// Sorts the elements in a one-dimensional array of integer
        /// </summary>
        /// <param name="array">The one-dimensional integer array to sort.</param>
        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] input, int left, int right)
        {

            if (left < right)
            {
                int middle = (left + right) / 2;

                Sort(input, left, middle);
                Sort(input, middle + 1, right);

                Merge(input, left, right, middle);

            }
        }


        private static void Merge(int[] input, int left, int right, int middle)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
    }
}
