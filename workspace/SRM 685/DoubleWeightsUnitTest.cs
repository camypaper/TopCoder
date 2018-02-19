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
    public void ManualTest(string[] weight1, string[] weight2)
    {
        Console.WriteLine(string.Format("weight1:{0}", string.Join(" ",weight1)));
        Console.WriteLine(string.Format("weight2:{0}", string.Join(" ",weight2)));
        int __result = new DoubleWeights().minimalCost(weight1, weight2);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] weight1 = new string[] {
            "..14",
            "..94",
            "19..",
            "44.."
        };
        Console.WriteLine(string.Format("weight1:{0}", string.Join(" ", weight1)));
        string[] weight2 = new string[] {
            "..94",
            "..14",
            "91..",
            "44.."
        };
        Console.WriteLine(string.Format("weight2:{0}", string.Join(" ", weight2)));
        int __expected = 64;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DoubleWeights().minimalCost(weight1, weight2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] weight1 = new string[] {
            "..14",
            "..14",
            "11..",
            "44.."
        };
        Console.WriteLine(string.Format("weight1:{0}", string.Join(" ", weight1)));
        string[] weight2 = new string[] {
            "..94",
            "..94",
            "99..",
            "44.."
        };
        Console.WriteLine(string.Format("weight2:{0}", string.Join(" ", weight2)));
        int __expected = 36;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DoubleWeights().minimalCost(weight1, weight2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] weight1 = new string[] {
            "..",
            ".."
        };
        Console.WriteLine(string.Format("weight1:{0}", string.Join(" ", weight1)));
        string[] weight2 = new string[] {
            "..",
            ".."
        };
        Console.WriteLine(string.Format("weight2:{0}", string.Join(" ", weight2)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DoubleWeights().minimalCost(weight1, weight2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] weight1 = new string[] {
            ".....9",
            "..9...",
            ".9.9..",
            "..9.9.",
            "...9.9",
            "9...9."
        };
        Console.WriteLine(string.Format("weight1:{0}", string.Join(" ", weight1)));
        string[] weight2 = new string[] {
            ".....9",
            "..9...",
            ".9.9..",
            "..9.9.",
            "...9.9",
            "9...9."
        };
        Console.WriteLine(string.Format("weight2:{0}", string.Join(" ", weight2)));
        int __expected = 2025;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DoubleWeights().minimalCost(weight1, weight2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] weight1 = new string[] {
            ".4...1",
            "4.1...",
            ".1.1..",
            "..1.1.",
            "...1.1",
            "1...1."
        };
        Console.WriteLine(string.Format("weight1:{0}", string.Join(" ", weight1)));
        string[] weight2 = new string[] {
            ".4...1",
            "4.1...",
            ".1.1..",
            "..1.1.",
            "...1.1",
            "1...1."
        };
        Console.WriteLine(string.Format("weight2:{0}", string.Join(" ", weight2)));
        int __expected = 16;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DoubleWeights().minimalCost(weight1, weight2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
