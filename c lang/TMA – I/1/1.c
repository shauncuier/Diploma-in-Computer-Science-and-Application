//1.	Write a program to find the addition, subtraction, multiplication and division Modulas of two integers A and B.

#include <stdio.h>
int main()
{
    int a, b, add, sub, mult,divi, modulus;
    scanf("%d%d",&a,&b);

    add = a+b;
    sub = a-b;
    mult = a*b;
    divi = a/b;
    modulus = a%a;
    
    printf("The addition is %d \n", add);
    printf("The addition is %d \n", sub);
    printf("The addition is %d \n", mult);
    printf("The addition is %d \n", divi);
    printf("The addition is %d \n", modulus);

    return 0;
}
