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
    public void ManualTest(int n, int b, int[] upTo, int[] quantity)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ",upTo)));
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ",quantity)));
        string __result = new BearFair().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int b = 6;
        Console.WriteLine("b:{0}", b);
        int[] upTo = new int[] {
            3,
            6
        };
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ", upTo)));
        int[] quantity = new int[] {
            2,
            4
        };
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ", quantity)));
        string __expected = "fair";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearFair().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int b = 6;
        Console.WriteLine("b:{0}", b);
        int[] upTo = new int[] {
            3,
            6
        };
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ", upTo)));
        int[] quantity = new int[] {
            2,
            3
        };
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ", quantity)));
        string __expected = "unfair";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearFair().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int b = 6;
        Console.WriteLine("b:{0}", b);
        int[] upTo = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ", upTo)));
        int[] quantity = new int[] {
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ", quantity)));
        string __expected = "unfair";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearFair().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 50;
        Console.WriteLine("n:{0}", n);
        int b = 1000;
        Console.WriteLine("b:{0}", b);
        int[] upTo = new int[] {
            736,
            205,
            264,
            235,
            273,
            40,
            901,
            37,
            900,
            424,
            122,
            517,
            820,
            402,
            669,
            279,
            455,
            921,
            774,
            923,
            107,
            936,
            484,
            171,
            248,
            186,
            970,
            231,
            321,
            902,
            606,
            24,
            451,
            585,
            823,
            270,
            361,
            292,
            128,
            521,
            689,
            683,
            270,
            726,
            980,
            652,
            996,
            909,
            196,
            357
        };
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ", upTo)));
        int[] quantity = new int[] {
            35,
            9,
            9,
            9,
            9,
            3,
            46,
            3,
            46,
            18,
            7,
            25,
            39,
            18,
            32,
            9,
            20,
            49,
            37,
            49,
            7,
            49,
            24,
            8,
            9,
            8,
            49,
            9,
            12,
            46,
            29,
            2,
            20,
            29,
            39,
            9,
            16,
            11,
            7,
            27,
            33,
            32,
            9,
            34,
            49,
            32,
            50,
            47,
            8,
            16
        };
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ", quantity)));
        string __expected = "fair";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearFair().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int b = 1000;
        Console.WriteLine("b:{0}", b);
        int[] upTo = new int[] {
            400,
            600
        };
        Console.WriteLine(string.Format("upTo:{0}", string.Join(" ", upTo)));
        int[] quantity = new int[] {
            4,
            0
        };
        Console.WriteLine(string.Format("quantity:{0}", string.Join(" ", quantity)));
        string __expected = "unfair";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearFair().isFair(n, b, upTo, quantity);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
