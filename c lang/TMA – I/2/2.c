// 2.	Write a C program to find area and circumference of a circle by defining the value of PI.
#include <stdio.h>
#define PI 3.14
int main()
{
int rad;
float area, ci;
printf("\nEnter radius of circle: ");
scanf("%d",&rad);
ci=2*PI*rad;
printf("\nCircumference: %f\n",ci);

return (0);
}
