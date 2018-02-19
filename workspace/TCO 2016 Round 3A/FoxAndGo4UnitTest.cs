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
    public void ManualTest(int[] p)
    {
        Console.WriteLine(string.Format("p:{0}", string.Join(" ",p)));
        int __result = new FoxAndGo4().score(p);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] p = new int[] {
            0,
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndGo4().score(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] p = new int[] {
            0,
            0,
            2,
            0,
            4,
            5
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndGo4().score(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] p = new int[] {
            0,
            1,
            2,
            0,
            4,
            5,
            0,
            7,
            8
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndGo4().score(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] p = new int[] {
            0,
            0,
            1,
            1,
            2,
            2,
            3,
            3,
            4,
            4,
            5,
            5,
            6,
            6
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndGo4().score(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] p = new int[] {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30,
            31,
            32,
            33,
            34,
            35,
            36,
            37,
            38,
            39,
            40,
            41,
            42,
            43,
            44,
            45,
            46,
            47,
            48,
            49
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 48;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndGo4().score(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] p = new int[] {
            0
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndGo4().score(p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
