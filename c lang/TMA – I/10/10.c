//10. Write a C program to find simple interest. [Simple interest formula: A = P(1 + rt) where P is the Principal amount of money to be invested at an Interest Rate R% per year for t Time (years) where r is in decimal form; r=R/100]
#include <stdio.h>

 int main() { 
    float principle, time, rate, SI; 
    /* Input principle, rate and time */ printf("Enter principle (amount): "); scanf("%f", &principle); 
    printf("Enter time: "); 
    scanf("%f", &time); printf("Enter rate: "); scanf("%f", &rate); 
    /* Calculate simple interest */
     SI = principle * (1+time *(rate/100));
     /* Print the resultant value of SI */ printf("Simple Interest = %f", SI);
     return 0; 
   }


