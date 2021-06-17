using System;

namespace piskvorky
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

            int win = 0;
            int start = 0;
            int konec = 5;
            while (start != konec && win != 1)
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
                    //vypisovani update polí
                    for (int i = 0; i < pole.GetLength(0); i++)
                    {
                        for (int j = 0; j < pole.GetLength(1); j++)
                        {
                            Console.Write("{0}, ", pole[i, j]);
                        }
                        Console.WriteLine();
                    }
                int k = 0;
                int d = 0;
                if (pole[k, d] == 1 && pole[k + 1, d] == 1 && pole[k + 2, d] == 1 ||
                    pole[k, d] == 1 && pole[k, d + 1] == 1 && pole[k, d + 2] == 1 ||
                    pole[k, d] == 1 && pole[k + 1, d + 1] == 1 && pole[k + 2, d + 2] == 1 ||
                    pole[k + 2, d] == 1 && pole[k + 1, d + 1] == 1 && pole[k, d + 2] == 1)
                    {
                        win = 1;
                        Console.WriteLine("vyhra");
                        Console.ReadLine();
                    }

                if (pole[k, d] == -1 && pole[k + 1, d] == -1 && pole[k + 2, d] == -1 ||
                    pole[k, d] == -1 && pole[k, d + 1] == -1 && pole[k, d + 2] == -1 ||
                    pole[k, d] == -1 && pole[k + 1, d + 1] == -1 && pole[k + 2, d + 2] == -1 ||
                    pole[k + 2, d] == -1 && pole[k + 1, d + 1] == -1 && pole[k, d + 2] == -1)
                    {
                        win = 1;
                        Console.WriteLine("prohra");
                        Console.ReadLine();
                    }
                }

            if (win == 1)
                {}
            else
                { 
                    Console.WriteLine("Konec - remíza");
                    Console.ReadLine();
                }
        
        }
      
    
      
      }





  }
    
    