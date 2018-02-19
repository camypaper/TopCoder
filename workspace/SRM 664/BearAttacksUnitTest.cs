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
    public void ManualTest(int N, int R0, int A, int B, int M, int LOW, int HIGH)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("R0:{0}", R0);
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        Console.WriteLine("M:{0}", M);
        Console.WriteLine("LOW:{0}", LOW);
        Console.WriteLine("HIGH:{0}", HIGH);
        int __result = new BearAttacks().expectedValue(N, R0, A, B, M, LOW, HIGH);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int R0 = 0;
        Console.WriteLine("R0:{0}", R0);
        int A = 2;
        Console.WriteLine("A:{0}", A);
        int B = 3;
        Console.WriteLine("B:{0}", B);
        int M = 100;
        Console.WriteLine("M:{0}", M);
        int LOW = 938593850;
        Console.WriteLine("LOW:{0}", LOW);
        int HIGH = 1000000000;
        Console.WriteLine("HIGH:{0}", HIGH);
        int __expected = 21;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearAttacks().expectedValue(N, R0, A, B, M, LOW, HIGH);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int R0 = 0;
        Console.WriteLine("R0:{0}", R0);
        int A = 0;
        Console.WriteLine("A:{0}", A);
        int B = 0;
        Console.WriteLine("B:{0}", B);
        int M = 1;
        Console.WriteLine("M:{0}", M);
        int LOW = 0;
        Console.WriteLine("LOW:{0}", LOW);
        int HIGH = 0;
        Console.WriteLine("HIGH:{0}", HIGH);
        int __expected = 23;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearAttacks().expectedValue(N, R0, A, B, M, LOW, HIGH);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 6;
        Console.WriteLine("N:{0}", N);
        int R0 = 303840291;
        Console.WriteLine("R0:{0}", R0);
        int A = 848660283;
        Console.WriteLine("A:{0}", A);
        int B = 395739574;
        Console.WriteLine("B:{0}", B);
        int M = 950123456;
        Console.WriteLine("M:{0}", M);
        int LOW = 0;
        Console.WriteLine("LOW:{0}", LOW);
        int HIGH = 1000000000;
        Console.WriteLine("HIGH:{0}", HIGH);
        int __expected = 3856;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearAttacks().expectedValue(N, R0, A, B, M, LOW, HIGH);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int R0 = 0;
        Console.WriteLine("R0:{0}", R0);
        int A = 0;
        Console.WriteLine("A:{0}", A);
        int B = 0;
        Console.WriteLine("B:{0}", B);
        int M = 1;
        Console.WriteLine("M:{0}", M);
        int LOW = 0;
        Console.WriteLine("LOW:{0}", LOW);
        int HIGH = 0;
        Console.WriteLine("HIGH:{0}", HIGH);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearAttacks().expectedValue(N, R0, A, B, M, LOW, HIGH);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 19;
        Console.WriteLine("N:{0}", N);
        int R0 = 384038999;
        Console.WriteLine("R0:{0}", R0);
        int A = 938592393;
        Console.WriteLine("A:{0}", A);
        int B = 692854433;
        Console.WriteLine("B:{0}", B);
        int M = 1000000000;
        Console.WriteLine("M:{0}", M);
        int LOW = 300000000;
        Console.WriteLine("LOW:{0}", LOW);
        int HIGH = 600000000;
        Console.WriteLine("HIGH:{0}", HIGH);
        int __expected = 473263988;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearAttacks().expectedValue(N, R0, A, B, M, LOW, HIGH);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
