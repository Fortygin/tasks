﻿using System;
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
            
                while (num2 > 0)
                {
                    f *= num2--;
                }
            return f;
         
        }


        static void PrintOddsFromZeroTo(uint num)
        {
           
            

            for (int i = 0; i <= num; i++)
                if (i % 2 != 0)
                    Console.Write("{0} ", i);
        }

        static void task5()
        {


            float x, y, z;
            for (x = -1.5f; x <=0.5f; )
            {
                x = x + 0.5f;
                if (x == 0)
                    continue;
                for (y = -1.5f; y <= 0.5f; )
                {
                    
                    y = y + 0.5f;
                    if (y == 0)
                        continue;
                    for (z =-1.5f; z <= 0.5f; )
                    {
                        z = z + 0.5f;
                        if (z == 0)
                            continue;
                       float result = 1 + x - x*y*z/2+2/z+2*z/(x*y);
                        
                        
                        Console.WriteLine("x=" + x  + "\t|" + "y=" + y + "\t|" + "z=" + z + "\t|" + "result=" + result);
                    }
                    
                }
               
            }

        }

        static void PrintFibonachiTo(uint num)
        {
            uint numberOne = 1;
            uint numberTwo = 1;
            
            uint sum;
           
            for (uint i = 0; i < num; i++)
                {
                    sum = numberOne;
                    numberOne = numberTwo;
                    numberTwo += sum;

                    Console.Write(sum + " ");

                }




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

            Console.Clear();
            Console.WriteLine("5 task");
            task5();

            Console.Clear();
            Console.WriteLine("6 task");
            uint k = 5;
            PrintFibonachiTo(k);


            Console.ReadKey();

        }
    }
}
