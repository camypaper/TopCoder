using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class CandleTimerEasyTest
{
    [TestMethod]
    public void Example0()
    {
        int[] A = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] len = new int[] {
            10,
            1
        };
        Console.WriteLine(string.Format("len:{0}", string.Join(" ", len)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandleTimerEasy().differentTime(A, B, len);
        Console.WriteLine("__result:{0}", __result);

        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] A = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] len = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("len:{0}", string.Join(" ", len)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandleTimerEasy().differentTime(A, B, len);
        Console.WriteLine("__result:{0}", __result);

        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] A = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] len = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("len:{0}", string.Join(" ", len)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandleTimerEasy().differentTime(A, B, len);
        Console.WriteLine("__result:{0}", __result);

        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] A = new int[] {
            0,
            1,
            1,
            2,
            3,
            3,
            2,
            4
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] len = new int[] {
            5,
            3,
            2,
            4,
            6,
            8,
            7,
            1
        };
        Console.WriteLine(string.Format("len:{0}", string.Join(" ", len)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandleTimerEasy().differentTime(A, B, len);
        Console.WriteLine("__result:{0}", __result);

        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] A = new int[] {
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] len = new int[] {
            123,
            456,
            789,
            1000
        };
        Console.WriteLine(string.Format("len:{0}", string.Join(" ", len)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandleTimerEasy().differentTime(A, B, len);
        Console.WriteLine("__result:{0}", __result);

        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] A = new int[] {
            0
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] len = new int[] {
            1000
        };
        Console.WriteLine(string.Format("len:{0}", string.Join(" ", len)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CandleTimerEasy().differentTime(A, B, len);
        Console.WriteLine("__result:{0}", __result);

        Assert.AreEqual(__expected, __result);
    }

}
