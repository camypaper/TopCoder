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
    public void ManualTest(int N, int MOD)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("MOD:{0}", MOD);
        int __result = new BearPermutations2().getSum(N, MOD);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int MOD = 502739849;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPermutations2().getSum(N, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int MOD = 1000003;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPermutations2().getSum(N, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int MOD = 973412327;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 38;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPermutations2().getSum(N, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 100;
        Console.WriteLine("N:{0}", N);
        int MOD = 89;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 49;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPermutations2().getSum(N, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
