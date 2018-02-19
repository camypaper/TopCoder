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
    public void ManualTest(int N, int[] x, int[] t)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
        int __result = new RailroadSwitchOperator().minEnergy(N, x, t);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] x = new int[] {
            1,
            2,
            1,
            2,
            1,
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] t = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RailroadSwitchOperator().minEnergy(N, x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int[] x = new int[] {
            1,
            4,
            4,
            4,
            4,
            4,
            4,
            4,
            4,
            4
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] t = new int[] {
            1,
            2,
            4,
            8,
            16,
            32,
            64,
            128,
            256,
            512
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RailroadSwitchOperator().minEnergy(N, x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 32;
        Console.WriteLine("N:{0}", N);
        int[] x = new int[] {
            2,
            4,
            6,
            8,
            10,
            12,
            14,
            16,
            18,
            20,
            22,
            24,
            26,
            28,
            30,
            32,
            1,
            3,
            5,
            7,
            9,
            11,
            13,
            15,
            17,
            19,
            21,
            23,
            25,
            27,
            29,
            31
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] t = new int[] {
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
            32
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 20;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RailroadSwitchOperator().minEnergy(N, x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 131072;
        Console.WriteLine("N:{0}", N);
        int[] x = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] t = new int[] {
            10,
            300,
            500,
            676,
            800,
            950,
            1000
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RailroadSwitchOperator().minEnergy(N, x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 1024;
        Console.WriteLine("N:{0}", N);
        int[] x = new int[] {
            1,
            1024,
            2,
            512,
            4,
            256,
            8,
            128,
            16,
            64,
            32
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] t = new int[] {
            1,
            2,
            3,
            5,
            8,
            13,
            21,
            34,
            55,
            89,
            144
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RailroadSwitchOperator().minEnergy(N, x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
