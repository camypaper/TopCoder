using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);    }
    public void ManualTest(int[] A, int[] B, int K)
    {
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        Console.WriteLine("K:{0}", K);
        double __result = new GerrymanderEasy().getmax(A, B, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] A = new int[] {
            5,
            1,
            2,
            7
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            4,
            0,
            2,
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        double __expected = 0.75;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new GerrymanderEasy().getmax(A, B, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] A = new int[] {
            12,
            34,
            56,
            78,
            90
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int K = 1;
        Console.WriteLine("K:{0}", K);
        double __expected = 0.08333333333333333;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new GerrymanderEasy().getmax(A, B, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] A = new int[] {
            10000,
            10000,
            10000,
            10000,
            10000,
            10000,
            10000,
            10000,
            10000,
            10000
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            3,
            1,
            4,
            1,
            5,
            9,
            2,
            6,
            5,
            3
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int K = 5;
        Console.WriteLine("K:{0}", K);
        double __expected = 5.4E-4;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new GerrymanderEasy().getmax(A, B, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] A = new int[] {
            123,
            4,
            46,
            88,
            22,
            34,
            564,
            87,
            56,
            311,
            886
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int K = 1;
        Console.WriteLine("K:{0}", K);
        double __expected = 0.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new GerrymanderEasy().getmax(A, B, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
