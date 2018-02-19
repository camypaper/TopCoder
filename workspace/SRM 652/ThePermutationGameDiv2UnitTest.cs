using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int N = Scanner.In.@int();
        Console.WriteLine("N:{0}",N);
        long __result  = new ThePermutationGameDiv2().findMin(N);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}",N);
        long __expected = 2L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new ThePermutationGameDiv2().findMin(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int N = 3;
        Console.WriteLine("N:{0}",N);
        long __expected = 6L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new ThePermutationGameDiv2().findMin(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int N = 6;
        Console.WriteLine("N:{0}",N);
        long __expected = 60L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new ThePermutationGameDiv2().findMin(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int N = 11;
        Console.WriteLine("N:{0}",N);
        long __expected = 27720L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new ThePermutationGameDiv2().findMin(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int N = 25;
        Console.WriteLine("N:{0}",N);
        long __expected = 26771144400L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new ThePermutationGameDiv2().findMin(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
