using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int A = Scanner.In.@int();
        Console.WriteLine("A:{0}",A);
        int B = Scanner.In.@int();
        Console.WriteLine("B:{0}",B);
        int __result  = new TheNumberGameDiv2().minimumMoves(A, B);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int A = 25;
        Console.WriteLine("A:{0}",A);
        int B = 5;
        Console.WriteLine("B:{0}",B);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TheNumberGameDiv2().minimumMoves(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int A = 5162;
        Console.WriteLine("A:{0}",A);
        int B = 16;
        Console.WriteLine("B:{0}",B);
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TheNumberGameDiv2().minimumMoves(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int A = 334;
        Console.WriteLine("A:{0}",A);
        int B = 12;
        Console.WriteLine("B:{0}",B);
        int __expected = -1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TheNumberGameDiv2().minimumMoves(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int A = 218181918;
        Console.WriteLine("A:{0}",A);
        int B = 9181;
        Console.WriteLine("B:{0}",B);
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TheNumberGameDiv2().minimumMoves(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int A = 9798147;
        Console.WriteLine("A:{0}",A);
        int B = 79817;
        Console.WriteLine("B:{0}",B);
        int __expected = -1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TheNumberGameDiv2().minimumMoves(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
