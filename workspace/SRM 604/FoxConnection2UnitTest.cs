using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);    }
    public void ManualTest(int[] A, int[] B, int k)
    {
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        Console.WriteLine("k:{0}", k);
        int __result = new FoxConnection2().ways(A, B, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] A = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection2().ways(A, B, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] A = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection2().ways(A, B, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] A = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection2().ways(A, B, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] A = new int[] {
            1,
            2,
            2,
            4,
            4
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection2().ways(A, B, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] A = new int[] {
            1,
            2,
            2,
            4,
            4
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int k = 5;
        Console.WriteLine("k:{0}", k);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection2().ways(A, B, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] A = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
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
            40
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int k = 20;
        Console.WriteLine("k:{0}", k);
        int __expected = 923263934;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection2().ways(A, B, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] A = new int[] {
            2
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection2().ways(A, B, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
