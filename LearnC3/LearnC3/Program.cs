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

            for (int i = num; i >= 0; i--)
            {

                Console.Write(i + " ");
            }

            if (num < 0)
            {
                for (int i = num; i <= 0; i++)
                {
                    Console.Write(i + " ");
                }
            }

            

        }

        static int Factorial(int num2)
        {
            int userValue = int.Parse(Console.ReadLine()); 
            int f = 1;
            if (userValue > 0)
            {
                while (userValue > 0)
                {
                    f *= userValue--;
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
            int a = 5;
            PrintNumbersToZero(a);
            PrintNumbersToZero(10);
            PrintNumbersToZero(-4);
            Console.ReadKey();


            Console.Clear();
            Console.WriteLine("3 task");
            Console.WriteLine("Enter number");
            int b = 0;
            Factorial(b);
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("4 task");
            UInt32 c = 0;
            PrintOddsFromZeroTo(c);

            Console.ReadKey();

        }
    }
}
