using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldontes
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] tomb = new int[] { 2, 3, 4, 1, 5, 10, 6, 8 };

      int i = 0;

      while (i < tomb.Length && tomb[i] != 7 )
      {
        i++;
      }

      if (i < tomb.Length)
      {
        Console.WriteLine("Van 7 az elemek között");
      }
      else
      {
        Console.WriteLine("Nincs 7 az elemek között");
      }

      Console.ReadKey();
    }
  }
}
