using System;
using System.Collections.Concurrent;

namespace Quicksort
{
    /// <summary>
    /// class name: Quicksort
    /// Description:
    ///            This program uses quicksort to sort elements out. below is little explanation on quicksort.
    ///            
    ///            Quicksort has worst-case running time of O(n^2) on n number of elements in an array.
    ///            Despite this worst-case, it is the often best practical choice for sorting due to its efficiency
    ///            on the average, which is O(n log n). it works well even in virtual-memory environment.
    ///            quicksort uses divide-and-conquer paradigm.
    /// by Mansur Mansur
    /// reference: 3rd Edition introduction to Algorithm
    /// </summary>
    public class Quicksort
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };//{ 2,8,7,1,3,5,6,4}; //array of 8 elements unsorted
            Console.WriteLine("Welcome to Quicksort Algorithm.");
            Console.WriteLine("Print items in the array before sorted:   ");

            foreach (var item in arr)
            {
                Console.Write("{0},",item); //print all the items in the array
            }

            quicksort(arr, 0, arr.Length-1);       //sort the array

            Console.WriteLine("\nPrint items in the array after sorted: ");
            foreach (var item in arr)
            {
                Console.Write("{0},", item); //print all the items in the array
            }

            //#end
        }

        #region quicksort method
        // method name: quicksort()
        // parameters: Array A, integer p, integer r
        // return type: void
        // algorithm:
        //          QUICKSORT(A, p, r)
        //          1. if p < r
        //          2.    q = PARTITION(A, p, r)
        //          3.    QUICKSORT(A, p, q-1)
        //          4.    QUICKSORT(A, q+1, r)
        // it uses 3 steps : Divide, Conquer, and Combine
        // note: to sort an entire array A, the initial call is QUICKSORT(A, 0, A.length).
        public static void quicksort(int []A, int p, int r)
        {
            int q;  //the mid-point of the array

            if (p < r)
            {
                q = partition(A, p, r);      //divide the array
                quicksort(A, p, q - 1);      //sort the 1st part 
                quicksort(A, q + 1, r);      //sort the 2nd part
            }
        }
        #endregion

        #region partition method
        //method name: partition()
        //parameters: array A, integer  p, integer r
        //return : integer 
        //algorithm
        //        PARTITION(A, p, r)
        //        1. x = A[r]
        //        2. i = p-1;
        //        3. for j = p to r-1
        //        4.     if A[j] <= x
        //        5.          i = i + 1
        //        6.          exchange A[i] with A[j]
        //        7. exchange A[i + 1] with A[r]
        //        8. return i + 1
        // note: there are different ways of choosing the pivot. that is the key to the partition algorithm
        //      1. make the last element pivot -> which is implemented in this code
        //      2. make the first element pivot
        //      3. pick a random element as pivot
        //      4. pick median as pivot
        public static int partition(int []A, int p, int r)
        {
            int pivot = A[r];      // the last element in the array
            int i = p-1;
            int temp,temp1; 

            for (int j = p; j < r; j++)
            {
                if (A[j] <= pivot )
                {
                    i++;    //increment i

                    //swap A[i] with A[j]
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;        
                }
            }

            //swap A[i + 1] with A[r]
            temp1 = A[i + 1];
            A[i+1] = A[r];
            A[r] = temp1;

            return i+1;  //return i + 1
        }
        #endregion
    }
}
