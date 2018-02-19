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
    public void ManualTest(int[] permutation)
    {
        Console.WriteLine(string.Format("permutation:{0}", string.Join(" ",permutation)));
        int __result = new ShufflingCardsDiv1().shuffle(permutation);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] permutation = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("permutation:{0}", string.Join(" ", permutation)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ShufflingCardsDiv1().shuffle(permutation);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] permutation = new int[] {
            1,
            4,
            3,
            2
        };
        Console.WriteLine(string.Format("permutation:{0}", string.Join(" ", permutation)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ShufflingCardsDiv1().shuffle(permutation);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] permutation = new int[] {
            6,
            3,
            5,
            2,
            4,
            1
        };
        Console.WriteLine(string.Format("permutation:{0}", string.Join(" ", permutation)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ShufflingCardsDiv1().shuffle(permutation);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] permutation = new int[] {
            8,
            5,
            4,
            9,
            1,
            7,
            6,
            10,
            3,
            2
        };
        Console.WriteLine(string.Format("permutation:{0}", string.Join(" ", permutation)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ShufflingCardsDiv1().shuffle(permutation);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] permutation = new int[] {
            9,
            1,
            7,
            2,
            10,
            3,
            6,
            4,
            8,
            5
        };
        Console.WriteLine(string.Format("permutation:{0}", string.Join(" ", permutation)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ShufflingCardsDiv1().shuffle(permutation);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
