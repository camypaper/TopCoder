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
    public void ManualTest(int[] A, int[] T, int cost)
    {
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("T:{0}", string.Join(" ",T)));
        Console.WriteLine("cost:{0}", cost);
        double __result = new BearGirls().expectedValue(A, T, cost);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] A = new int[] {
            10,
            1,
            100
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] T = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("T:{0}", string.Join(" ", T)));
        int cost = 5;
        Console.WriteLine("cost:{0}", cost);
        double __expected = 40.99999999999999;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearGirls().expectedValue(A, T, cost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] A = new int[] {
            10,
            1,
            100
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] T = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("T:{0}", string.Join(" ", T)));
        int cost = 1000;
        Console.WriteLine("cost:{0}", cost);
        double __expected = -963.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearGirls().expectedValue(A, T, cost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] A = new int[] {
            10000
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] T = new int[] {
            10000
        };
        Console.WriteLine(string.Format("T:{0}", string.Join(" ", T)));
        int cost = 100;
        Console.WriteLine("cost:{0}", cost);
        double __expected = 17706.37475360699;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearGirls().expectedValue(A, T, cost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] A = new int[] {
            1000000000,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] T = new int[] {
            1,
            9999
        };
        Console.WriteLine(string.Format("T:{0}", string.Join(" ", T)));
        int cost = 0;
        Console.WriteLine("cost:{0}", cost);
        double __expected = 3.679155284022922E8;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearGirls().expectedValue(A, T, cost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] A = new int[] {
            1000000000,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] T = new int[] {
            1,
            9999
        };
        Console.WriteLine(string.Format("T:{0}", string.Join(" ", T)));
        int cost = 50;
        Console.WriteLine("cost:{0}", cost);
        double __expected = 3.675476907000374E8;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearGirls().expectedValue(A, T, cost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example5()
    {
        int[] A = new int[] {
            1000000000,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] T = new int[] {
            1,
            9999
        };
        Console.WriteLine(string.Format("T:{0}", string.Join(" ", T)));
        int cost = 5000;
        Console.WriteLine("cost:{0}", cost);
        double __expected = 3.316026716357059E8;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearGirls().expectedValue(A, T, cost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example6()
    {
        int[] A = new int[] {
            1000000000,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] T = new int[] {
            1,
            9999
        };
        Console.WriteLine(string.Format("T:{0}", string.Join(" ", T)));
        int cost = 500000;
        Console.WriteLine("cost:{0}", cost);
        double __expected = -395000.50000000035;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearGirls().expectedValue(A, T, cost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example7()
    {
        int[] A = new int[] {
            1000000000,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] T = new int[] {
            1,
            9999
        };
        Console.WriteLine(string.Format("T:{0}", string.Join(" ", T)));
        int cost = 1000000000;
        Console.WriteLine("cost:{0}", cost);
        double __expected = -9.998950005E8;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearGirls().expectedValue(A, T, cost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
