using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);    }
    public void ManualTest(long x)
    {
        Console.WriteLine("x:{0}", x);
        int[] __result = new AlmostFibonacciKnapsack().getIndices(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        long x = 148L;
        Console.WriteLine("x:{0}", x);
        int[] __expected = new int[] {
            6,
            10,
            8,
            5
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new AlmostFibonacciKnapsack().getIndices(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        long x = 2L;
        Console.WriteLine("x:{0}", x);
        int[] __expected = new int[] {
            1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new AlmostFibonacciKnapsack().getIndices(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        long x = 13L;
        Console.WriteLine("x:{0}", x);
        int[] __expected = new int[] {
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new AlmostFibonacciKnapsack().getIndices(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        long x = 3L;
        Console.WriteLine("x:{0}", x);
        int[] __expected = new int[] {
            2
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new AlmostFibonacciKnapsack().getIndices(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        long x = 86267769395L;
        Console.WriteLine("x:{0}", x);
        int[] __expected = new int[] {
            3,
            14,
            15,
            9,
            26,
            53,
            5,
            8
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new AlmostFibonacciKnapsack().getIndices(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
