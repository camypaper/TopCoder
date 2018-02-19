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
    public void ManualTest(int N, int A0, int B, int C, int MOD)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("A0:{0}", A0);
        Console.WriteLine("B:{0}", B);
        Console.WriteLine("C:{0}", C);
        Console.WriteLine("MOD:{0}", MOD);
        int __result = new TreeWalker().calc(N, A0, B, C, MOD);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int A0 = 0;
        Console.WriteLine("A0:{0}", A0);
        int B = 1;
        Console.WriteLine("B:{0}", B);
        int C = 1;
        Console.WriteLine("C:{0}", C);
        int MOD = 1000;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 34;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TreeWalker().calc(N, A0, B, C, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 10;
        Console.WriteLine("N:{0}", N);
        int A0 = 0;
        Console.WriteLine("A0:{0}", A0);
        int B = 0;
        Console.WriteLine("B:{0}", B);
        int C = 0;
        Console.WriteLine("C:{0}", C);
        int MOD = 1;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 13824;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TreeWalker().calc(N, A0, B, C, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 16;
        Console.WriteLine("N:{0}", N);
        int A0 = 15;
        Console.WriteLine("A0:{0}", A0);
        int B = 1;
        Console.WriteLine("B:{0}", B);
        int C = 1;
        Console.WriteLine("C:{0}", C);
        int MOD = 16;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 917506;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TreeWalker().calc(N, A0, B, C, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 1000;
        Console.WriteLine("N:{0}", N);
        int A0 = 385498676;
        Console.WriteLine("A0:{0}", A0);
        int B = 349131547;
        Console.WriteLine("B:{0}", B);
        int C = 115776323;
        Console.WriteLine("C:{0}", C);
        int MOD = 614879544;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 245566366;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TreeWalker().calc(N, A0, B, C, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 100000;
        Console.WriteLine("N:{0}", N);
        int A0 = 111222333;
        Console.WriteLine("A0:{0}", A0);
        int B = 444555666;
        Console.WriteLine("B:{0}", B);
        int C = 777888999;
        Console.WriteLine("C:{0}", C);
        int MOD = 123456789;
        Console.WriteLine("MOD:{0}", MOD);
        int __expected = 119729770;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TreeWalker().calc(N, A0, B, C, MOD);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
