using System;

class MainClass
{
    public static void Main(string[] args)
    {

        bool result;
        int num1, num2;

        num1 = 3;
        num2 = 5;

        result = num1 > num2;
        Console.WriteLine(result);

        result = num1 < num2;
        Console.WriteLine(result);

        result = num1 >= num2;
        Console.WriteLine(result);

        result = num1 <= num2;
        Console.WriteLine(result);

        result = num1 == num2;
        Console.WriteLine(result);

        result = num1 != num2;
        Console.WriteLine(result);

        Console.WriteLine("\n 논리 연산자");

        bool A, B;

        A = true;
        B = false;

        // 논리합
        Console.WriteLine(A && A);
        Console.WriteLine(A && B);

        // 논리곱
        Console.WriteLine(A || B);
        Console.WriteLine(B || B);

        // 부정
        Console.WriteLine(!A);
        Console.WriteLine(!B);





    }
}
