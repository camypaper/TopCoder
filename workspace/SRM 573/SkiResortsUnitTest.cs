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
    public void ManualTest(string[] road, int[] altitude)
    {
        Console.WriteLine(string.Format("road:{0}", string.Join(" ",road)));
        Console.WriteLine(string.Format("altitude:{0}", string.Join(" ",altitude)));
        long __result = new SkiResorts().minCost(road, altitude);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] road = new string[] {
            "NYN",
            "YNY",
            "NYN"
        };
        Console.WriteLine(string.Format("road:{0}", string.Join(" ", road)));
        int[] altitude = new int[] {
            30,
            20,
            10
        };
        Console.WriteLine(string.Format("altitude:{0}", string.Join(" ", altitude)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new SkiResorts().minCost(road, altitude);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] road = new string[] {
            "NY",
            "YN"
        };
        Console.WriteLine(string.Format("road:{0}", string.Join(" ", road)));
        int[] altitude = new int[] {
            10,
            20
        };
        Console.WriteLine(string.Format("altitude:{0}", string.Join(" ", altitude)));
        long __expected = 10L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new SkiResorts().minCost(road, altitude);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] road = new string[] {
            "NYN",
            "YNN",
            "NNN"
        };
        Console.WriteLine(string.Format("road:{0}", string.Join(" ", road)));
        int[] altitude = new int[] {
            573,
            573,
            573
        };
        Console.WriteLine(string.Format("altitude:{0}", string.Join(" ", altitude)));
        long __expected = -1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new SkiResorts().minCost(road, altitude);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] road = new string[] {
            "NNYNNYYYNN",
            "NNNNYNYNNN",
            "YNNNNYYNNN",
            "NNNNNNYNYY",
            "NYNNNNNNYY",
            "YNYNNNNYNN",
            "YYYYNNNYNN",
            "YNNNNYYNNN",
            "NNNYYNNNNN",
            "NNNYYNNNNN"
        };
        Console.WriteLine(string.Format("road:{0}", string.Join(" ", road)));
        int[] altitude = new int[] {
            7,
            4,
            13,
            2,
            8,
            1,
            8,
            15,
            5,
            15
        };
        Console.WriteLine(string.Format("altitude:{0}", string.Join(" ", altitude)));
        long __expected = 12L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new SkiResorts().minCost(road, altitude);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
