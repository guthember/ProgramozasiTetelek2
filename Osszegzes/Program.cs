using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osszegzes
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] tomb = new int[] { 2, 3, 4, 1, 5, 10,6 };

      int osszeg = 0;

      Console.WriteLine("A tömb elemei: ");
      for (int i = 0; i < tomb.Length; i++)
      {
        //osszeg = osszeg + tomb[i];
        Console.Write("{0}, ",tomb[i]);
        osszeg += tomb[i];
      }

      Console.WriteLine("\nAz elemek összege: {0}",osszeg);

      Console.Write("A páratlan indexű elemek összege (feltétellel): ");

      osszeg = 0;
      for (int i = 0; i < tomb.Length; i++)
      {
        if (i % 2 == 1)
        {
          osszeg += tomb[i];
        }
      }

      Console.WriteLine(osszeg);


      osszeg = 0;
      for (int i = 1; i < tomb.Length ; i += 2)
      {
        osszeg += tomb[i];
      }
      
      Console.WriteLine("A páratlan indexű elemek összege: {0}",osszeg);


      Console.Write("A négynél nagyobb értékű elemk összege: ");

      osszeg = 0;
      for (int i = 0; i < tomb.Length; i++)
      {
        if (tomb[i] > 4)
        {
          osszeg += tomb[i];
        }
      }
      Console.WriteLine(osszeg);

      Console.ReadKey();
    }
  }
}
