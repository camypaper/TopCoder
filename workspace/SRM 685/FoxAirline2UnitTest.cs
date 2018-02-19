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
    public void ManualTest(int n, int[] a, int[] b)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        string __result = new FoxAirline2().isPossible(n, a, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            0,
            0,
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            2,
            3,
            3
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAirline2().isPossible(n, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            0,
            0,
            0,
            1,
            1,
            1,
            2,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4,
            2,
            3,
            4,
            3,
            4,
            4,
            5
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAirline2().isPossible(n, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            0,
            0,
            1,
            1,
            2,
            2,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            4,
            2,
            4,
            3,
            4,
            4
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAirline2().isPossible(n, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            0,
            0
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAirline2().isPossible(n, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 10;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            3,
            3,
            3,
            3,
            3,
            3,
            4,
            4,
            4,
            4,
            4,
            5,
            5,
            5,
            5,
            6,
            6,
            6,
            7,
            7,
            8
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            4,
            5,
            6,
            7,
            8,
            9,
            5,
            6,
            7,
            8,
            9,
            6,
            7,
            8,
            9,
            7,
            8,
            9,
            8,
            9,
            9
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAirline2().isPossible(n, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new FoxAirline2().isPossible(n, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
