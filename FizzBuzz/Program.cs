using System;

namespace FizzBuzz
{
  class Program
  {
    static void Main(string[] args)
    {
      var generator = new Generator();
      var results = generator.Generate();

      foreach (var item in results)
      {
        System.Console.WriteLine(item);
      }
    }
  }
}
