using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int N = Scanner.In.@int();
        Console.WriteLine("N:{0}",N);
        int L = Scanner.In.@int();
        Console.WriteLine("L:{0}",L);
        int X0 = Scanner.In.@int();
        Console.WriteLine("X0:{0}",X0);
        int A = Scanner.In.@int();
        Console.WriteLine("A:{0}",A);
        int B = Scanner.In.@int();
        Console.WriteLine("B:{0}",B);
        int __result  = new ProductOfPrices().product(N, L, X0, A, B);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int N = 5;
        Console.WriteLine("N:{0}",N);
        int L = 10;
        Console.WriteLine("L:{0}",L);
        int X0 = 3;
        Console.WriteLine("X0:{0}",X0);
        int A = 1;
        Console.WriteLine("A:{0}",A);
        int B = 1;
        Console.WriteLine("B:{0}",B);
        int __expected = 180;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ProductOfPrices().product(N, L, X0, A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int N = 3;
        Console.WriteLine("N:{0}",N);
        int L = 20;
        Console.WriteLine("L:{0}",L);
        int X0 = 5;
        Console.WriteLine("X0:{0}",X0);
        int A = 2;
        Console.WriteLine("A:{0}",A);
        int B = 3;
        Console.WriteLine("B:{0}",B);
        int __expected = 64;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ProductOfPrices().product(N, L, X0, A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int N = 4;
        Console.WriteLine("N:{0}",N);
        int L = 21;
        Console.WriteLine("L:{0}",L);
        int X0 = 1;
        Console.WriteLine("X0:{0}",X0);
        int A = 7;
        Console.WriteLine("A:{0}",A);
        int B = 1;
        Console.WriteLine("B:{0}",B);
        int __expected = 3087;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ProductOfPrices().product(N, L, X0, A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int N = 10;
        Console.WriteLine("N:{0}",N);
        int L = 100;
        Console.WriteLine("L:{0}",L);
        int X0 = 4;
        Console.WriteLine("X0:{0}",X0);
        int A = 37;
        Console.WriteLine("A:{0}",A);
        int B = 11;
        Console.WriteLine("B:{0}",B);
        int __expected = 591860767;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ProductOfPrices().product(N, L, X0, A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int N = 5;
        Console.WriteLine("N:{0}",N);
        int L = 200000;
        Console.WriteLine("L:{0}",L);
        int X0 = 999999999;
        Console.WriteLine("X0:{0}",X0);
        int A = 123456789;
        Console.WriteLine("A:{0}",A);
        int B = 987654321;
        Console.WriteLine("B:{0}",B);
        int __expected = 499739175;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ProductOfPrices().product(N, L, X0, A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
