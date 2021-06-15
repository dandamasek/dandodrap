using System;
using System.Collections.Generic;

namespace kesam
{
  internal class Program
  {

      public static void Main(string[] args)
      {
          //vypsani pole s počatečníma 0
          int m = 3;
          int n = 3;
          int[,] pole = new int[m, n];

          for (int i = 0; i < pole.GetLength(0); i++)
          for (int j = 0; j < pole.GetLength(1); j++)
          {
              pole[i, j] = 0;
          }


          //vypsaní
          for (int i = 0; i < pole.GetLength(0); i++)
          {
              for (int j = 0; j < pole.GetLength(1); j++)
              {
                  Console.Write("{0}, ", pole[i, j]);
              }

              Console.WriteLine();
          }

          Console.Write("zapiš pozici pro x: ");
          int x = Convert.ToInt32(Console.ReadLine()) -1;

          Console.Write("zapiš pozici pro y: ");
          int y = Convert.ToInt32(Console.ReadLine()) -1;

          for (int i = 0; i < pole.GetLength(0); i++)
          {
              for (int j = 0; j < pole.GetLength(1); j++)
                  if ( i == x)
                  {
                      if ( j == y)
                      {
                          pole[i, j] = 1;
                         
                          }
                      }
                  }
          for (int i = 0; i < pole.GetLength(0); i++)
          {
              for (int j = 0; j < pole.GetLength(1); j++)
              {
                  Console.Write("{0}, ", pole[i, j]);
              }

              Console.WriteLine();
          }
          
          
          
          
          }
    
      
      }





  }
    
    

      
      
      


