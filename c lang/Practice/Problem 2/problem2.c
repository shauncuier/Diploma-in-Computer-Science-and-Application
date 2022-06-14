// Given the temperature C in the centigrade scale. Find its value F in the Fahrenheit scale.

#include<stdio.h>
int main()
{
    float C , F;
    printf("Enter Centigrade:");
    scanf("%f",&C);
    F = ((C/5)*9)+32;
    printf("Fahrenheit is %f",F);
    return 0;

}
