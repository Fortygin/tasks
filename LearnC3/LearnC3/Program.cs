using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearnCsharp2
{
    class Program
    {
        static void PrintProductTable()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int result = i * j;
                    Console.Write(result + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void PrintNumbersToZero(int num)
        {

            int userValue = int.Parse(Console.ReadLine());

            Console.Clear();
            for (int i = userValue; i >= 0; i--)
            {

                Console.WriteLine(i);
            }

            if (userValue < 0)
            {
                for (int i = userValue; i <= 0; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }

        static int Factorial(int num2)
        {
            int a = 0;
            int f = 1;
            if (a > 0)
            {
                while (a > 0)
                {
                    f *= a--;
                    Console.WriteLine(f);
                }

            }
            else
            {
                int d = 1;
                d *= d--;
                Console.WriteLine(d);
                return d;

            }

            return f;
        }


        static void PrintOddsFromZeroTo(uint num)
        {
            Console.WriteLine("Enter number:");
            int userValue = int.Parse(Console.ReadLine());

            for (int i = 0; i <= userValue; i++)
                if (i % 2 != 0)
                    Console.WriteLine("{0}", i);
        }
        static void Main(string[] args)
        {
            PrintProductTable();
            Console.Clear();
            Console.WriteLine("2 task:");
            Console.WriteLine("Enter number");
            int a = 0;

            PrintNumbersToZero(a);


            Console.Clear();
            Console.WriteLine("3 task");
            Console.WriteLine("Enter number");
            int userValue = int.Parse(Console.ReadLine());
            Factorial(userValue);
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("4 task");
            UInt32 c = 0;
            PrintOddsFromZeroTo(c);

            Console.ReadKey();

        }
    }
}
