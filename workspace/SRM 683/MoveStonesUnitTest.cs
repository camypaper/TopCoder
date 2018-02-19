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
    public void ManualTest(int[] a, int[] b)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        long __result = new MoveStones().get(a, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            12
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            12
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MoveStones().get(a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            10
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            9
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        long __expected = -1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MoveStones().get(a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            0,
            5
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            5,
            0
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        long __expected = 5L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MoveStones().get(a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            3,
            1,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MoveStones().get(a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] a = new int[] {
            1,
            0,
            1,
            1,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            0,
            3,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        long __expected = 4L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MoveStones().get(a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] a = new int[] {
            1000000000,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            0,
            0,
            0,
            1000000000,
            0,
            0
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        long __expected = 3000000000L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MoveStones().get(a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
