using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            */

            Console.WriteLine("Method One");
            MethodOne();
            Console.WriteLine("Method Two");
            MethodTwo();
            Console.WriteLine("Method Three - both cases");
            MethodThree(4, 5);
            MethodThree(4, 4);
            Console.WriteLine("Method Four - both cases");
            MethodFour(4);
            MethodFour(5);
            Console.WriteLine("Method Five - all 3 cases");
            MethodFive(-3);
            MethodFive(0);
            MethodFive(50);
            Console.WriteLine("Method Six");
            MethodSix();
        }
        public static void MethodOne()
        {
            for (int i = 1000; i >= -1000; i--)
                Console.WriteLine($"{i}");
        }

        public static void MethodTwo()
        {
            for (int i = 3; i < 1000; i+=3)
                Console.WriteLine($"{i}");
        }

        public static void MethodThree(int one, int two)
        {
            if(one == two)
                Console.WriteLine($"{one} equals {two}");
            else
                Console.WriteLine($"{one} and {two} are not equal");
        }

        public static void MethodFour(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine($"{num} is Even");
            else
                Console.WriteLine($"{num} is Odd");
        }

        public static void MethodFive(int num)
        {
            if (num > 0)
                Console.WriteLine($"{num} is Positive");
            else if (num < 0)
                Console.WriteLine($"{num} is Negative");
            else
                Console.WriteLine($"{num} is neither pos or neg");

        }
        public static void MethodSix()
        {
            Console.Write("Enter your age: ");
            int age;
            var input = (Console.ReadLine());
            bool isString = int.TryParse(input,out age);
            Console.WriteLine($"Age={age}");
        }


    }
}
