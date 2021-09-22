using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] tomb = new int[] { 2, 3, 4, 1, 5, 10, 6, 8 };
      
      int max = 0;

      for (int i = 1; i < tomb.Length; i++)
      {
        if(tomb[max] < tomb[i])
        {
          max = i;
        }
      }

      Console.WriteLine("A maximum: {0}",tomb[max]);

      Console.ReadLine();

    }
  }
}
