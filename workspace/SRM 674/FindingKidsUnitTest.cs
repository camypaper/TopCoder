using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);    }
    public void ManualTest(int n, int q, int A, int B, int C)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("q:{0}", q);
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        Console.WriteLine("C:{0}", C);
        long __result = new FindingKids().getSum(n, q, A, B, C);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int q = 2;
        Console.WriteLine("q:{0}", q);
        int A = 0;
        Console.WriteLine("A:{0}", A);
        int B = 1;
        Console.WriteLine("B:{0}", B);
        int C = 1;
        Console.WriteLine("C:{0}", C);
        long __expected = 15L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FindingKids().getSum(n, q, A, B, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int q = 4;
        Console.WriteLine("q:{0}", q);
        int A = 3;
        Console.WriteLine("A:{0}", A);
        int B = 2;
        Console.WriteLine("B:{0}", B);
        int C = 1;
        Console.WriteLine("C:{0}", C);
        long __expected = 43376L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FindingKids().getSum(n, q, A, B, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 200000;
        Console.WriteLine("n:{0}", n);
        int q = 200000;
        Console.WriteLine("q:{0}", q);
        int A = 12345;
        Console.WriteLine("A:{0}", A);
        int B = 67890;
        Console.WriteLine("B:{0}", B);
        int C = 111213141;
        Console.WriteLine("C:{0}", C);
        long __expected = 133378408428237L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FindingKids().getSum(n, q, A, B, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
