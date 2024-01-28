using System;

class Mainclass{
    public static void Main(string[] args)
    {
        // 1 부터 10까지 프로그래밍을 작성하시오.
        // 반복문을 안사용하면
        Console.WriteLine("1");
        Console.WriteLine("2");
        Console.WriteLine("3");
        Console.WriteLine("4");
        Console.WriteLine("4");
        Console.WriteLine("5");
        Console.WriteLine("6");
        Console.WriteLine("7");
        Console.WriteLine("9");
        Console.WriteLine("10");

      
     // for 문 사용시
     for( int i = 1; i<11;i++) {
         Console.WriteLine(i);
     }
       

        // while 문 상용시
        int i = 1;
            while (i < 11)
            Console.WriteLine(i++);
            
    }

} 


