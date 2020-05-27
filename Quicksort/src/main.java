/**
 *
 * Name of algorithm:  Quicksort
 *
 *
 * note:
 *    a) it has worst-case running time of O(n2), Despite slow worst-case Quicksort is often the best practical choice
 *       for sorting because it is remarkably  efficient on average.
 *    b) its expected running time is O(n log n).
 *
 *
 * Description: qucksort deploys the divide and conquer paradigm. below is 3 steps of divide and conquer process to
 *              sort a typical subarray A[p..r]:
 *
 *              1. Divide: partition the array A[p..r] into 2 subarrays A[p..q-1] and A[q+1..r]. such that each element
 *                 in of A[p..q-1] is less than or equal to A[q], which inturn, is less than or equal to each element
 *                 of A[q+1..r]. compute the index q as part of this  partitioning procedure.
 *
 *              2. Conquer: Sort the 2 subarrays by recursive calls of quicksort method
 *              3. Combine: after sorting the subarrays, no work is needed to combine them. since the entire array is
 *                          sorted.
 *
 *
 *
 * Algorithm:
 *     1. The following procedure implements quicksort:
 *          QUICKSORT(A,p,r)         : A is the array, p is the first element index and r is the last element index
 *            I. if p < r
 *            II.    q = PARTITION(A, p, r)
 *            III.   QUICKSORT(A, p, q-1)
 *            IV.    QUICKSORT(A, q+1, r)
 *    2. Partitioning of the array
 *          PARTITION(A, p, r)
 *              x = A[r]
 *              i = p - 1
 *              for j = p to r-1
 *                  if A[J] <= X
 *                     i = i+1
 *                     exchange A[i] with A[j]
 *              exchange A[i+1] with A[r]
 *              return i+1
 *
 *
 *
 *
 *=========================== by Mansur Mansur =========================================================================
 * */








public class main {
}
