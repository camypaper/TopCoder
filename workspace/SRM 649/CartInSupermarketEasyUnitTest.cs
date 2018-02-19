using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int N = Scanner.In.@int();
        Console.WriteLine("N:{0}",N);
        int K = Scanner.In.@int();
        Console.WriteLine("K:{0}",K);
        int __result  = new CartInSupermarketEasy().calc(N, K);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int N = 5;
        Console.WriteLine("N:{0}",N);
        int K = 0;
        Console.WriteLine("K:{0}",K);
        int __expected = 5;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CartInSupermarketEasy().calc(N, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int N = 5;
        Console.WriteLine("N:{0}",N);
        int K = 2;
        Console.WriteLine("K:{0}",K);
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CartInSupermarketEasy().calc(N, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int N = 15;
        Console.WriteLine("N:{0}",N);
        int K = 4;
        Console.WriteLine("K:{0}",K);
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CartInSupermarketEasy().calc(N, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int N = 7;
        Console.WriteLine("N:{0}",N);
        int K = 100;
        Console.WriteLine("K:{0}",K);
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CartInSupermarketEasy().calc(N, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int N = 45;
        Console.WriteLine("N:{0}",N);
        int K = 5;
        Console.WriteLine("K:{0}",K);
        int __expected = 11;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CartInSupermarketEasy().calc(N, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        int N = 100;
        Console.WriteLine("N:{0}",N);
        int K = 100;
        Console.WriteLine("K:{0}",K);
        int __expected = 8;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CartInSupermarketEasy().calc(N, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
