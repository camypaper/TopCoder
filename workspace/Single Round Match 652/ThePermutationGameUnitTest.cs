using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int N = Scanner.In.@int();
        Console.WriteLine("N:{0}",N);
        int __result  = new ThePermutationGame().findMin(N);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}",N);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ThePermutationGame().findMin(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int N = 3;
        Console.WriteLine("N:{0}",N);
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ThePermutationGame().findMin(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int N = 11;
        Console.WriteLine("N:{0}",N);
        int __expected = 27720;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ThePermutationGame().findMin(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int N = 102;
        Console.WriteLine("N:{0}",N);
        int __expected = 53580071;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ThePermutationGame().findMin(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int N = 9999;
        Console.WriteLine("N:{0}",N);
        int __expected = 927702802;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ThePermutationGame().findMin(N);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
