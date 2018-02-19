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
    public void ManualTest(int N, int K)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        int __result = new WolfHockeyTeamEasy().count(N, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int K = 0;
        Console.WriteLine("K:{0}", K);
        int __expected = 12;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WolfHockeyTeamEasy().count(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int K = 5;
        Console.WriteLine("K:{0}", K);
        int __expected = 1104;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WolfHockeyTeamEasy().count(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 100;
        Console.WriteLine("N:{0}", N);
        int K = 120;
        Console.WriteLine("K:{0}", K);
        int __expected = 803057135;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WolfHockeyTeamEasy().count(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 234;
        Console.WriteLine("N:{0}", N);
        int K = 467;
        Console.WriteLine("K:{0}", K);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WolfHockeyTeamEasy().count(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 810;
        Console.WriteLine("N:{0}", N);
        int K = 893;
        Console.WriteLine("K:{0}", K);
        int __expected = 281618909;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WolfHockeyTeamEasy().count(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
