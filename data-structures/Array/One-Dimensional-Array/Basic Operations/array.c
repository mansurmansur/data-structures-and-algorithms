#include <stdio.h>
#include <stdlib.h>
#include <string.h>

//main method
int main(){
    //variables
    int num[5] = {19, 10, 8, 17, 9};

    //print all the elements in the array
    //traversing through the array
    for (int i = 0; i < 5; i++)
    {
        printf("num[%d] =  %d", i, num[i]);
    }
    
    //update element at position i
    num[3] = -20;
    printf("num[%d] is %d", 3, num[3]);

    //accessing out of bound element
    printf("num[5] is %d", num[5]);

    return 1;
}