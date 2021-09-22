using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereses
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] tomb = new int[] { 2, 3, 4, 1, 5, 10, 6, 8 };

      foreach (var t in tomb)
      {
        Console.Write("{0}, ",t);
      }

      Console.WriteLine("\nMilyen számot keressünk: ");
      int melyikSzam = Convert.ToInt32(Console.ReadLine());

      int i = 0;

      while (i < tomb.Length && tomb[i] != melyikSzam)
      {
        i++;
      }

      if (i < tomb.Length)
      {
        Console.WriteLine("{0}-ik helyen megtaláltuk",i+1);
      }
      else
      {
        Console.WriteLine("Nem volt ilyen.");
      }

      Console.ReadKey();
    }
  }
}
