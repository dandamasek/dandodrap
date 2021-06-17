using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace kesam
{
  internal class Program
  {
      private static Random random = new Random();
      public static void Main(string[] args)
      {
          int m = 3;
          int n = 3;
          int[,] a = new int[m,n];
         
          for (int i = 0; i < a.GetLength(0); i++)
          {
              for (int j = 0; j < a.GetLength(1); j++)
              {
                  a[i, j] = 0;
                  a[0, 0] = 1;
                  Console.Write("{0}", a[i, j]);
              }

              Console.WriteLine();
          }
             

          
          
          
          }
      
    
      
      }





  }
    
    

      
      
      


