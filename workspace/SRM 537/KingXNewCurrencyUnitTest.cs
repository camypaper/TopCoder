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
        int X = Scanner.In.@int();
        Console.WriteLine("X:{0}",X);
        int __result  = new KingXNewCurrency().howMany(A, B, X);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int A = 5;
        Console.WriteLine("A:{0}",A);
        int B = 8;
        Console.WriteLine("B:{0}",B);
        int X = 5;
        Console.WriteLine("X:{0}",X);
        int __expected = 5;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new KingXNewCurrency().howMany(A, B, X);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int A = 8;
        Console.WriteLine("A:{0}",A);
        int B = 4;
        Console.WriteLine("B:{0}",B);
        int X = 2;
        Console.WriteLine("X:{0}",X);
        int __expected = -1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new KingXNewCurrency().howMany(A, B, X);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int A = 7;
        Console.WriteLine("A:{0}",A);
        int B = 4;
        Console.WriteLine("B:{0}",B);
        int X = 13;
        Console.WriteLine("X:{0}",X);
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new KingXNewCurrency().howMany(A, B, X);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int A = 47;
        Console.WriteLine("A:{0}",A);
        int B = 74;
        Console.WriteLine("B:{0}",B);
        int X = 44;
        Console.WriteLine("X:{0}",X);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new KingXNewCurrency().howMany(A, B, X);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int A = 128;
        Console.WriteLine("A:{0}",A);
        int B = 96;
        Console.WriteLine("B:{0}",B);
        int X = 3;
        Console.WriteLine("X:{0}",X);
        int __expected = 65;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new KingXNewCurrency().howMany(A, B, X);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
