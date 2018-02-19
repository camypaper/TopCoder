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
    public void ManualTest(int[] road)
    {
        Console.WriteLine(string.Format("road:{0}", string.Join(" ",road)));
        int __result = new SuccessfulMerger().minimumMergers(road);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] road = new int[] {
            2,
            2,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("road:{0}", string.Join(" ", road)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SuccessfulMerger().minimumMergers(road);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] road = new int[] {
            3,
            4,
            5,
            4,
            5,
            3
        };
        Console.WriteLine(string.Format("road:{0}", string.Join(" ", road)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SuccessfulMerger().minimumMergers(road);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] road = new int[] {
            1,
            0,
            1,
            0,
            0,
            0,
            1,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("road:{0}", string.Join(" ", road)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SuccessfulMerger().minimumMergers(road);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] road = new int[] {
            1,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("road:{0}", string.Join(" ", road)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SuccessfulMerger().minimumMergers(road);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] road = new int[] {
            31,
            19,
            0,
            15,
            30,
            32,
            15,
            24,
            0,
            20,
            40,
            1,
            22,
            21,
            39,
            28,
            0,
            23,
            15,
            5,
            19,
            22,
            6,
            32,
            8,
            38,
            35,
            30,
            4,
            28,
            32,
            18,
            18,
            9,
            22,
            41,
            20,
            18,
            6,
            25,
            41,
            34,
            4
        };
        Console.WriteLine(string.Format("road:{0}", string.Join(" ", road)));
        int __expected = 25;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SuccessfulMerger().minimumMergers(road);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] road = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("road:{0}", string.Join(" ", road)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SuccessfulMerger().minimumMergers(road);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
