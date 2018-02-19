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
    public void ManualTest(int N, int R, int C, int D, int A_MAX, int B_MAX)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("R:{0}", R);
        Console.WriteLine("C:{0}", C);
        Console.WriteLine("D:{0}", D);
        Console.WriteLine("A_MAX:{0}", A_MAX);
        Console.WriteLine("B_MAX:{0}", B_MAX);
        long __result = new BearEats().getDifference(N, R, C, D, A_MAX, B_MAX);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int R = 4;
        Console.WriteLine("R:{0}", R);
        int C = 4;
        Console.WriteLine("C:{0}", C);
        int D = 1;
        Console.WriteLine("D:{0}", D);
        int A_MAX = 11;
        Console.WriteLine("A_MAX:{0}", A_MAX);
        int B_MAX = 15;
        Console.WriteLine("B_MAX:{0}", B_MAX);
        long __expected = -3L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearEats().getDifference(N, R, C, D, A_MAX, B_MAX);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int R = 2;
        Console.WriteLine("R:{0}", R);
        int C = 3;
        Console.WriteLine("C:{0}", C);
        int D = 0;
        Console.WriteLine("D:{0}", D);
        int A_MAX = 14;
        Console.WriteLine("A_MAX:{0}", A_MAX);
        int B_MAX = 40;
        Console.WriteLine("B_MAX:{0}", B_MAX);
        long __expected = 4L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearEats().getDifference(N, R, C, D, A_MAX, B_MAX);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int R = 938593858;
        Console.WriteLine("R:{0}", R);
        int C = 538591850;
        Console.WriteLine("C:{0}", C);
        int D = 384025833;
        Console.WriteLine("D:{0}", D);
        int A_MAX = 885912358;
        Console.WriteLine("A_MAX:{0}", A_MAX);
        int B_MAX = 3405;
        Console.WriteLine("B_MAX:{0}", B_MAX);
        long __expected = 1452754016L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearEats().getDifference(N, R, C, D, A_MAX, B_MAX);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 200000;
        Console.WriteLine("N:{0}", N);
        int R = 999998741;
        Console.WriteLine("R:{0}", R);
        int C = 999997411;
        Console.WriteLine("C:{0}", C);
        int D = 64592149;
        Console.WriteLine("D:{0}", D);
        int A_MAX = 57;
        Console.WriteLine("A_MAX:{0}", A_MAX);
        int B_MAX = 75;
        Console.WriteLine("B_MAX:{0}", B_MAX);
        long __expected = 462494L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new BearEats().getDifference(N, R, C, D, A_MAX, B_MAX);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
