// Three numbers A, B and C are given. Find the smallest among these three numbers.

#include <stdio.h>
int main()
{
    int a,b,c;
    printf("Enter three Numbers:");
    scanf("%d%d%d", &a,&b,&c);
    if (a<b)
        if(a<c)
        printf("Smallest = %d",a);
        else
        printf("Smallest = %d",c);
    else
        if(b<c)
        printf("Smallest = %d",b);
        else
        printf("Smallest = %d",c);

    return 0;


}
