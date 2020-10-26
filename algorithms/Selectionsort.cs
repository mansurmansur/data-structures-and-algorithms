using System;

namespace Selectionsort
{
    /// <summary>
    /// Class name: Selectionsort
    /// This program uses selection sort algorithm to sort elements in an array.
    /// 
    /// 
    /// notes on selection sort:
    ///       selection sort algorithm sorts elements in an array by finding the mninimum element from
    ///       unsorted parts and putting it at the strt repeatedly until the whole array is sorted.
    ///       
    ///       the algorithm maintains 2 sub arrays in a given array:
    ///       1. The subarray that is sorted already
    ///       2. The remaining subarray that is unsorted
    ///       
    /// author: Mansur Mansur
    /// date: 2020-10-26
    /// </summary>
    public class Selectionsort
    {
        #region
        //main method
        public static void Main(string[] args)
        {
            int[] arr = { 20, 1, 14, 30, 3, 2, 70, 35, 60, 100, 11, 55, 19, 25, 5, 6, 80, 90 }; // array

            Console.WriteLine("Welcome to selection sort algorithm program: \n");
            Console.Write("Elements in the in array before sorted: ");

            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0} ,",arr[i]);   // print the elements in the array 

            selectionSort(arr);  //sort the array

            Console.Write("\nElements in the in array after sorting: ");
            for (int j = 0; j < arr.Length; j++)
                Console.Write("{0} ,", arr[j]);   // print the elements in the array 

            //end
        }
        #endregion
        #region
        //method name: selectionSort()
        //parameters: array A
        //return value: void
        //algorithm:
        //        1. n = A.Length  && minimum
        //        2. for i = 0 to n-1
        //        3.     minimum = i;    
        //        4.     for j = i+1 to n
        //        5.         if A[j] < A[i]
        //        6.             minimum = j
        //        7.  exchange A[minimum] with A[i]
        public static void selectionSort(int [] A)
        {
            int n = A.Length;       //array length
            int minimum, temp;

            for (int i = 0; i < n-1; i++)
            {
                minimum = i;          //set minimum element's index

                for (int j = i+1; j < n; j++)
                {
                    if (A[j] < A[minimum])
                        minimum = j;
                }

                //swap
                temp = A[minimum];
                A[minimum] = A[i];
                A[i] = temp;
            }
        }
        #endregion
    }
}
