using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);    }
    public void ManualTest(int[] time, int[] cost, int budget)
    {
        Console.WriteLine(string.Format("time:{0}", string.Join(" ",time)));
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ",cost)));
        Console.WriteLine("budget:{0}", budget);
        int __result = new FarmvilleDiv2().minTime(time, cost, budget);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] time = new int[] {
            100
        };
        Console.WriteLine(string.Format("time:{0}", string.Join(" ", time)));
        int[] cost = new int[] {
            1
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int budget = 26;
        Console.WriteLine("budget:{0}", budget);
        int __expected = 74;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FarmvilleDiv2().minTime(time, cost, budget);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] time = new int[] {
            100
        };
        Console.WriteLine(string.Format("time:{0}", string.Join(" ", time)));
        int[] cost = new int[] {
            1
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int budget = 101;
        Console.WriteLine("budget:{0}", budget);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FarmvilleDiv2().minTime(time, cost, budget);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] time = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("time:{0}", string.Join(" ", time)));
        int[] cost = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int budget = 3;
        Console.WriteLine("budget:{0}", budget);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FarmvilleDiv2().minTime(time, cost, budget);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] time = new int[] {
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("time:{0}", string.Join(" ", time)));
        int[] cost = new int[] {
            5,
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int budget = 15;
        Console.WriteLine("budget:{0}", budget);
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FarmvilleDiv2().minTime(time, cost, budget);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] time = new int[] {
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100
        };
        Console.WriteLine(string.Format("time:{0}", string.Join(" ", time)));
        int[] cost = new int[] {
            2,
            4,
            6,
            8,
            10,
            1,
            3,
            5,
            7,
            9
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int budget = 5000;
        Console.WriteLine("budget:{0}", budget);
        int __expected = 50;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FarmvilleDiv2().minTime(time, cost, budget);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] time = new int[] {
            30,
            40,
            20,
            10
        };
        Console.WriteLine(string.Format("time:{0}", string.Join(" ", time)));
        int[] cost = new int[] {
            10,
            20,
            30,
            40
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int budget = 5;
        Console.WriteLine("budget:{0}", budget);
        int __expected = 100;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FarmvilleDiv2().minTime(time, cost, budget);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
