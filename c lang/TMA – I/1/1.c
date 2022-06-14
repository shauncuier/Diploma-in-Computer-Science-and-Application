//1.	Write a program to find the addition, subtraction, multiplication and division Modulas of two integers A and B.

#include <stdio.h>
int main()
{
    int a, b, add, sub, mult,divi;
    scanf("%d%d",&a,&b);

    add = a+b;
    sub = a-b;
    mult = a*b;
    divi = a/b;
   
    printf("The addition is %d \n", add);
    printf("The subtraction is %d \n", sub);
    printf("The multiplication  is %d \n", mult);
    printf("The division  is %d \n", divi);

    return 0;
}
