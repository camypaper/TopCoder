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
    public void ManualTest(int[] x, int[] y)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        long __result = new FoxConnection3().minimalSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            0,
            0,
            1,
            -2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            -1,
            0,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxConnection3().minimalSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxConnection3().minimalSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            -123456789,
            -58585858,
            -47474747,
            123,
            456,
            789012345
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 1018530309L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxConnection3().minimalSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            1,
            7,
            3,
            5,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            2,
            7,
            5,
            3,
            7
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 12L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxConnection3().minimalSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            -3,
            0,
            1,
            -2,
            3,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            2,
            -3,
            0,
            1,
            -1,
            -1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 10L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxConnection3().minimalSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] x = new int[] {
            -96277832,
            507856257,
            -86306299,
            -806700273,
            -775932643,
            -273209838
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            -955536464,
            -599634138,
            399850429,
            -165706338,
            -537800480,
            738983556
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 5247213600L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxConnection3().minimalSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] x = new int[] {
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FoxConnection3().minimalSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
