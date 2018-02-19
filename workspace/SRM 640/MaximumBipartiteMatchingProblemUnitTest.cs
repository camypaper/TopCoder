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
    public void ManualTest(int n1, int n2, int ans, int d)
    {
        Console.WriteLine("n1:{0}", n1);
        Console.WriteLine("n2:{0}", n2);
        Console.WriteLine("ans:{0}", ans);
        Console.WriteLine("d:{0}", d);
        long __result = new MaximumBipartiteMatchingProblem().solve(n1, n2, ans, d);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n1 = 3;
        Console.WriteLine("n1:{0}", n1);
        int n2 = 3;
        Console.WriteLine("n2:{0}", n2);
        int ans = 2;
        Console.WriteLine("ans:{0}", ans);
        int d = 1;
        Console.WriteLine("d:{0}", d);
        long __expected = 5L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MaximumBipartiteMatchingProblem().solve(n1, n2, ans, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n1 = 3;
        Console.WriteLine("n1:{0}", n1);
        int n2 = 3;
        Console.WriteLine("n2:{0}", n2);
        int ans = 1;
        Console.WriteLine("ans:{0}", ans);
        int d = 1;
        Console.WriteLine("d:{0}", d);
        long __expected = -1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MaximumBipartiteMatchingProblem().solve(n1, n2, ans, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n1 = 5;
        Console.WriteLine("n1:{0}", n1);
        int n2 = 10;
        Console.WriteLine("n2:{0}", n2);
        int ans = 5;
        Console.WriteLine("ans:{0}", ans);
        int d = 2;
        Console.WriteLine("d:{0}", d);
        long __expected = 50L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MaximumBipartiteMatchingProblem().solve(n1, n2, ans, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n1 = 100000000;
        Console.WriteLine("n1:{0}", n1);
        int n2 = 87654321;
        Console.WriteLine("n2:{0}", n2);
        int ans = 12345678;
        Console.WriteLine("ans:{0}", ans);
        int d = 54321;
        Console.WriteLine("d:{0}", d);
        long __expected = 1233229491567444L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MaximumBipartiteMatchingProblem().solve(n1, n2, ans, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n1 = 1000000000;
        Console.WriteLine("n1:{0}", n1);
        int n2 = 1000000000;
        Console.WriteLine("n2:{0}", n2);
        int ans = 1000000000;
        Console.WriteLine("ans:{0}", ans);
        int d = 1000000000;
        Console.WriteLine("d:{0}", d);
        long __expected = 1000000000000000000L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new MaximumBipartiteMatchingProblem().solve(n1, n2, ans, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
