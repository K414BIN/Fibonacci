using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Lesson4
{     
      class Program {
        public static int fibonacci(int n) 
        { 
           int z;
           if (n==0) return 0;
           if (n==1) return 1;
           z = fibonacci(n-1)*fibonacci(n-2);
          // Console.WriteLine(z);
         //
           return z;
        } 
       
        public static void Main()
        {    
            int x;
            Console.WriteLine("Добро пожаловать в программу поиска числа Фибоначчи порядка n. ");
            Console.WriteLine("Введите искомое n:");
                  x = Convert.ToInt32(System.Console.ReadLine());
//                  for (int i=0;i<x;i++)  Console.Write(" "+ fibonacci(x));
                 Console.WriteLine(fibonacci(x));
                  System.Console.ReadLine();
        }
//+++++++++++++++++++++
                    }
}