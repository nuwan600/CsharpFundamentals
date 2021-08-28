using System;

namespace CsharpFundamentals
{
    /// <summary>
    /// H.G Nuwan Indika
    /// nuwan600@gmail.com
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine("Calling funtion as Conditions");
            int number1 = 10 , number2 = 20;

            if (isGreater(number1,number2))
            {
                Console.WriteLine("i is less than j");
            }
            if(isGreater(number1,number2))
            {
                Console.WriteLine(" j is grater than i");
            }
            Console.WriteLine("//////////////////////////////////");


            Console.WriteLine("//////////////////////////////////");

            Console.WriteLine("else if Statements");
            int number3 = 10, number4 = 20;

            if (number3 == number4)
                Console.WriteLine("number3 is qual to number4");
            else if (number3 > number4)
                Console.WriteLine("number4 is grater than number3");
            else if (number3 < number4)
                Console.WriteLine("number3 is less than number4");

            Console.WriteLine("//////////////////////////////////");

            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine("Nested if else statements");
            int i = 10;
            int j = 20;
            
            if (i != j)
            {
                if (i < j)
                    Console.WriteLine("i is less than j");
                else if (i > j)
                    Console.WriteLine("i is greater than j");

            }
            else
            {
                Console.WriteLine("i is equal to j");
            }
            Console.WriteLine("//////////////////////////////////");


            Console.WriteLine("Ternary operator");
            ////Ternary operator 
            int x = 20;
            int y = 10;

            var result = x > y ? "x is grater than y" : "x is less than y";

            Console.WriteLine(result);
            Console.WriteLine("//////////////////////////////////");

            Console.WriteLine("Switch Statement");

            int u = 160;

            switch (u)
            {
                case 5:
                    Console.WriteLine("Value of x is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of x is 10");
                    break;
                case 15:
                    Console.WriteLine("Value of x is 15");
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    break;
            }

            Console.WriteLine("//////////////////////////////////");

            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine("for Loop ");

            for (int a = 10; a > 1; a--)
                Console.WriteLine("Value of i: {0}", a);

            Console.WriteLine("//////////////////////////////////");

            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine("while Loop ");

            int g = 0;

            while (g < 10)
            {
                Console.WriteLine(" g = {0}", g);

                g++; //increment
            }

            Console.WriteLine("//////////////////////////////////");
        }

        static bool isGreater(int i, int j)
        {
            return i > j;
        }
    
    }
}
