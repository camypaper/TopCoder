using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);    }
    public void ManualTest(int N, int S, int MOD)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("S:{0}", S);
        Console.WriteLine("MOD:{0}", MOD);
        int __result = new BearPermutations().countPermutations(N, S, MOD);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int S = 1;
        Console.WriteLine("S:{0}", S);
        int MOD = 71876209;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPermutations().countPermutations(N, S, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int S = 0;
        Console.WriteLine("S:{0}", S);
        int MOD = 1000003;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPermutations().countPermutations(N, S, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int S = 1;
        Console.WriteLine("S:{0}", S);
        int MOD = 483128897;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPermutations().countPermutations(N, S, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int S = 3;
        Console.WriteLine("S:{0}", S);
        int MOD = 907283243;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 82;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPermutations().countPermutations(N, S, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int S = 100;
        Console.WriteLine("S:{0}", S);
        int MOD = 101;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 19;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPermutations().countPermutations(N, S, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int N = 20;
        Console.WriteLine("N:{0}", N);
        int S = 30;
        Console.WriteLine("S:{0}", S);
        int MOD = 3;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPermutations().countPermutations(N, S, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
