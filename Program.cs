using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Lesson4
{     
      class Program {
       
        static void Main()
        {    
            const  int iMatr=2;
            int[,] c= new int[iMatr,iMatr] {
                                            {1,1},
                                            {1,0},
                                                  };    
             int[,] x = multi(c,c);
             int[,]  matr = multi(x,c);
             for (int i=0;i<matr.GetLength(0);i++) {
                           				       Console.WriteLine();
				                               for (int j=0;j<matr.GetLength(1);j++) 
                                                                                                         {
								                                  Console.Write("{0} ",     matr[i,j]);
                                                                                                         }
                                                       }
           Console.WriteLine();
       
           }
          static int[,] multi(int[,] a,int[,] b)
          {
             if (a.GetLength(1) !=b.GetLength(0)) throw new Exception ("Матрицы нельзя перемножить!!!");
             int[,] r = new int[a.GetLength(0),b.GetLength(1)];
             for ( int i=0; i < a.GetLength(0); i++)
              {
                for (int j=0; j< b.GetLength(1);j++)
                  {  
                     for (int k=0;k< b.GetLength(0);k++)
                       {
                          r[i,j]=a[i,k]*b[k,j];
                       }
                  }
                }
             return r;           
           }
           }
//+++++++++++++++++++++
                    }
