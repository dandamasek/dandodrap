using System;

namespace kesam
{
  internal class Program
  {
    static Random random = new Random();
    public static void Main(string[] args)
    {
      int[] a = new int[10];
      for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(a.Length);
      SelectionSort(a);
      
      for (int i = 0; i < a.Length; i++)
        Console.Write("{0}, ", a[i]);

      Console.ReadLine();
    }


    static void SelectionSort(int[] a)
    {
      for (int j = 0; j < a.Length-1; j++)
      {
        int iMin = j;
        for (int i = j+1; i < a.Length; i++)
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
    }
    
    
  }
}