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
        double __result = new BearCharges().minTime(x, y);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            10,
            11,
            12
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        double __expected = 2.414213562373095;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearCharges().minTime(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            0,
            1,
            -2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        double __expected = 3.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearCharges().minTime(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            0,
            0,
            0,
            -1,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            0,
            -1,
            0,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        double __expected = 3.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearCharges().minTime(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            -2,
            0,
            0,
            1,
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            0,
            1,
            -1,
            0,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        double __expected = 4.23606797749979;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearCharges().minTime(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            -500000000,
            -300000000,
            -100000000,
            200000000,
            300000000,
            400000000,
            600000000,
            900000000,
            950000000,
            1000000000
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
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
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        double __expected = 1.5E9;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearCharges().minTime(x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
