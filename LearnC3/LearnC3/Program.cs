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
           
        }

        static void PrintNumbersToZero(int num)
        {
            while (num !=0)
            {
                if (num > 0)
                {
                    Console.Write(num + " ");
                    num--;
                }
                else
                {
                    Console.Write(num + " ");
                    num++;
                }
            }
          
        }

        static int Factorial(int num2)
        {
            
            int f = 1;
            if (num2 > 0)
            {
                while (num2 > 0)
                {
                    f *= num2--;
                }
            }
            else
            {
                int d = 1;
                d *= d--;
                return d;
            }
            return f;
        }


        static void PrintOddsFromZeroTo(uint num)
        {
           
            

            for (int i = 0; i <= num; i++)
                if (i % 2 != 0)
                    Console.Write("{0} ", i);
        }
        static void Main(string[] args)
        {
            PrintProductTable();
            Console.Clear();
            Console.WriteLine("2 task:");
            int a = 5;
            PrintNumbersToZero(a);
            PrintNumbersToZero(10);
            PrintNumbersToZero(-4);
            Console.ReadKey();


            Console.Clear();
            Console.WriteLine("3 task");
            int b = 6;
            Factorial(b);
            Console.WriteLine(Factorial(b));
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("4 task");
            UInt32 c = 10;
            PrintOddsFromZeroTo(c);

            Console.ReadKey();

        }
    }
}
