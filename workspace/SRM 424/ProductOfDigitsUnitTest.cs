using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int N = Scanner.In.@int();
        Console.WriteLine("N:{0}",N);
        int __result  = new ProductOfDigits().smallestNumber(N);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int N = 1;
        Console.WriteLine("N:{0}",N);
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ProductOfDigits().smallestNumber(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int N = 10;
        Console.WriteLine("N:{0}",N);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ProductOfDigits().smallestNumber(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int N = 26;
        Console.WriteLine("N:{0}",N);
        int __expected = -1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ProductOfDigits().smallestNumber(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int N = 100;
        Console.WriteLine("N:{0}",N);
        int __expected = 3;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ProductOfDigits().smallestNumber(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int N = 2520;
        Console.WriteLine("N:{0}",N);
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ProductOfDigits().smallestNumber(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        int N = 864;
        Console.WriteLine("N:{0}",N);
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ProductOfDigits().smallestNumber(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
