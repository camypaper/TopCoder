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
    public void ManualTest(string[] roads)
    {
        Console.WriteLine(string.Format("roads:{0}", string.Join(" ",roads)));
        int __result = new HamiltonPath().countPaths(roads);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] roads = new string[] {
            "NYN",
            "YNN",
            "NNN"
        };
        Console.WriteLine(string.Format("roads:{0}", string.Join(" ", roads)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HamiltonPath().countPaths(roads);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] roads = new string[] {
            "NYYY",
            "YNNN",
            "YNNN",
            "YNNN"
        };
        Console.WriteLine(string.Format("roads:{0}", string.Join(" ", roads)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HamiltonPath().countPaths(roads);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] roads = new string[] {
            "NYY",
            "YNY",
            "YYN"
        };
        Console.WriteLine(string.Format("roads:{0}", string.Join(" ", roads)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HamiltonPath().countPaths(roads);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] roads = new string[] {
            "NNNNNY",
            "NNNNYN",
            "NNNNYN",
            "NNNNNN",
            "NYYNNN",
            "YNNNNN"
        };
        Console.WriteLine(string.Format("roads:{0}", string.Join(" ", roads)));
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HamiltonPath().countPaths(roads);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
