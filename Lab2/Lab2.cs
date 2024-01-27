// 2. Develop c# program to print Armstrong Number between 1 to 1000

using System;

class ArmstrongNumber
{
    static void Main()
    {
        int num, rem, sum, temp;
        Console.WriteLine("Armstrong Number between 1 to 1000 are:");
        for (num = 1; num <= 1000; num++)
        {
            temp = num;
            sum = 0;
            while (temp != 0)
            {
                rem = temp % 10;
                sum = sum + (rem * rem * rem);
                temp = temp / 10;
            }
            if (num == sum)
            {
                Console.WriteLine(num);
            }
        }
        Console.WriteLine("All Armstrong Number between 1 to 1000 are printed.");
    }
}