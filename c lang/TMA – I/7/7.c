//7.	Evaluate the polynomial: Where the value of x is given from the keyboard.
#include <stdio.h>
#include<math.h>

void main()
{
 
  int i, N;
  float x, polySum=0,common_term;
  printf("Enter how many terms in the polynomial:"); 
  scanf("%d", & N);
  printf("Enter the value of x:"); 
  scanf("%f", & x);
  common_term=(x-1)/x;

  for (i = 1; i <= N; i++) {
    polySum += pow(common_term,i)/i;  /* calculating the polysum  */
  }

  printf("\nSum of the polynomial = %f\n", polySum); /* displays the sum */
}
