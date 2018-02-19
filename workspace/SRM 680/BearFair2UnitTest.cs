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
    public void ManualTest(int n, int b, int[] upTo, int[] quantity)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ",upTo)));
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ",quantity)));
        string __result = new BearFair2().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int b = 5;
        Console.WriteLine("b:{0}", b);
        int[] upTo = new int[] {
            2,
            3
        };
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ", upTo)));
        int[] quantity = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ", quantity)));
        string __expected = "fair";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearFair2().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int b = 1000;
        Console.WriteLine("b:{0}", b);
        int[] upTo = new int[] {
            500,
            100,
            950
        };
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ", upTo)));
        int[] quantity = new int[] {
            4,
            3,
            6
        };
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ", quantity)));
        string __expected = "fair";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearFair2().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int b = 20;
        Console.WriteLine("b:{0}", b);
        int[] upTo = new int[] {
            5,
            19,
            10
        };
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ", upTo)));
        int[] quantity = new int[] {
            0,
            3,
            2
        };
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ", quantity)));
        string __expected = "unfair";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearFair2().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int b = 6;
        Console.WriteLine("b:{0}", b);
        int[] upTo = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ", upTo)));
        int[] quantity = new int[] {
            1,
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ", quantity)));
        string __expected = "unfair";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearFair2().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 48;
        Console.WriteLine("n:{0}", n);
        int b = 1000;
        Console.WriteLine("b:{0}", b);
        int[] upTo = new int[] {
            38,
            450,
            202,
            685,
            971,
            661,
            946,
            226,
            901,
            353,
            12,
            937,
            655,
            108,
            31,
            908,
            845,
            908,
            981,
            896,
            296,
            987,
            77,
            790,
            679,
            152,
            412,
            492,
            286,
            54,
            214,
            651,
            59,
            189,
            107,
            445,
            728,
            327,
            438,
            523,
            527,
            663,
            825,
            67,
            523,
            400,
            65,
            892,
            587,
            995
        };
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ", upTo)));
        int[] quantity = new int[] {
            1,
            19,
            8,
            32,
            48,
            31,
            48,
            8,
            43,
            13,
            0,
            46,
            30,
            8,
            1,
            45,
            42,
            45,
            48,
            43,
            13,
            48,
            6,
            40,
            32,
            8,
            17,
            20,
            13,
            3,
            8,
            30,
            3,
            8,
            8,
            19,
            37,
            13,
            19,
            21,
            21,
            31,
            41,
            4,
            21,
            16,
            4,
            43,
            23,
            48
        };
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ", quantity)));
        string __expected = "fair";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearFair2().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int b = 100;
        Console.WriteLine("b:{0}", b);
        int[] upTo = new int[] {
            40,
            60
        };
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ", upTo)));
        int[] quantity = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ", quantity)));
        string __expected = "unfair";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearFair2().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
