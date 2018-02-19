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
    public void ManualTest(long K, long A, long B)
    {
        Console.WriteLine("K:{0}", K);
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        long __result = new KleofasTail().countGoodSequences(K, A, B);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        long K = 3L;
        Console.WriteLine("K:{0}", K);
        long A = 4L;
        Console.WriteLine("A:{0}", A);
        long B = 8L;
        Console.WriteLine("B:{0}", B);
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new KleofasTail().countGoodSequences(K, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        long K = 1L;
        Console.WriteLine("K:{0}", K);
        long A = 23457L;
        Console.WriteLine("A:{0}", A);
        long B = 123456L;
        Console.WriteLine("B:{0}", B);
        long __expected = 100000L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new KleofasTail().countGoodSequences(K, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        long K = 1234567890123456L;
        Console.WriteLine("K:{0}", K);
        long A = 10L;
        Console.WriteLine("A:{0}", A);
        long B = 1000000L;
        Console.WriteLine("B:{0}", B);
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new KleofasTail().countGoodSequences(K, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        long K = 0L;
        Console.WriteLine("K:{0}", K);
        long A = 0L;
        Console.WriteLine("A:{0}", A);
        long B = 2L;
        Console.WriteLine("B:{0}", B);
        long __expected = 3L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new KleofasTail().countGoodSequences(K, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        long K = 2L;
        Console.WriteLine("K:{0}", K);
        long A = 3L;
        Console.WriteLine("A:{0}", A);
        long B = 3L;
        Console.WriteLine("B:{0}", B);
        long __expected = 1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new KleofasTail().countGoodSequences(K, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        long K = 13L;
        Console.WriteLine("K:{0}", K);
        long A = 12345L;
        Console.WriteLine("A:{0}", A);
        long B = 67890123L;
        Console.WriteLine("B:{0}", B);
        long __expected = 8387584L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new KleofasTail().countGoodSequences(K, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
