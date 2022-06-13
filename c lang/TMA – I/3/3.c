//3.	Write a program to convert a temperature reading in degree Fahrenheit to degree Celsius scale using the formula: C = (5/9)* (F-32)

#include<stdio.h>
int main()
{
    float C , F;
    printf("Enter Fahrenheit:");
    scanf("%f",&F);
    C = (F-32)*5/9;
    printf("Celsius is %f",C);

    return 0;

}
