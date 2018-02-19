using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class TheKingsFactorizationTest
{
    [TestMethod]
    public void Example0()
    {
        long N = 12L;
        Console.WriteLine("N:{0}",N);
        long[] primes = new long[] {
            2L,
            3L
        };
        Console.WriteLine(string.Format("primes:{0}",string.Join(" ",primes)));
        long[] __expected = new long[] {
            2L,
            2L,
            3L
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        long[] __result = new TheKingsFactorization().getVector(N, primes);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example1()
    {
        long N = 7L;
        Console.WriteLine("N:{0}",N);
        long[] primes = new long[] {
            7L
        };
        Console.WriteLine(string.Format("primes:{0}",string.Join(" ",primes)));
        long[] __expected = new long[] {
            7L
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        long[] __result = new TheKingsFactorization().getVector(N, primes);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example2()
    {
        long N = 1764L;
        Console.WriteLine("N:{0}",N);
        long[] primes = new long[] {
            2L,
            3L,
            7L
        };
        Console.WriteLine(string.Format("primes:{0}",string.Join(" ",primes)));
        long[] __expected = new long[] {
            2L,
            2L,
            3L,
            3L,
            7L,
            7L
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        long[] __result = new TheKingsFactorization().getVector(N, primes);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example3()
    {
        long N = 49L;
        Console.WriteLine("N:{0}",N);
        long[] primes = new long[] {
            7L
        };
        Console.WriteLine(string.Format("primes:{0}",string.Join(" ",primes)));
        long[] __expected = new long[] {
            7L,
            7L
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        long[] __result = new TheKingsFactorization().getVector(N, primes);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example4()
    {
        long N = 210L;
        Console.WriteLine("N:{0}",N);
        long[] primes = new long[] {
            2L,
            5L
        };
        Console.WriteLine(string.Format("primes:{0}",string.Join(" ",primes)));
        long[] __expected = new long[] {
            2L,
            3L,
            5L,
            7L
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        long[] __result = new TheKingsFactorization().getVector(N, primes);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

    [TestMethod]
    public void Example5()
    {
        long N = 100000L;
        Console.WriteLine("N:{0}",N);
        long[] primes = new long[] {
            2L,
            2L,
            2L,
            5L,
            5L
        };
        Console.WriteLine(string.Format("primes:{0}",string.Join(" ",primes)));
        long[] __expected = new long[] {
            2L,
            2L,
            2L,
            2L,
            2L,
            5L,
            5L,
            5L,
            5L,
            5L
        };
        Console.WriteLine(string.Format("__expected:{0}",string.Join(" ",__expected)));
        long[] __result = new TheKingsFactorization().getVector(N, primes);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ",__result)));
        
            CollectionAssert.AreEquivalent(__expected, __result);
         }

}
