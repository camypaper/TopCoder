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
    public void ManualTest(int[] ways, int[] valueRemoved, int[] numRemoved)
    {
        Console.WriteLine(string.Format("ways:{0}", string.Join(" ",ways)));
        Console.WriteLine(string.Format("valueRemoved:{0}", string.Join(" ",valueRemoved)));
        Console.WriteLine(string.Format("numRemoved:{0}", string.Join(" ",numRemoved)));
        int[] __result = new ChangingChange().countWays(ways, valueRemoved, numRemoved);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int[] ways = new int[] {
            1,
            4,
            6
        };
        Console.WriteLine(string.Format("ways:{0}", string.Join(" ", ways)));
        int[] valueRemoved = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("valueRemoved:{0}", string.Join(" ", valueRemoved)));
        int[] numRemoved = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("numRemoved:{0}", string.Join(" ", numRemoved)));
        int[] __expected = new int[] {
            3,
            1,
            0
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ChangingChange().countWays(ways, valueRemoved, numRemoved);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int[] ways = new int[] {
            1,
            2,
            1,
            0,
            0,
            0,
            0,
            0,
            7
        };
        Console.WriteLine(string.Format("ways:{0}", string.Join(" ", ways)));
        int[] valueRemoved = new int[] {
            8,
            8,
            1,
            1
        };
        Console.WriteLine(string.Format("valueRemoved:{0}", string.Join(" ", valueRemoved)));
        int[] numRemoved = new int[] {
            1,
            7,
            1,
            2
        };
        Console.WriteLine(string.Format("numRemoved:{0}", string.Join(" ", numRemoved)));
        int[] __expected = new int[] {
            6,
            0,
            7,
            7
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ChangingChange().countWays(ways, valueRemoved, numRemoved);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int[] ways = new int[] {
            1,
            2,
            3,
            6,
            9,
            14
        };
        Console.WriteLine(string.Format("ways:{0}", string.Join(" ", ways)));
        int[] valueRemoved = new int[] {
            1,
            2,
            3,
            4,
            5,
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("valueRemoved:{0}", string.Join(" ", valueRemoved)));
        int[] numRemoved = new int[] {
            1,
            1,
            1,
            1,
            1,
            2,
            2,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("numRemoved:{0}", string.Join(" ", numRemoved)));
        int[] __expected = new int[] {
            9,
            10,
            11,
            12,
            13,
            6,
            8,
            8,
            10,
            12
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ChangingChange().countWays(ways, valueRemoved, numRemoved);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int[] ways = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("ways:{0}", string.Join(" ", ways)));
        int[] valueRemoved = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("valueRemoved:{0}", string.Join(" ", valueRemoved)));
        int[] numRemoved = new int[] {
            1,
            1000000
        };
        Console.WriteLine(string.Format("numRemoved:{0}", string.Join(" ", numRemoved)));
        int[] __expected = new int[] {
            1000000006,
            999000007
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ChangingChange().countWays(ways, valueRemoved, numRemoved);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        int[] ways = new int[] {
            1,
            2,
            3,
            6,
            9,
            14
        };
        Console.WriteLine(string.Format("ways:{0}", string.Join(" ", ways)));
        int[] valueRemoved = new int[] {
            1,
            3,
            5
        };
        Console.WriteLine(string.Format("valueRemoved:{0}", string.Join(" ", valueRemoved)));
        int[] numRemoved = new int[] {
            1000000,
            4,
            2
        };
        Console.WriteLine(string.Format("numRemoved:{0}", string.Join(" ", numRemoved)));
        int[] __expected = new int[] {
            34955525,
            2,
            12
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ChangingChange().countWays(ways, valueRemoved, numRemoved);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
