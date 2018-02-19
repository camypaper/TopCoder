using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int[] edges = Scanner.In.int_array();
        Console.WriteLine(string.Format("edges:{0}", string.Join(" ",edges)));
        int[] costs = Scanner.In.int_array();
        Console.WriteLine(string.Format("costs:{0}", string.Join(" ",costs)));
        int __result = new MaxMinTreeGame().findend(edges, costs);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] edges, int[] costs)
    {
                        Console.WriteLine(string.Format("edges:{0}", string.Join(" ",edges)));
                        Console.WriteLine(string.Format("costs:{0}", string.Join(" ",costs)));
                int __result = new MaxMinTreeGame().findend(edges, costs);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] edges = new int[] {
            0
        };
        Console.WriteLine(string.Format("edges:{0}", string.Join(" ", edges)));
        int[] costs = new int[] {
            4,
            6
        };
        Console.WriteLine(string.Format("costs:{0}", string.Join(" ", costs)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MaxMinTreeGame().findend(edges, costs);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] edges = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("edges:{0}", string.Join(" ", edges)));
        int[] costs = new int[] {
            4,
            6,
            5
        };
        Console.WriteLine(string.Format("costs:{0}", string.Join(" ", costs)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MaxMinTreeGame().findend(edges, costs);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] edges = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("edges:{0}", string.Join(" ", edges)));
        int[] costs = new int[] {
            0,
            1,
            0,
            1,
            0
        };
        Console.WriteLine(string.Format("costs:{0}", string.Join(" ", costs)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MaxMinTreeGame().findend(edges, costs);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] edges = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("edges:{0}", string.Join(" ", edges)));
        int[] costs = new int[] {
            5,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("costs:{0}", string.Join(" ", costs)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MaxMinTreeGame().findend(edges, costs);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] edges = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("edges:{0}", string.Join(" ", edges)));
        int[] costs = new int[] {
            3,
            2,
            5
        };
        Console.WriteLine(string.Format("costs:{0}", string.Join(" ", costs)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MaxMinTreeGame().findend(edges, costs);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
