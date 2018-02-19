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
    public void ManualTest(int[] a, int k)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine("k:{0}", k);
        int __result = new CliqueParty().maxsize(a, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CliqueParty().maxsize(a, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CliqueParty().maxsize(a, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            4,
            10,
            5,
            6
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CliqueParty().maxsize(a, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            1,
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CliqueParty().maxsize(a, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] a = new int[] {
            10,
            9,
            25,
            24,
            23,
            30
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int k = 7;
        Console.WriteLine("k:{0}", k);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CliqueParty().maxsize(a, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
