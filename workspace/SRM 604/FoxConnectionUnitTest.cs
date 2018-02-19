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
    public void ManualTest(int[] A, int[] B, string haveFox)
    {
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        Console.WriteLine("haveFox:{0}", haveFox);
        int __result = new FoxConnection().minimalDistance(A, B, haveFox);
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
        string haveFox = "YNNY";
        Console.WriteLine("haveFox:{0}", haveFox);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection().minimalDistance(A, B, haveFox);
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
        string haveFox = "NYYYY";
        Console.WriteLine("haveFox:{0}", haveFox);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection().minimalDistance(A, B, haveFox);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] A = new int[] {
            1,
            3,
            4,
            5,
            4
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            2,
            2,
            4,
            6
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        string haveFox = "YNYNYY";
        Console.WriteLine("haveFox:{0}", haveFox);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection().minimalDistance(A, B, haveFox);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] A = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9
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
            10
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        string haveFox = "YNNNYNYNNY";
        Console.WriteLine("haveFox:{0}", haveFox);
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection().minimalDistance(A, B, haveFox);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] A = new int[] {
            1,
            2,
            3,
            4,
            3,
            6,
            8,
            7
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2,
            3,
            4,
            5,
            6,
            8,
            9,
            6
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        string haveFox = "YNNYYNYYY";
        Console.WriteLine("haveFox:{0}", haveFox);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection().minimalDistance(A, B, haveFox);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] A = new int[] {
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        string haveFox = "NY";
        Console.WriteLine("haveFox:{0}", haveFox);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection().minimalDistance(A, B, haveFox);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] A = new int[] {
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        string haveFox = "NN";
        Console.WriteLine("haveFox:{0}", haveFox);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxConnection().minimalDistance(A, B, haveFox);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
