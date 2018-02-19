using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);Tests.Add(Example7);    }
    public void ManualTest(int[] x, int[] a, int[] b, int K)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        Console.WriteLine("K:{0}", K);
        int __result = new BearKRoads().maxHappy(x, a, b, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            10,
            50,
            50,
            10
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] a = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int __expected = 100;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearKRoads().maxHappy(x, a, b, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            10,
            50,
            50,
            10
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] a = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 120;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearKRoads().maxHappy(x, a, b, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            42,
            100,
            500
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] a = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 642;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearKRoads().maxHappy(x, a, b, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            42,
            100,
            500,
            999,
            999,
            999,
            999
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] a = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 642;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearKRoads().maxHappy(x, a, b, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            969,
            467,
            808,
            263,
            179,
            428,
            595,
            557,
            406,
            80
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] a = new int[] {
            5,
            4,
            9,
            7,
            9,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            4,
            0,
            8,
            8,
            0,
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 2841;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearKRoads().maxHappy(x, a, b, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] x = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] a = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearKRoads().maxHappy(x, a, b, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] x = new int[] {
            1,
            2,
            3,
            4,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] a = new int[] {
            0,
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearKRoads().maxHappy(x, a, b, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example7()
    {
        int[] x = new int[] {
            8,
            18,
            14,
            10,
            7,
            16,
            4,
            19,
            6,
            12,
            17,
            10,
            12,
            3,
            15,
            8,
            15,
            12
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] a = new int[] {
            0,
            15,
            1,
            5,
            7,
            3,
            17,
            4,
            15,
            3,
            13,
            14,
            4,
            7
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            8,
            10,
            16,
            13,
            2,
            10,
            2,
            10,
            11,
            13,
            0,
            9,
            3,
            6
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int K = 7;
        Console.WriteLine("K:{0}", K);
        int __expected = 173;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearKRoads().maxHappy(x, a, b, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
