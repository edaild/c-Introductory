using System;

class Mainclass {
    public static void Main(string[] args) {

        sbyte value1 = 64;
        sbyte value2 = 64;
        // 암시적 형 변환만 사용된 코드
        int value3 = value1 + value2;
        Console.WriteLine(value3);

        sbyte num1 = 64;
        sbyte num2 = 64;
        // 암시적 형 변환 명시적 형 변환이 모두 사용된 코드 
        int num3 = (int)num1 + num2;
        Console.WriteLine(num3);
    }
}