using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_4
{
    class Program
    {
        static void Main()
        {
            decimal sum = 0;
            decimal f1 = 0;
            decimal f2 = 1;
            Console.WriteLine("Добро пожаловать в программу поиска числа Фибоначчи порядка n. ");
            Console.WriteLine("Введите искомое n:");
            int x = Convert.ToInt32(System.Console.ReadLine());
            x =Math.Abs(x);
            Console.WriteLine("Вариант с рекурсией.");
            Console.WriteLine("n={0} => {1}", x, fib(x));
            //
            Console.WriteLine("Вариант без рекурсии.");
            if (x > 1)
            {
                for (int i = 2; i < x+1; i++)
                {
                    sum = f1 + f2;
                    f1 = f2;
                    f2 = sum;
                }
            }
            else sum = x;
            Console.WriteLine($"F({x}) = " + sum) ;
            Console.ReadLine();
        }
              
        static decimal fib(decimal n)
        {
            if (n == 0 || n == 1)
                return n;

            return fib(n - 1) + fib(n - 2);

        }
            
    }
}