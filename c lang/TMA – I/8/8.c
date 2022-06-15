//8.	Write a program to calculate the roots of the quadratic equation: ax2 + bx + c = 0 where a, b and c are known.
#include <math.h>
#include <stdio.h>
int main() {
    double a, b, c, discriminant, root1, root2;
    printf("Enter coefficients a, b and c: ");
    scanf("%lf %lf %lf", &a, &b, &c);

    discriminant = b * b - 4 * a * c;

    // condition for real and different roots
    if (discriminant > 0) {
        root1 = (-b + sqrt(discriminant)) / (2 * a);
        root2 = (-b - sqrt(discriminant)) / (2 * a);
        printf("root1 = %.2lf and root2 = %.2lf", root1, root2);
    }

    // condition for real and equal roots
    else if (discriminant == 0) {
        root1 = root2 = -b / (2 * a);
        printf("root1 = root2 = %.2lf;", root1);
    }

    // if roots are not real
    else {
        
        printf("imaginary root exist");
    }

    return 0;
}

