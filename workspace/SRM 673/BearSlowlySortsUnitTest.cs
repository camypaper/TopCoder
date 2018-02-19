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
    public void ManualTest(int[] w)
    {
        Console.WriteLine(string.Format("w:{0}", string.Join(" ",w)));
        int __result = new BearSlowlySorts().minMoves(w);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] w = new int[] {
            2,
            6,
            8,
            5
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearSlowlySorts().minMoves(w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] w = new int[] {
            4,
            3,
            1,
            6,
            2,
            5
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearSlowlySorts().minMoves(w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] w = new int[] {
            93,
            155,
            178,
            205,
            213,
            242,
            299,
            307,
            455,
            470,
            514,
            549,
            581,
            617,
            677
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearSlowlySorts().minMoves(w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] w = new int[] {
            50,
            20,
            30,
            40,
            10
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearSlowlySorts().minMoves(w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] w = new int[] {
            234,
            462,
            715,
            596,
            906,
            231,
            278,
            223,
            767,
            925,
            9,
            526,
            369,
            319,
            241,
            354,
            317,
            880,
            5,
            696
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearSlowlySorts().minMoves(w);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
