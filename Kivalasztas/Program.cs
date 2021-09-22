using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivalasztas
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

      Console.Write("\nMelyik elem sorszámára vagy kiváncsi: ");
      int mitKeresunk = Convert.ToInt32(Console.ReadLine());

      int i = 0;

      while (tomb[i] != mitKeresunk)
      {
        i++;
      }

      Console.WriteLine("A(z) {0}-ik helyen van.",i+1);

      Console.ReadLine();
    }
  }
}
