using System;
using System.Collections.Generic;

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

          int start = 0;
          int konec = 5;
          
              //vypsaní
              for (int i = 0; i < pole.GetLength(0); i++)
              {
                  for (int j = 0; j < pole.GetLength(1); j++)
                  {
                      Console.Write("{0}, ", pole[i, j]);
                  }

                  Console.WriteLine();
              }
              
          while (start != konec)
          {
              
              start = start + 1;
                    Console.Write("zapiš pozici pro x: ");
                      int x = Convert.ToInt32(Console.ReadLine()) - 1;

                      Console.Write("zapiš pozici pro y: ");
                      int y = Convert.ToInt32(Console.ReadLine()) - 1;

                      for (int i = 0; i < pole.GetLength(0); i++)
                      {
                          for (int j = 0; j < pole.GetLength(1); j++)
                              if (i == x)
                              {
                                  if (j == y)
                                  {
                                      pole[i, j] = 1;

                                  }
                              }
                      }
                      
                    //skoro AI kamobrasko
                    int opakovat = 1;
                    while (opakovat == 1)
                    {
                        opakovat = opakovat - 1;
                        Random random = new Random();
                        int xrnd = random.Next(0, 2);
                        int yrnd = random.Next(0, 2);
                        
                        for (int i = 0; i < pole.GetLength(0); i++)
                        {
                            for (int j = 0; j < pole.GetLength(1); j++)
                                if (i == xrnd)
                                {
                                    if (j == yrnd)
                                    {
                                        if (pole[i, j] == 1 || pole[i, j] == -1)
                                        {
                                            opakovat = opakovat + 1;

                                        }
                                        else
                                        {
                                            pole[i, j] = -1;
                                        }

                                    }
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
          Console.WriteLine("Konec");

              Console.ReadLine();



      }
    
      
      }





  }
    
    

      
      
      


