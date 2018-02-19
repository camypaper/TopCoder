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
    public void ManualTest(int h, int[] a, int[] b)
    {
        Console.WriteLine("h:{0}", h);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        string __result = new TheKingsRoadsDiv2().getAnswer(h, a, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int h = 3;
        Console.WriteLine("h:{0}", h);
        int[] a = new int[] {
            1,
            2,
            3,
            7,
            1,
            5,
            4
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            6,
            7,
            4,
            3,
            3,
            1,
            7
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Correct";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new TheKingsRoadsDiv2().getAnswer(h, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int h = 2;
        Console.WriteLine("h:{0}", h);
        int[] a = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            2,
            1,
            3
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Incorrect";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new TheKingsRoadsDiv2().getAnswer(h, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int h = 3;
        Console.WriteLine("h:{0}", h);
        int[] a = new int[] {
            7,
            1,
            1,
            2,
            2,
            3,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            7,
            1,
            7,
            4,
            5,
            2,
            6
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Incorrect";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new TheKingsRoadsDiv2().getAnswer(h, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int h = 2;
        Console.WriteLine("h:{0}", h);
        int[] a = new int[] {
            1,
            3,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Correct";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new TheKingsRoadsDiv2().getAnswer(h, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int h = 3;
        Console.WriteLine("h:{0}", h);
        int[] a = new int[] {
            6,
            5,
            3,
            3,
            5,
            5,
            6
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            5,
            5,
            6,
            4,
            7,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Correct";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new TheKingsRoadsDiv2().getAnswer(h, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
