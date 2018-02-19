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
    public void ManualTest(int[] x, int[] y)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        int __result = new BearBall().countThrows(x, y);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            1,
            4,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            10,
            7
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearBall().countThrows(x, y);
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
            1,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            1,
            2,
            0,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 22;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearBall().countThrows(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            5,
            7,
            9,
            11
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 20;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearBall().countThrows(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            10,
            10,
            50,
            50,
            90,
            90
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            5,
            17,
            5,
            17,
            5,
            17
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 34;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearBall().countThrows(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            -100,
            -90,
            -80,
            -70,
            -85,
            -90,
            0,
            20
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            -5,
            -8,
            -13,
            -21,
            -13,
            -13,
            -13,
            -69
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        int __expected = 68;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearBall().countThrows(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
