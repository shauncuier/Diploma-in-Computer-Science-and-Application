// 2.	Write a C program to find area and circumference of a circle by defining the value of PI.
#include <stdio.h>
#define PI 3.14
int main() {

int rad;

float area, ci;

printf("\nEnter radius of circle: ");

scanf("%d",&rad);

//area=PI*rad*rad;

//printf("\nArea of circle: %f",area);

ci=2*PI*rad;

printf("\nCircumference: %f\n",ci);

system("pause");

return (0);

}
