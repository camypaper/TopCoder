using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class PairGameTest
{
    [TestMethod]
    public void Example0()
    {
        int a = 1;
        Console.WriteLine("a:{0}",a);
        int b = 2;
        Console.WriteLine("b:{0}",b);
        int c = 2;
        Console.WriteLine("c:{0}",c);
        int d = 1;
        Console.WriteLine("d:{0}",d);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new PairGame().maxSum(a, b, c, d);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int a = 15;
        Console.WriteLine("a:{0}",a);
        int b = 4;
        Console.WriteLine("b:{0}",b);
        int c = 10;
        Console.WriteLine("c:{0}",c);
        int d = 7;
        Console.WriteLine("d:{0}",d);
        int __expected = 7;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new PairGame().maxSum(a, b, c, d);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int a = 1;
        Console.WriteLine("a:{0}",a);
        int b = 1;
        Console.WriteLine("b:{0}",b);
        int c = 10;
        Console.WriteLine("c:{0}",c);
        int d = 10;
        Console.WriteLine("d:{0}",d);
        int __expected = -1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new PairGame().maxSum(a, b, c, d);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int a = 1000;
        Console.WriteLine("a:{0}",a);
        int b = 1001;
        Console.WriteLine("b:{0}",b);
        int c = 2000;
        Console.WriteLine("c:{0}",c);
        int d = 2001;
        Console.WriteLine("d:{0}",d);
        int __expected = 1001;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new PairGame().maxSum(a, b, c, d);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int a = 10944;
        Console.WriteLine("a:{0}",a);
        int b = 17928;
        Console.WriteLine("b:{0}",b);
        int c = 7704;
        Console.WriteLine("c:{0}",c);
        int d = 21888;
        Console.WriteLine("d:{0}",d);
        int __expected = 144;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new PairGame().maxSum(a, b, c, d);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        int a = 1;
        Console.WriteLine("a:{0}",a);
        int b = 1;
        Console.WriteLine("b:{0}",b);
        int c = 1;
        Console.WriteLine("c:{0}",c);
        int d = 1;
        Console.WriteLine("d:{0}",d);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new PairGame().maxSum(a, b, c, d);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
