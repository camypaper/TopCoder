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
    public void ManualTest(int[] superior, int[] training)
    {
        Console.WriteLine(string.Format("superior:{0}", string.Join(" ",superior)));
        Console.WriteLine(string.Format("training:{0}", string.Join(" ",training)));
        int __result = new GoodCompanyDivOne().minimumCost(superior, training);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] superior = new int[] {
            -1
        };
        Console.WriteLine(string.Format("superior:{0}", string.Join(" ", superior)));
        int[] training = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("training:{0}", string.Join(" ", training)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GoodCompanyDivOne().minimumCost(superior, training);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] superior = new int[] {
            -1,
            0,
            0
        };
        Console.WriteLine(string.Format("superior:{0}", string.Join(" ", superior)));
        int[] training = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("training:{0}", string.Join(" ", training)));
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GoodCompanyDivOne().minimumCost(superior, training);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] superior = new int[] {
            -1,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("superior:{0}", string.Join(" ", superior)));
        int[] training = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("training:{0}", string.Join(" ", training)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GoodCompanyDivOne().minimumCost(superior, training);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] superior = new int[] {
            -1,
            0,
            0,
            2,
            2,
            2,
            1,
            1,
            6,
            0,
            5,
            4,
            11,
            10,
            3,
            6,
            11,
            7,
            0,
            2,
            13,
            14,
            2,
            10,
            9,
            11,
            22,
            10,
            3
        };
        Console.WriteLine(string.Format("superior:{0}", string.Join(" ", superior)));
        int[] training = new int[] {
            4,
            2,
            6,
            6,
            8,
            3,
            3,
            1,
            1,
            5,
            8,
            6,
            8,
            2,
            4
        };
        Console.WriteLine(string.Format("training:{0}", string.Join(" ", training)));
        int __expected = 71;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GoodCompanyDivOne().minimumCost(superior, training);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
