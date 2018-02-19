using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class DigitMultipleTest
{
    [TestMethod]
    public void Example0()
    {
        int x = 6;
        Console.WriteLine("x:{0}",x);
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new DigitMultiple().calc(x);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int x = 893;
        Console.WriteLine("x:{0}",x);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new DigitMultiple().calc(x);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int x = 114514;
        Console.WriteLine("x:{0}",x);
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new DigitMultiple().calc(x);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int x = 1919;
        Console.WriteLine("x:{0}",x);
        int __expected = 8;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new DigitMultiple().calc(x);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
