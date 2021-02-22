using System.Collections.Generic;

namespace FizzBuzz
{
  public class Generator
  {
    public Generator()
    {
    }

    public IList<string> Generate()
    {
      var items = new List<string>();
      for (int i = 0; i < 100; i++)
      {
        var item = i + 1;

        if (IsMultipleOf3(item) && IsMultipleOf5(item))
          items.Add("FizzBuzz");
        else if (IsMultipleOf3(item))
          items.Add("Fizz");
        else if (IsMultipleOf5(item))
          items.Add("Buzz");
        else
          items.Add(item.ToString());
      }

      return items;
    }

    private static bool IsMultipleOf5(int item)
    {
      return item % 5 == 0;
    }

    private static bool IsMultipleOf3(int item)
    {
      return item % 3 == 0;
    }
  }
}