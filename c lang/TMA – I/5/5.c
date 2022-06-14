//5.	Write a program to find the length of the hypotenuse of a right triangle given the length of other two sides.
#include <stdio.h>
#include <math.h>

int main()
{
  double side1, side2 , hypotenuse;

  printf("Enter Two sides of a triangle\n");
  scanf("%lf%lf", &side1, &side2);
  hypotenuse=sqrt((side1 * side1) + (side2 * side2));
  
  printf("Hypotenuse of the triangle = %.2lf\n", hypotenuse);

  return 0;
}