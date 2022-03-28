## c program boilerplate
<br>

    #include <stdio.h>
        int main()
        {
        
            return 0;
        }

## C programming 1.1
<br> 
    #include <stdio.h>
    int main ()
    {
        printf("Hello World");
        return 0;
    }


## C programming 2.1
<br>  

    #include <stdio.h>
        int main()
        {
            int a;
            int b;
            int sum;
            a = 50;
            b = 60;
            sum = a + b;
            printf("Sum is %d", sum);
            return 0;
        }

## C programming 2.2
<br> 

    #include <stdio.h>
        int main()
        {
            int a, b, sum;
            a = 50;
            b = 60;
            sum = a + b;
            printf("Sum is %d", sum);
            return 0;
        }


## C programming 2.3
<br>  

    #include <stdio.h>
    int main()
        {
            int a = 50, b = 60, sum;
            sum = a + b;
            printf("Sum is %d", sum);
            return 0;
        }


## C programming 2.4
<br>  

    #include <stdio.h>
    int main()
        {
            int x, y;
            x = 1;
            y = x;
            x = 2;
            printf("%d", y);
            return 0;
        }

## C programming 2.5
<br> 


    #include <stdio.h>
    int main()
        {
            int a = 50, b = 60, sum;
            sum = a + b;
            printf("%d + %d = %d", a, b, sum);
            return 0;
        }

## C programming 2.6
<br> 

    #include <stdio.h>
    int main()
        {
            int a = 50.45, b = 60, sum;
            sum = a + b;
            printf("%d + %d = %d", a, b, sum);
            return 0;
        }

## C programming 2.7
<br> 

    #include <stdio.h>
    int main()
        {
            int n;
            double x;
            x = 10.5;
            n = (int)x;
            printf("Value of n is %d\n", n);
            printf("Value of x is %lf\n", x);
            return 0;
        }


## C programming 2.8
<br> 

    #include <stdio.h>
    int main()
        {
            int a;
            a = 1000;
            printf("Value of a is %d", a);
            a = 21000;
            printf("Value of a is %d", a);
            a = 10000000;
            printf("Value of a is %d", a);
            a = 10000000;
            printf("Value of a is %d", a);
            a = 100020004000503;
            printf("Value of a is %d", a);
            a = 4325987632;
            printf("Value of a is %d", a);
            return 0;
        }


## C programming 2.9
<br> 


    #include <stdio.h>
    int main()
        {
            double a, b, sum;
            a = 9.5;
            b = 8.743;
            sum = a + b;
            printf("Sum is: %lf\n", sum);
            printf("Sum is: %0.2lf\n", sum);
            return 0;
        }

## C programming 2.10
<br> 

    #include <stdio.h>
    int main()
        {
            int a, b, sum;
            scanf("%d", &a);
            scanf("%d", &b);
            sum = a + b;
            printf("Sum is: %d\n", sum);
            return 0;
        }


## C programming 2.11
<br> 


    #include <stdio.h>
    int main()
        {
            int a, b, sum;
            scanf("%d", &a);
            scanf("%d", b);
            sum = a + b;
            printf("Sum is: %d\n", sum);
            return 0;
        }


## C programming 2.12
<br> 

    #include <stdio.h>
    int main()
        {
            char ch;
            printf("Enter the first letter of your name: ");
            scanf("%c", &ch);
            printf("The first letter of your name is: %c\n", ch);
            return 0;
        }

## C programming 2.13
<br> 

    #include <stdio.h>
    int main()
        {
            char ch;
            printf("Enter the first letter of your name: ");
            ch = getchar();
            printf("The first letter of your name is: %c\n", ch);
            return 0;
        }

## C programming 2.14
<br> 

    #include <stdio.h>
    int main()
        {
            int num1, num2;
            printf("Please enter a number: ");
            scanf("%d", &num1);
            printf("Please enter another number: ");
            scanf("%d", &num2);
            printf("%d + %d = %d\n", num1, num2, num1+num2);
            printf("%d %
            d = %d\n", num1, num2, num1num2);
            printf("%d * %d = %d\n", num1, num2, num1*num2);
            printf("%d / %d = %d\n", num1, num2, num1/num2);
            return 0;
        }


## C programming 2.15
<br> 


    #include <stdio.h>
    int main()
        {
            int num1, num2, value;
            char sign;
            printf("Please enter a number: ");
            scanf("%d", &num1);
            printf("Please enter another number: ");
            scanf("%d", &num2);
            value = num1 + num2;
            sign = '+';
            printf("%d %c %d = %d\n", num1, sign, num2, value);
            value = num1 num2;
            sign = '';
            printf("%d %c %d = %d\n", num1, sign, num2, value);
            value = num1 * num2;
            sign = '*';
            printf("%d %c %d = %d\n", num1, sign, num2, value);
            value = num1 / num2;
            sign = '/';
            printf("%d %c %d = %d\n", num1, sign, num2, value);
            return 0;
        }


## C programming 2.16
<br> 

    #include <stdio.h>
    int main()
        {
            // test program comment
            1
            printf("Hello ");
            /* We have printed Hello,
            now we shall print World.
            Note that this is a multiline
            comment */
            printf("World"); // printed world
            return 0;
        }