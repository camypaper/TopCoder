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
    public void ManualTest(int[] x, int[] y, int k)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        Console.WriteLine("k:{0}", k);
        int __result = new TheGridDivOne().find(x, y, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            -2,
            -1,
            0,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int k = 4;
        Console.WriteLine("k:{0}", k);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheGridDivOne().find(x, y, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            -1,
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            -1,
            1,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int k = 9;
        Console.WriteLine("k:{0}", k);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheGridDivOne().find(x, y, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int k = 1000;
        Console.WriteLine("k:{0}", k);
        int __expected = 1000;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheGridDivOne().find(x, y, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            1,
            0,
            0,
            -1,
            -1,
            -2,
            -2,
            -3,
            -3,
            -4,
            -4
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            -1,
            1,
            -2,
            2,
            -3,
            3,
            -4,
            4,
            -5,
            5
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int k = 47;
        Console.WriteLine("k:{0}", k);
        int __expected = 31;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheGridDivOne().find(x, y, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
