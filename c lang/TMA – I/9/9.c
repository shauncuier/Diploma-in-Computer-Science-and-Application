//9. Write a C program to swap two variables a) using temporary variable b) without using temporary variable.
#include <stdio.h>

int main()
{
    int x, y;
    printf("Enter Value of x : ");
    scanf("%d", &x);
    printf("\nEnter Value of y: ");
    scanf("%d", &y);
// a) using temporary variable 
    int temp = x;
    x = y;
    y = temp;

    printf("\nAfter Swapping: x = %d, y = %d", x, y);
   // b) without using temporary variable.
   x = x + y; // x now becomes 15
    y = x - y; // y becomes 10
    x = x - y; // x becomes 5

    printf("After Swapping: x = %d, y = %d", x, y);

    return 0;
}
