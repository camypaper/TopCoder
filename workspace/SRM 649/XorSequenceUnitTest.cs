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
    public void ManualTest(int N, int sz, int A0, int A1, int P, int Q, int R)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("sz:{0}", sz);
        Console.WriteLine("A0:{0}", A0);
        Console.WriteLine("A1:{0}", A1);
        Console.WriteLine("P:{0}", P);
        Console.WriteLine("Q:{0}", Q);
        Console.WriteLine("R:{0}", R);
        long __result = new XorSequence().getmax(N, sz, A0, A1, P, Q, R);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int sz = 6;
        Console.WriteLine("sz:{0}", sz);
        int A0 = 3;
        Console.WriteLine("A0:{0}", A0);
        int A1 = 2;
        Console.WriteLine("A1:{0}", A1);
        int P = 0;
        Console.WriteLine("P:{0}", P);
        int Q = 1;
        Console.WriteLine("Q:{0}", Q);
        int R = 3;
        Console.WriteLine("R:{0}", R);
        long __expected = 8L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new XorSequence().getmax(N, sz, A0, A1, P, Q, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 8;
        Console.WriteLine("N:{0}", N);
        int sz = 8;
        Console.WriteLine("sz:{0}", sz);
        int A0 = 2;
        Console.WriteLine("A0:{0}", A0);
        int A1 = 5;
        Console.WriteLine("A1:{0}", A1);
        int P = 3;
        Console.WriteLine("P:{0}", P);
        int Q = 1;
        Console.WriteLine("Q:{0}", Q);
        int R = 4;
        Console.WriteLine("R:{0}", R);
        long __expected = 13L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new XorSequence().getmax(N, sz, A0, A1, P, Q, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 8;
        Console.WriteLine("N:{0}", N);
        int sz = 7;
        Console.WriteLine("sz:{0}", sz);
        int A0 = 3;
        Console.WriteLine("A0:{0}", A0);
        int A1 = 0;
        Console.WriteLine("A1:{0}", A1);
        int P = 1;
        Console.WriteLine("P:{0}", P);
        int Q = 2;
        Console.WriteLine("Q:{0}", Q);
        int R = 4;
        Console.WriteLine("R:{0}", R);
        long __expected = 12L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new XorSequence().getmax(N, sz, A0, A1, P, Q, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 32;
        Console.WriteLine("N:{0}", N);
        int sz = 15;
        Console.WriteLine("sz:{0}", sz);
        int A0 = 7;
        Console.WriteLine("A0:{0}", A0);
        int A1 = 9;
        Console.WriteLine("A1:{0}", A1);
        int P = 11;
        Console.WriteLine("P:{0}", P);
        int Q = 2;
        Console.WriteLine("Q:{0}", Q);
        int R = 1;
        Console.WriteLine("R:{0}", R);
        long __expected = 60L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new XorSequence().getmax(N, sz, A0, A1, P, Q, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 131072;
        Console.WriteLine("N:{0}", N);
        int sz = 131072;
        Console.WriteLine("sz:{0}", sz);
        int A0 = 7;
        Console.WriteLine("A0:{0}", A0);
        int A1 = 7;
        Console.WriteLine("A1:{0}", A1);
        int P = 1;
        Console.WriteLine("P:{0}", P);
        int Q = 0;
        Console.WriteLine("Q:{0}", Q);
        int R = 0;
        Console.WriteLine("R:{0}", R);
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new XorSequence().getmax(N, sz, A0, A1, P, Q, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int N = 131072;
        Console.WriteLine("N:{0}", N);
        int sz = 131070;
        Console.WriteLine("sz:{0}", sz);
        int A0 = 411;
        Console.WriteLine("A0:{0}", A0);
        int A1 = 415;
        Console.WriteLine("A1:{0}", A1);
        int P = 398;
        Console.WriteLine("P:{0}", P);
        int Q = 463;
        Console.WriteLine("Q:{0}", Q);
        int R = 9191;
        Console.WriteLine("R:{0}", R);
        long __expected = 4302679760L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new XorSequence().getmax(N, sz, A0, A1, P, Q, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
