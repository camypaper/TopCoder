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
    public void ManualTest(int h, int[] a, int[] b)
    {
        Console.WriteLine("h:{0}", h);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        string __result = new TheKingsRoadsDiv1().getAnswer(h, a, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int h = 3;
        Console.WriteLine("h:{0}", h);
        int[] a = new int[] {
            1,
            3,
            2,
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
            5,
            4,
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
        string __result = new TheKingsRoadsDiv1().getAnswer(h, a, b);
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
            1,
            3,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            2,
            1,
            2,
            3,
            3
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Incorrect";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new TheKingsRoadsDiv1().getAnswer(h, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int h = 3;
        Console.WriteLine("h:{0}", h);
        int[] a = new int[] {
            1,
            3,
            2,
            2,
            6,
            6,
            4,
            4,
            7
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            2,
            1,
            4,
            5,
            4,
            4,
            7,
            7,
            6
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Incorrect";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new TheKingsRoadsDiv1().getAnswer(h, a, b);
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
            2,
            2,
            1,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Incorrect";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new TheKingsRoadsDiv1().getAnswer(h, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int h = 5;
        Console.WriteLine("h:{0}", h);
        int[] a = new int[] {
            6,
            15,
            29,
            28,
            7,
            13,
            13,
            23,
            28,
            13,
            30,
            27,
            14,
            4,
            14,
            19,
            27,
            20,
            20,
            19,
            10,
            15,
            7,
            7,
            19,
            29,
            4,
            24,
            10,
            23,
            30,
            6,
            24
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            9,
            22,
            30,
            20,
            26,
            25,
            8,
            7,
            24,
            21,
            27,
            31,
            4,
            28,
            29,
            6,
            16,
            1,
            17,
            10,
            3,
            12,
            30,
            18,
            14,
            23,
            19,
            21,
            5,
            13,
            15,
            2,
            11
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Correct";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new TheKingsRoadsDiv1().getAnswer(h, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int h = 2;
        Console.WriteLine("h:{0}", h);
        int[] a = new int[] {
            1,
            1,
            1,
            2,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            2,
            3,
            1,
            2,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string __expected = "Correct";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new TheKingsRoadsDiv1().getAnswer(h, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
