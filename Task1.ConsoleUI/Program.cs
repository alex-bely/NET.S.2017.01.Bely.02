using System;
using static Task1.MergeSort;
namespace Task1.ConsoleUI
{
    /// <summary>
    ///  Uses console user interface to display
    ///  sorted arrays
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point of the application
        /// </summary>
        static void Main(string[] args)
        {
            //Initialization of arrays
            int[] array = new int[] { };
            int[] array_2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] array_3 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            
            //Sorting arrays
            Sort(array);
            Sort(array_2);
            Sort(array_3);

            //Display the elements of the arrays
            Console.WriteLine("1st array");
            foreach (var number in array)
                Console.Write(number+" ");
            Console.WriteLine();

            Console.WriteLine("2nd array");
            foreach (var number in array_2)
                Console.Write(number + " ");
            Console.WriteLine("\n");


            Console.WriteLine("3rd array");
            foreach (var number in array_3)
                Console.Write(number + " ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
