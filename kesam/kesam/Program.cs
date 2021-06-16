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
              int start = 0;
              int konec = 5;    
          while (start != konec)
          {
              start = start + 1;

              int zadej = 1;
              while (zadej == 1)
              {
                  zadej = zadej - 1;
                  Console.Write("zapiš pozici pro x: ");
                  int y = Convert.ToInt32(Console.ReadLine()) - 1;

                  Console.Write("zapiš pozici pro y: ");
                  int x = Convert.ToInt32(Console.ReadLine()) - 1;

                  for (int i = 0; i < pole.GetLength(0); i++)
                  {
                      for (int j = 0; j < pole.GetLength(1); j++)
                          if (i == x)
                          {
                              if (j == y)
                              {
                                  if (pole[i, j] == 1 || pole[i, j] == -1)
                                  {
                                      Console.WriteLine("Pole obsazeno, zadej znovu:");
                                      zadej = zadej + 1;
                                  }
                                  else
                                  {
                                      pole[i, j] = 1;
                                  }

                              }
                          }
                  }
              }

              //skoro AI kamobrasko
              if (start != 5)
              {
                  int opakovat = 1;
                  while (opakovat == 1)
                  {
                      opakovat = 0;
                      Random random = new Random();
                      int xrnd = random.Next(0, 3);
                      int yrnd = random.Next(0, 3);

                      for (int i = 0; i < pole.GetLength(0); i++)
                      {
                          for (int j = 0; j < pole.GetLength(1); j++)
                              if (i == xrnd)
                              {
                                  if (j == yrnd)
                                  {
                                      if (pole[i, j] == 1 || pole[i, j] == -1)
                                      {
                                          opakovat = 1;

                                      }
                                      else
                                      {
                                          pole[i, j] = -1;
                                      }

                                  }
                              }
                      }


                  }

              }

              for (int i = 0; i < pole.GetLength(0); i++)
                        {
                            for (int j = 0; j < pole.GetLength(1); j++)
                            {
                                Console.Write("{0,2} ", pole[i, j]);
                            }

                            Console.WriteLine();
                        }

                    





          }
          Console.WriteLine("Konec - remíza");

              Console.ReadLine();
              
      }
      
    
      
      }





  }
    
    

      
      
      


