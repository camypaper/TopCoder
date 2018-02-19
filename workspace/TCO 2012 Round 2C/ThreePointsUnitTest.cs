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
    public void ManualTest(int N, int xzero, int xmul, int xadd, int xmod, int yzero, int ymul, int yadd, int ymod)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("xzero:{0}", xzero);
        Console.WriteLine("xmul:{0}", xmul);
        Console.WriteLine("xadd:{0}", xadd);
        Console.WriteLine("xmod:{0}", xmod);
        Console.WriteLine("yzero:{0}", yzero);
        Console.WriteLine("ymul:{0}", ymul);
        Console.WriteLine("yadd:{0}", yadd);
        Console.WriteLine("ymod:{0}", ymod);
        long __result = new ThreePoints().countColoring(N, xzero, xmul, xadd, xmod, yzero, ymul, yadd, ymod);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 9;
        Console.WriteLine("N:{0}", N);
        int xzero = 3;
        Console.WriteLine("xzero:{0}", xzero);
        int xmul = 8;
        Console.WriteLine("xmul:{0}", xmul);
        int xadd = 6;
        Console.WriteLine("xadd:{0}", xadd);
        int xmod = 11;
        Console.WriteLine("xmod:{0}", xmod);
        int yzero = 5;
        Console.WriteLine("yzero:{0}", yzero);
        int ymul = 7;
        Console.WriteLine("ymul:{0}", ymul);
        int yadd = 8;
        Console.WriteLine("yadd:{0}", yadd);
        int ymod = 11;
        Console.WriteLine("ymod:{0}", ymod);
        long __expected = 8L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ThreePoints().countColoring(N, xzero, xmul, xadd, xmod, yzero, ymul, yadd, ymod);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int xzero = 9;
        Console.WriteLine("xzero:{0}", xzero);
        int xmul = 6;
        Console.WriteLine("xmul:{0}", xmul);
        int xadd = 8;
        Console.WriteLine("xadd:{0}", xadd);
        int xmod = 10;
        Console.WriteLine("xmod:{0}", xmod);
        int yzero = 4;
        Console.WriteLine("yzero:{0}", yzero);
        int ymul = 8;
        Console.WriteLine("ymul:{0}", ymul);
        int yadd = 5;
        Console.WriteLine("yadd:{0}", yadd);
        int ymod = 10;
        Console.WriteLine("ymod:{0}", ymod);
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ThreePoints().countColoring(N, xzero, xmul, xadd, xmod, yzero, ymul, yadd, ymod);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 20;
        Console.WriteLine("N:{0}", N);
        int xzero = 30;
        Console.WriteLine("xzero:{0}", xzero);
        int xmul = 3;
        Console.WriteLine("xmul:{0}", xmul);
        int xadd = 71;
        Console.WriteLine("xadd:{0}", xadd);
        int xmod = 100;
        Console.WriteLine("xmod:{0}", xmod);
        int yzero = 78;
        Console.WriteLine("yzero:{0}", yzero);
        int ymul = 12;
        Console.WriteLine("ymul:{0}", ymul);
        int yadd = 50;
        Console.WriteLine("yadd:{0}", yadd);
        int ymod = 100;
        Console.WriteLine("ymod:{0}", ymod);
        long __expected = 263L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ThreePoints().countColoring(N, xzero, xmul, xadd, xmod, yzero, ymul, yadd, ymod);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 300000;
        Console.WriteLine("N:{0}", N);
        int xzero = 99097861;
        Console.WriteLine("xzero:{0}", xzero);
        int xmul = 102766912;
        Console.WriteLine("xmul:{0}", xmul);
        int xadd = 95284952;
        Console.WriteLine("xadd:{0}", xadd);
        int xmod = 123456789;
        Console.WriteLine("xmod:{0}", xmod);
        int yzero = 443104491;
        Console.WriteLine("yzero:{0}", yzero);
        int ymul = 971853214;
        Console.WriteLine("ymul:{0}", ymul);
        int yadd = 569775557;
        Console.WriteLine("yadd:{0}", yadd);
        int ymod = 987654321;
        Console.WriteLine("ymod:{0}", ymod);
        long __expected = 749410681185726L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ThreePoints().countColoring(N, xzero, xmul, xadd, xmod, yzero, ymul, yadd, ymod);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
