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
    public void ManualTest(int K, int A, int B, int C, int D)
    {
        Console.WriteLine("K:{0}", K);
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        Console.WriteLine("C:{0}", C);
        Console.WriteLine("D:{0}", D);
        int __result = new PackingBallsDiv1().minPacks(K, A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int A = 4;
        Console.WriteLine("A:{0}", A);
        int B = 2;
        Console.WriteLine("B:{0}", B);
        int C = 5;
        Console.WriteLine("C:{0}", C);
        int D = 6;
        Console.WriteLine("D:{0}", D);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PackingBallsDiv1().minPacks(K, A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int A = 58;
        Console.WriteLine("A:{0}", A);
        int B = 23;
        Console.WriteLine("B:{0}", B);
        int C = 39;
        Console.WriteLine("C:{0}", C);
        int D = 93;
        Console.WriteLine("D:{0}", D);
        int __expected = 58;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PackingBallsDiv1().minPacks(K, A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int K = 23;
        Console.WriteLine("K:{0}", K);
        int A = 10988;
        Console.WriteLine("A:{0}", A);
        int B = 5573;
        Console.WriteLine("B:{0}", B);
        int C = 4384;
        Console.WriteLine("C:{0}", C);
        int D = 100007;
        Console.WriteLine("D:{0}", D);
        int __expected = 47743;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PackingBallsDiv1().minPacks(K, A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int K = 100000;
        Console.WriteLine("K:{0}", K);
        int A = 123456789;
        Console.WriteLine("A:{0}", A);
        int B = 234567890;
        Console.WriteLine("B:{0}", B);
        int C = 345678901;
        Console.WriteLine("C:{0}", C);
        int D = 1000000000;
        Console.WriteLine("D:{0}", D);
        int __expected = 331988732;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PackingBallsDiv1().minPacks(K, A, B, C, D);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
