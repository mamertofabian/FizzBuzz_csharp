using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
  public class GeneratorTests
  {
    private IList<string> results;

    [SetUp]
    public void Setup()
    {
      var generator = new Generator();
      results = generator.Generate();
    }

    [Test]
    public void Should_Generate_100_Items()
    {
      Assert.AreEqual(100, results.Count);
    }

    [Test]
    public void Ninth_Item_Should_Be_Fizz()
    {
      Assert.AreEqual("Fizz", results[8]);
    }

    [Test]
    public void Fifth_Item_Should_Be_Buzz()
    {
      Assert.AreEqual("Buzz", results[4]);
    }

    [Test]
    public void Fifteenth_Item_Should_Be_FizzBuzz()
    {
      Assert.AreEqual("FizzBuzz", results[14]);
    }
  }
}