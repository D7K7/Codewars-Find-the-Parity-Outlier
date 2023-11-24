using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{

public static void Main()
  {
    int[] testArray = {2, 4, 0, 100, 4, 11, 2602, 36};
    Console.WriteLine(Find(testArray));
  }

  public static int Find(int[] integers)
  {
    return (integers.Where(x => x % 2 != 0).Count() == 1) ? 
    integers.Where(x => x % 2 != 0).First() : integers.Where(x => x % 2 == 0).First();
  }
}
