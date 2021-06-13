using System;

namespace try
{

internal class Program
{
    static Random random = new Random();
    public static void Main(string[] args)s
    {
<<<<<<< HEAD
        int[] a = new int[10];
        for (int i = 0; i < a.Lenght; i++)
            a[i] = random.Next(a.Lenght);
            Console.Write("{0}, ", a[i]);

            Console.ReadLine();
    }

    static void SelectionSort(int[] a)
    {
        for (int j = 0; j < a.lenght-1; j++)
        {
            int iMin = j;
            for (int i = j+1; i < args.; i++)
            {
                if (a[i] < a[iMin])
                    iMin = i;
            }
            Prohod(a, j, iMin);
        }
    }

    static void Prohod(int[] a, int i1, int i2)
    {
        if (i1 != i2)
        {
            int p = a[i1];
            a[i1] = a[i2];
            a[i2] = p;
        }
=======
        Console.WriteLine("hdddsssoj");
>>>>>>> origin/main
    }
    
}

}