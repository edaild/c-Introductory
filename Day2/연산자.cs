using System;

class MainClass{

    public static void Main(string[] args) {

        int result, num1, num2;

        result = 3 + 1;
        Console.WriteLine(result);

        result = 3 - 1;
        Console.WriteLine(result);

        num1 = 2;
        result = 5 * num1;
        Console.WriteLine(result);

        num2 = 10;
        result = num2 / 3;
        Console.WriteLine(result);

        result = 10 % 2;
        Console.WriteLine(result);

        Console.WriteLine("\n 증가갑 감소갑 출력 프로그래밍");
        int n = 0;
        Console.WriteLine(n++);
        Console.WriteLine(n);
        Console.WriteLine(--n);
        Console.WriteLine(n);



    }
}