using System;

namespace Insertionsort
{
    /// <summary>
    /// class name: Insertionsort
    /// </summary>
    public class Insertionsort
    {
        #region
        //main method
        public static void Main(string[] args)
        {
            int [] arr = { 12, 11, 13, 5, 6 };  //array of elements
            Console.WriteLine("Welcome to selection sort Algorithm: ");

            //before sorted.
            Console.Write("\n Elements in the array before sorting: ");
            print(arr);

            insertionSort(arr); //sort the array

            //After sorted.
            Console.Write("\n Elements in the array After sorting: ");
            print(arr);

        }
        #endregion

        #region
        // method name: insertionSort
        // parameters: takes an Array of elements
        // return value: void
        // Algorithms: 
        //          1. for j = 1 to A.Length
        //          2.     key = A[j]
        //          3.     // insert A[j] into the sorted sequence A]1..j-1]
        //          4.     i = j - 1
        //          5.     while i >= 0 and A[i] > key
        //          6.           A[i + 1] = A[i]
        //          7.           i = i - 1
        //          8.    A[ i + 1] = key
        public static void insertionSort(int []A)
        {
            int key, i;    //item to be placed in sorted subarray
            for (int j = 1; j < A.Length; j++)
            {
                key = A[j];
                i = j - 1;

                while (i >= 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }

                A[i + 1] = key;
            }
        }
        #endregion

        #region
        // method name: print
        // parameters: none
        // return: none
        // prints all the elements in the array
        public static void print(int []A)
        {
            Console.Write("[ ");

            for (int i = 0; i < A.Length; i++)
                Console.Write("{0} ,",A[i]);

            Console.Write(" ]\n");
        }
        #endregion
    }
}
