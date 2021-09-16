using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megszamolas
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] tomb = new int[] { 2, 3, 4, 1, 5, 10, 6, 8 };

      Console.WriteLine("A tömb elemei:");

      foreach (var t in tomb)
      {
        Console.Write("{0}, ",t);
      }

      int db = 0;
      //for (int i = 0; i < tomb.Length; i++)
      //{
      //  if (tomb[i] % 2 == 0)
      //  {
      //    db++;
      //  }
      //}

      foreach (var t in tomb)
      {
        if (t % 2 == 0)
        {
          db++;
        }
      }

      Console.WriteLine("\nA páros elemek darabszáma: {0}",db);

      Console.ReadKey();
    }
  }
}
