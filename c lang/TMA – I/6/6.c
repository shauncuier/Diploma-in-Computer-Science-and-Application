// 6.	Write a C program to compute the area of the triangle given the values of A, B and C. Area of a triangle is given by the formula:Area = √(S (S – A) (S – B) (S – C)) where A, B and C are the sides of triangle and 2S = A + B + C.
#include <stdio.h>
#include <math.h>
int main()
{
  double a, b, c, s, area;

  printf("Enter sides of a triangle\n");
  scanf("%lf%lf%lf", &a, &b, &c);

  s = (a+b+c)/2; // Semiperimeter

  area = sqrt(s*(s-a)*(s-b)*(s-c));

  printf("Area of the triangle = %.2lf\n", area);

  return 0;
}
