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
    public void ManualTest(int[] stones)
    {
        Console.WriteLine(string.Format("stones:{0}", string.Join(" ",stones)));
        int __result = new GameOfStones().count(stones);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] stones = new int[] {
            7,
            15,
            9,
            5
        };
        Console.WriteLine(string.Format("stones:{0}", string.Join(" ", stones)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GameOfStones().count(stones);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] stones = new int[] {
            10,
            16
        };
        Console.WriteLine(string.Format("stones:{0}", string.Join(" ", stones)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GameOfStones().count(stones);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] stones = new int[] {
            2,
            8,
            4
        };
        Console.WriteLine(string.Format("stones:{0}", string.Join(" ", stones)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GameOfStones().count(stones);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] stones = new int[] {
            17
        };
        Console.WriteLine(string.Format("stones:{0}", string.Join(" ", stones)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GameOfStones().count(stones);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] stones = new int[] {
            10,
            15,
            20,
            12,
            1,
            20
        };
        Console.WriteLine(string.Format("stones:{0}", string.Join(" ", stones)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GameOfStones().count(stones);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
