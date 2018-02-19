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
    public void ManualTest(int AX, int BX, int CX, int AY, int BY, int CY, int N, int M)
    {
        Console.WriteLine("AX:{0}", AX);
        Console.WriteLine("BX:{0}", BX);
        Console.WriteLine("CX:{0}", CX);
        Console.WriteLine("AY:{0}", AY);
        Console.WriteLine("BY:{0}", BY);
        Console.WriteLine("CY:{0}", CY);
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("M:{0}", M);
        int __result = new TheEmpireStrikesBack().find(AX, BX, CX, AY, BY, CY, N, M);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int AX = 2;
        Console.WriteLine("AX:{0}", AX);
        int BX = 2;
        Console.WriteLine("BX:{0}", BX);
        int CX = 2;
        Console.WriteLine("CX:{0}", CX);
        int AY = 2;
        Console.WriteLine("AY:{0}", AY);
        int BY = 2;
        Console.WriteLine("BY:{0}", BY);
        int CY = 2;
        Console.WriteLine("CY:{0}", CY);
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int M = 1;
        Console.WriteLine("M:{0}", M);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheEmpireStrikesBack().find(AX, BX, CX, AY, BY, CY, N, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int AX = 2;
        Console.WriteLine("AX:{0}", AX);
        int BX = 2;
        Console.WriteLine("BX:{0}", BX);
        int CX = 2;
        Console.WriteLine("CX:{0}", CX);
        int AY = 2;
        Console.WriteLine("AY:{0}", AY);
        int BY = 4;
        Console.WriteLine("BY:{0}", BY);
        int CY = 1000000000;
        Console.WriteLine("CY:{0}", CY);
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int M = 1;
        Console.WriteLine("M:{0}", M);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheEmpireStrikesBack().find(AX, BX, CX, AY, BY, CY, N, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int AX = 1;
        Console.WriteLine("AX:{0}", AX);
        int BX = 3;
        Console.WriteLine("BX:{0}", BX);
        int CX = 8;
        Console.WriteLine("CX:{0}", CX);
        int AY = 10000;
        Console.WriteLine("AY:{0}", AY);
        int BY = 10;
        Console.WriteLine("BY:{0}", BY);
        int CY = 999910000;
        Console.WriteLine("CY:{0}", CY);
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int M = 1;
        Console.WriteLine("M:{0}", M);
        int __expected = 30;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheEmpireStrikesBack().find(AX, BX, CX, AY, BY, CY, N, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int AX = 0;
        Console.WriteLine("AX:{0}", AX);
        int BX = 0;
        Console.WriteLine("BX:{0}", BX);
        int CX = 0;
        Console.WriteLine("CX:{0}", CX);
        int AY = 0;
        Console.WriteLine("AY:{0}", AY);
        int BY = 0;
        Console.WriteLine("BY:{0}", BY);
        int CY = 0;
        Console.WriteLine("CY:{0}", CY);
        int N = 100000;
        Console.WriteLine("N:{0}", N);
        int M = 1000;
        Console.WriteLine("M:{0}", M);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheEmpireStrikesBack().find(AX, BX, CX, AY, BY, CY, N, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int AX = 10;
        Console.WriteLine("AX:{0}", AX);
        int BX = 20;
        Console.WriteLine("BX:{0}", BX);
        int CX = 30;
        Console.WriteLine("CX:{0}", CX);
        int AY = 40;
        Console.WriteLine("AY:{0}", AY);
        int BY = 50;
        Console.WriteLine("BY:{0}", BY);
        int CY = 60;
        Console.WriteLine("CY:{0}", CY);
        int N = 100000;
        Console.WriteLine("N:{0}", N);
        int M = 10;
        Console.WriteLine("M:{0}", M);
        int __expected = 15720;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheEmpireStrikesBack().find(AX, BX, CX, AY, BY, CY, N, M);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
