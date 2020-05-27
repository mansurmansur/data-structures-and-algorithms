import java.io.*;
import java.util.*;

public class Main {

    //main method
    public static void main(String[] args){

        //variables
        int [] arr = new int[]{20, 1, 14, 30, 3, 2, 70, 35, 60, 100, 11, 55, 19, 25, 5,6,80, 90};


        //print the elemets before sorting
        System.out.print("Before sorting:\n");
        for (int i = 0; i < arr.length-1; i++)
            System.out.print(""+arr[i]+",");

        //sort the array
        selection_sort(arr);

        //print the elemets after sorting
        System.out.print("After sorting:\n");
        for (int i = 0; i < arr.length-1; i++)
            System.out.print(""+arr[i]+",");
    }



    /**================================================================================================*
     *                                                                                                 *
     *                                                                                                 *
     *  Method name: selection_sort()                                                                  *
     *  parameters: int array  -> this method takes in an array or unsorted elements                   *
     *  return: void                                                                                   *
     *  algorithm:                                                                                     *
     *        I. get the array length and store it in n                                                *
     *        II. iterate through the elements by setting each element to minimum at a time            *
     *        III. compare the minimum element to the next element in the list/array                   *
     *        IV. if the minimum is greater then set minimum as the next element and swap              *
     *                                                                                                 *
     * ================================================================================================*/
     static void selection_sort(int [] arr){

         int n = arr.length;   //array length

         //loop through the elements
         for (int i=0; i < n-1; i++){
             int minNum = i;      //set the minimum number

             //compare it with the next number
             for (int j = i+1; j < n; j++)
                 if(arr[j] < arr[i])
                     minNum = j;


             //swap the found minimum
             int temp = arr[minNum];
             arr[minNum] = arr[i];
             arr[i] = temp;
         }
     }
}
