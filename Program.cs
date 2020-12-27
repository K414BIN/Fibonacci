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
         
            Console.WriteLine("Добро пожаловать в программу поиска числа Фибоначчи порядка n. ");
            Console.WriteLine("Введите искомое n:");
            int x = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("n={0} => {1}", x, fib(x));
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
