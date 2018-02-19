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
    public void ManualTest(int N, int low, int high, int[] pitch)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("low:{0}", low);
        Console.WriteLine("high:{0}", high);
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ",pitch)));
        int __result = new Singing().solve(N, low, high, pitch);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int low = 2;
        Console.WriteLine("low:{0}", low);
        int high = 2;
        Console.WriteLine("high:{0}", high);
        int[] pitch = new int[] {
            1,
            2,
            3,
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ", pitch)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Singing().solve(N, low, high, pitch);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 10;
        Console.WriteLine("N:{0}", N);
        int low = 3;
        Console.WriteLine("low:{0}", low);
        int high = 7;
        Console.WriteLine("high:{0}", high);
        int[] pitch = new int[] {
            4,
            4,
            5,
            5,
            6,
            5,
            3,
            6
        };
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ", pitch)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Singing().solve(N, low, high, pitch);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 6;
        Console.WriteLine("N:{0}", N);
        int low = 2;
        Console.WriteLine("low:{0}", low);
        int high = 5;
        Console.WriteLine("high:{0}", high);
        int[] pitch = new int[] {
            5,
            3,
            1,
            6,
            4,
            2
        };
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ", pitch)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Singing().solve(N, low, high, pitch);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 10;
        Console.WriteLine("N:{0}", N);
        int low = 4;
        Console.WriteLine("low:{0}", low);
        int high = 5;
        Console.WriteLine("high:{0}", high);
        int[] pitch = new int[] {
            1,
            4,
            3,
            5,
            2,
            5,
            7,
            5,
            9
        };
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ", pitch)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Singing().solve(N, low, high, pitch);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 100;
        Console.WriteLine("N:{0}", N);
        int low = 20;
        Console.WriteLine("low:{0}", low);
        int high = 80;
        Console.WriteLine("high:{0}", high);
        int[] pitch = new int[] {
            2,
            27,
            3,
            53,
            53,
            52,
            52,
            60,
            85,
            89,
            100,
            53,
            60,
            2,
            3,
            53,
            100,
            89,
            40,
            42,
            2,
            53,
            2,
            85
        };
        Console.WriteLine(string.Format("pitch:{0}", string.Join(" ", pitch)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Singing().solve(N, low, high, pitch);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
