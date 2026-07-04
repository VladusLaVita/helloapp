using System;

namespace Program
{
    public class HelloApp
    {
        static void Main()
        {
            SayHello();   
            GreetBlack();
            GreetWhite(); 
        }
        
        static void SayHello()
        {
            Console.WriteLine("hello everyone");
        }

        static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }

        static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
    }
}

