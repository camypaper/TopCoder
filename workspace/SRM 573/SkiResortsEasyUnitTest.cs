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
    public void ManualTest(int[] altitude)
    {
        Console.WriteLine(string.Format("altitude:{0}", string.Join(" ",altitude)));
        int __result = new SkiResortsEasy().minCost(altitude);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] altitude = new int[] {
            30,
            20,
            20,
            10
        };
        Console.WriteLine(string.Format("altitude:{0}", string.Join(" ", altitude)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SkiResortsEasy().minCost(altitude);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] altitude = new int[] {
            5,
            7,
            3
        };
        Console.WriteLine(string.Format("altitude:{0}", string.Join(" ", altitude)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SkiResortsEasy().minCost(altitude);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] altitude = new int[] {
            6,
            8,
            5,
            4,
            7,
            4,
            2,
            3,
            1
        };
        Console.WriteLine(string.Format("altitude:{0}", string.Join(" ", altitude)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SkiResortsEasy().minCost(altitude);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] altitude = new int[] {
            749,
            560,
            921,
            166,
            757,
            818,
            228,
            584,
            366,
            88
        };
        Console.WriteLine(string.Format("altitude:{0}", string.Join(" ", altitude)));
        int __expected = 2284;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SkiResortsEasy().minCost(altitude);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] altitude = new int[] {
            712,
            745,
            230,
            200,
            648,
            440,
            115,
            913,
            627,
            621,
            186,
            222,
            741,
            954,
            581,
            193,
            266,
            320,
            798,
            745
        };
        Console.WriteLine(string.Format("altitude:{0}", string.Join(" ", altitude)));
        int __expected = 6393;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SkiResortsEasy().minCost(altitude);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
