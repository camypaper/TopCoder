using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int N = Scanner.In.@int();
        Console.WriteLine("N:{0}",N);
        int M = Scanner.In.@int();
        Console.WriteLine("M:{0}",M);
        double __result  = new PerfectMemory().getExpectation(N, M);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int N = 1;
        Console.WriteLine("N:{0}",N);
        int M = 2;
        Console.WriteLine("M:{0}",M);
        double __expected = 1.0;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new PerfectMemory().getExpectation(N, M);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 2;
        Console.WriteLine("N:{0}",N);
        int M = 2;
        Console.WriteLine("M:{0}",M);
        double __expected = 2.6666666666666665;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new PerfectMemory().getExpectation(N, M);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 2;
        Console.WriteLine("N:{0}",N);
        int M = 3;
        Console.WriteLine("M:{0}",M);
        double __expected = 4.333333333333334;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new PerfectMemory().getExpectation(N, M);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 4;
        Console.WriteLine("N:{0}",N);
        int M = 4;
        Console.WriteLine("M:{0}",M);
        double __expected = 12.392984792984793;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new PerfectMemory().getExpectation(N, M);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

}
