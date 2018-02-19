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
    public void ManualTest(int N, int[] A, int[] B, int[] D, long T)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        Console.WriteLine(string.Format("D:{0}", string.Join(" ",D)));
        Console.WriteLine("T:{0}", T);
        string __result = new LongLongTripDiv1().isAble(N, A, B, D, T);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] D = new int[] {
            7,
            6,
            5
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        long T = 11L;
        Console.WriteLine("T:{0}", T);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LongLongTripDiv1().isAble(N, A, B, D, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] D = new int[] {
            7,
            6,
            5
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        long T = 25L;
        Console.WriteLine("T:{0}", T);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LongLongTripDiv1().isAble(N, A, B, D, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            0
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] D = new int[] {
            1
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        long T = 9L;
        Console.WriteLine("T:{0}", T);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LongLongTripDiv1().isAble(N, A, B, D, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            0
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] D = new int[] {
            1
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        long T = 1000000000000000000L;
        Console.WriteLine("T:{0}", T);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LongLongTripDiv1().isAble(N, A, B, D, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] D = new int[] {
            10,
            10,
            10
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        long T = 1000L;
        Console.WriteLine("T:{0}", T);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LongLongTripDiv1().isAble(N, A, B, D, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int N = 9;
        Console.WriteLine("N:{0}", N);
        int[] A = new int[] {
            4,
            8,
            5,
            8,
            3,
            6,
            2,
            6,
            7,
            6,
            6
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            7,
            1,
            5,
            1,
            3,
            1,
            1,
            5,
            4,
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int[] D = new int[] {
            6580,
            8822,
            1968,
            673,
            1394,
            9337,
            5486,
            1746,
            5229,
            4092,
            195
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        long T = 937186357646035002L;
        Console.WriteLine("T:{0}", T);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LongLongTripDiv1().isAble(N, A, B, D, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
