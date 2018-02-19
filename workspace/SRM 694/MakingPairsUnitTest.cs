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
    public void ManualTest(int[] card)
    {
        Console.WriteLine(string.Format("card:{0}", string.Join(" ",card)));
        int __result = new MakingPairs().get(card);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] card = new int[] {
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("card:{0}", string.Join(" ", card)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MakingPairs().get(card);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] card = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("card:{0}", string.Join(" ", card)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MakingPairs().get(card);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] card = new int[] {
            5
        };
        Console.WriteLine(string.Format("card:{0}", string.Join(" ", card)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MakingPairs().get(card);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] card = new int[] {
            43,
            23,
            10,
            39,
            39,
            22,
            22,
            0,
            3,
            4,
            3,
            2
        };
        Console.WriteLine(string.Format("card:{0}", string.Join(" ", card)));
        int __expected = 102;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MakingPairs().get(card);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] card = new int[] {
            0
        };
        Console.WriteLine(string.Format("card:{0}", string.Join(" ", card)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MakingPairs().get(card);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
