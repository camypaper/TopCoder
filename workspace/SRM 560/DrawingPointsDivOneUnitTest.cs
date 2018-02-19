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
    public void ManualTest(int[] x, int[] y)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        int __result = new DrawingPointsDivOne().maxSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            0,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DrawingPointsDivOne().maxSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            0,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DrawingPointsDivOne().maxSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            -70
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            3
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DrawingPointsDivOne().maxSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            -41,
            -40,
            1,
            -11,
            -32,
            -7,
            24,
            -11,
            49,
            -15,
            -22,
            20,
            -8,
            54,
            54,
            69,
            16,
            -30,
            36,
            -6,
            -30,
            40,
            64,
            20,
            -66,
            -37,
            -33,
            -18,
            -35,
            36,
            9,
            61,
            -43,
            45,
            5,
            60,
            -8,
            -58,
            65,
            -66,
            41,
            12,
            34,
            -11,
            -57,
            -38,
            46,
            63,
            -55,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            5,
            -24,
            -2,
            -4,
            23,
            14,
            1,
            70,
            -26,
            45,
            15,
            48,
            32,
            -41,
            54,
            -47,
            -67,
            -46,
            -9,
            -53,
            54,
            28,
            -61,
            11,
            53,
            68,
            -33,
            62,
            37,
            -8,
            -17,
            -17,
            48,
            19,
            -49,
            56,
            -41,
            16,
            17,
            -50,
            28,
            59,
            10,
            50,
            23,
            -16,
            56,
            31,
            -70,
            -44
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DrawingPointsDivOne().maxSteps(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
