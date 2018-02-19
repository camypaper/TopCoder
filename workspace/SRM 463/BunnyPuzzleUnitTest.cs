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
    public void ManualTest(int[] bunnies)
    {
        Console.WriteLine(string.Format("bunnies:{0}", string.Join(" ",bunnies)));
        int __result = new BunnyPuzzle().theCount(bunnies);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] bunnies = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("bunnies:{0}", string.Join(" ", bunnies)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BunnyPuzzle().theCount(bunnies);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] bunnies = new int[] {
            -1,
            0,
            1
        };
        Console.WriteLine(string.Format("bunnies:{0}", string.Join(" ", bunnies)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BunnyPuzzle().theCount(bunnies);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] bunnies = new int[] {
            0,
            1,
            3
        };
        Console.WriteLine(string.Format("bunnies:{0}", string.Join(" ", bunnies)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BunnyPuzzle().theCount(bunnies);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] bunnies = new int[] {
            -677,
            -45,
            -2,
            3,
            8,
            29,
            384,
            867
        };
        Console.WriteLine(string.Format("bunnies:{0}", string.Join(" ", bunnies)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BunnyPuzzle().theCount(bunnies);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] bunnies = new int[] {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9
        };
        Console.WriteLine(string.Format("bunnies:{0}", string.Join(" ", bunnies)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BunnyPuzzle().theCount(bunnies);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
