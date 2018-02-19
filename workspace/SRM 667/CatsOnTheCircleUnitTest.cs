using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);    }
    public void ManualTest(int N, int K, int p)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        Console.WriteLine("p:{0}", p);
        double __result = new CatsOnTheCircle().getProb(N, K, p);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int p = 300000000;
        Console.WriteLine("p:{0}", p);
        double __expected = 0.6999999999999985;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CatsOnTheCircle().getProb(N, K, p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int N = 6;
        Console.WriteLine("N:{0}", N);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int p = 500000000;
        Console.WriteLine("p:{0}", p);
        double __expected = 0.2;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CatsOnTheCircle().getProb(N, K, p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int N = 6;
        Console.WriteLine("N:{0}", N);
        int K = 5;
        Console.WriteLine("K:{0}", K);
        int p = 500000000;
        Console.WriteLine("p:{0}", p);
        double __expected = 0.2;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CatsOnTheCircle().getProb(N, K, p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int N = 10;
        Console.WriteLine("N:{0}", N);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int p = 666666666;
        Console.WriteLine("p:{0}", p);
        double __expected = 0.00391389439551009;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CatsOnTheCircle().getProb(N, K, p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int N = 999999999;
        Console.WriteLine("N:{0}", N);
        int K = 999999996;
        Console.WriteLine("K:{0}", K);
        int p = 777777777;
        Console.WriteLine("p:{0}", p);
        double __expected = 0.05830903870125612;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CatsOnTheCircle().getProb(N, K, p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example5()
    {
        int N = 1000000000;
        Console.WriteLine("N:{0}", N);
        int K = 4;
        Console.WriteLine("K:{0}", K);
        int p = 300000000;
        Console.WriteLine("p:{0}", p);
        double __expected = 0.044981259448371;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CatsOnTheCircle().getProb(N, K, p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example6()
    {
        int N = 534428790;
        Console.WriteLine("N:{0}", N);
        int K = 459947197;
        Console.WriteLine("K:{0}", K);
        int p = 500000000;
        Console.WriteLine("p:{0}", p);
        double __expected = 1.871156682766205E-9;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CatsOnTheCircle().getProb(N, K, p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
