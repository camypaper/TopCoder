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
    public void ManualTest(int[] a, int[] b, int X)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        Console.WriteLine("X:{0}", X);
        int __result = new Moneymanager().getbest(a, b, X);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int X = 0;
        Console.WriteLine("X:{0}", X);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Moneymanager().getbest(a, b, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            5
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int X = 10;
        Console.WriteLine("X:{0}", X);
        int __expected = 61;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Moneymanager().getbest(a, b, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            4,
            4,
            6,
            6
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            2,
            2,
            3,
            3
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int X = 100;
        Console.WriteLine("X:{0}", X);
        int __expected = 726;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Moneymanager().getbest(a, b, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            30,
            13,
            28,
            59,
            26,
            62,
            48,
            75,
            6,
            69,
            94,
            51
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            4,
            6,
            4,
            5,
            4,
            3,
            1,
            5,
            6,
            5,
            2,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int X = 62;
        Console.WriteLine("X:{0}", X);
        int __expected = 22096;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Moneymanager().getbest(a, b, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
