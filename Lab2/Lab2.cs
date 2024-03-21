// 2. Develop c# program to print Armstrong Number between 1 to 1000

// What is armstrong number?
// An Armstrong number is a number such that the sum of its digits raised to the third power is equal to the number itself.
// Is it always third power or is it to the number of digits?
// It is always to the number of digits. For example, 153 is an Armstrong number because
// 153 = 1*1*1 + 5*5*5 + 3*3*3
// 153 = 1 + 125 + 27
// 153 = 153
// if we need to check if 21 is ar not?
// 21 = 2*2 + 1*1
// Armstrong numbers between 1 to 9 are: 1, 2, 3, 4, 5, 6, 7, 8, 9
// Armstrong numbers between 1 to 1000 are: 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407

using System;

class Lab2
{
    static void Main()
    {
        int num, sum, digit;
        Console.WriteLine("Armstrong numbers between 1 to 1000 are:");
        for (int i = 1; i <= 1000; i++)
        {
            num = i;
            sum = 0;
            int power = Order(i);
            while (num > 0)
            {
                digit = num % 10;
                sum += Convert.ToInt32(Math.Pow(digit, power));
                num /= 10;
            }
            if (sum == i)
            {
                Console.Write(i + " ");
            }
        }
    }
    static int Order(int n){
        int count = 0;
        while(n != 0){
            count++;
            n /= 10;
        }
        return count;
    }
}

// Output:

/*
Armstrong numbers between 1 to 1000 are:
1 2 3 4 5 6 7 8 9 153 370 371 407
*/