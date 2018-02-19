using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        long R = Scanner.In.@long();
        Console.WriteLine("R:{0}",R);
        long G = Scanner.In.@long();
        Console.WriteLine("G:{0}",G);
        long B = Scanner.In.@long();
        Console.WriteLine("B:{0}",B);
        int N = Scanner.In.@int();
        Console.WriteLine("N:{0}",N);
        long __result  = new FoxPaintingBalls().theMax(R, G, B, N);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        long R = 2L;
        Console.WriteLine("R:{0}",R);
        long G = 2L;
        Console.WriteLine("G:{0}",G);
        long B = 2L;
        Console.WriteLine("B:{0}",B);
        int N = 3;
        Console.WriteLine("N:{0}",N);
        long __expected = 1L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new FoxPaintingBalls().theMax(R, G, B, N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        long R = 1L;
        Console.WriteLine("R:{0}",R);
        long G = 2L;
        Console.WriteLine("G:{0}",G);
        long B = 3L;
        Console.WriteLine("B:{0}",B);
        int N = 3;
        Console.WriteLine("N:{0}",N);
        long __expected = 0L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new FoxPaintingBalls().theMax(R, G, B, N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        long R = 8L;
        Console.WriteLine("R:{0}",R);
        long G = 6L;
        Console.WriteLine("G:{0}",G);
        long B = 6L;
        Console.WriteLine("B:{0}",B);
        int N = 4;
        Console.WriteLine("N:{0}",N);
        long __expected = 2L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new FoxPaintingBalls().theMax(R, G, B, N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        long R = 7L;
        Console.WriteLine("R:{0}",R);
        long G = 6L;
        Console.WriteLine("G:{0}",G);
        long B = 7L;
        Console.WriteLine("B:{0}",B);
        int N = 4;
        Console.WriteLine("N:{0}",N);
        long __expected = 2L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new FoxPaintingBalls().theMax(R, G, B, N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        long R = 100L;
        Console.WriteLine("R:{0}",R);
        long G = 100L;
        Console.WriteLine("G:{0}",G);
        long B = 100L;
        Console.WriteLine("B:{0}",B);
        int N = 4;
        Console.WriteLine("N:{0}",N);
        long __expected = 30L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new FoxPaintingBalls().theMax(R, G, B, N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        long R = 19330428391852493L;
        Console.WriteLine("R:{0}",R);
        long G = 48815737582834113L;
        Console.WriteLine("G:{0}",G);
        long B = 11451481019198930L;
        Console.WriteLine("B:{0}",B);
        int N = 3456;
        Console.WriteLine("N:{0}",N);
        long __expected = 5750952686L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new FoxPaintingBalls().theMax(R, G, B, N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example6()
    {
        long R = 1L;
        Console.WriteLine("R:{0}",R);
        long G = 1L;
        Console.WriteLine("G:{0}",G);
        long B = 1L;
        Console.WriteLine("B:{0}",B);
        int N = 1;
        Console.WriteLine("N:{0}",N);
        long __expected = 3L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new FoxPaintingBalls().theMax(R, G, B, N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
