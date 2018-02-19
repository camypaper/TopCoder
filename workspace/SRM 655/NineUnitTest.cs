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
    public void ManualTest(int N, int[] d)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        int __result = new Nine().count(N, d);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] d = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Nine().count(N, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] d = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 16;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Nine().count(N, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int[] d = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 200;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Nine().count(N, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int[] d = new int[] {
            1,
            3,
            5,
            8,
            24,
            22,
            25,
            21,
            30,
            2,
            4,
            0,
            6,
            7,
            9,
            11,
            14,
            13,
            12,
            15,
            18,
            17,
            16,
            19,
            26,
            29,
            31,
            28,
            27,
            10,
            20,
            23
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 450877328;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Nine().count(N, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int[] d = new int[] {
            31,
            31,
            31,
            31,
            31
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int __expected = 11112;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Nine().count(N, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
