//4.	Write a C program to find area of a rectangle. 

#include<stdio.h>

int main(){
    int length, breadth;
    printf("What is the length of the rectangle:");
    scanf("%d", &length);

     printf("What is the breadth of the rectangle:");
     scanf("%d", &breadth);

     printf("The area if your rectangle is %d", length*breadth);
    return 0;
}
