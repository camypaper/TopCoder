using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);    }
    public void ManualTest(int[] atLeast, int d)
    {
        Console.WriteLine(string.Format("atLeast:{0}", string.Join(" ",atLeast)));
        Console.WriteLine("d:{0}", d);
        int[] __result = new BearChairs().findPositions(atLeast, d);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int[] atLeast = new int[] {
            1,
            21,
            11,
            7
        };
        Console.WriteLine(string.Format("atLeast:{0}", string.Join(" ", atLeast)));
        int d = 10;
        Console.WriteLine("d:{0}", d);
        int[] __expected = new int[] {
            1,
            21,
            11,
            31
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearChairs().findPositions(atLeast, d);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int[] atLeast = new int[] {
            1,
            21,
            11,
            7
        };
        Console.WriteLine(string.Format("atLeast:{0}", string.Join(" ", atLeast)));
        int d = 11;
        Console.WriteLine("d:{0}", d);
        int[] __expected = new int[] {
            1,
            21,
            32,
            43
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearChairs().findPositions(atLeast, d);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int[] atLeast = new int[] {
            1000000,
            1000000,
            1000000,
            1
        };
        Console.WriteLine(string.Format("atLeast:{0}", string.Join(" ", atLeast)));
        int d = 1000000;
        Console.WriteLine("d:{0}", d);
        int[] __expected = new int[] {
            1000000,
            2000000,
            3000000,
            4000000
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearChairs().findPositions(atLeast, d);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int[] atLeast = new int[] {
            1000000,
            1000000,
            1000000,
            1
        };
        Console.WriteLine(string.Format("atLeast:{0}", string.Join(" ", atLeast)));
        int d = 999999;
        Console.WriteLine("d:{0}", d);
        int[] __expected = new int[] {
            1000000,
            1999999,
            2999998,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearChairs().findPositions(atLeast, d);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
