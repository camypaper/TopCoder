using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class AliceGameEasyTest
{
    [TestMethod]
    public void Example0()
    {
        long x = 7L;
        Console.WriteLine("x:{0}",x);
        long y = 14L;
        Console.WriteLine("y:{0}",y);
        long __expected = 2L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        long x = 10L;
        Console.WriteLine("x:{0}",x);
        long y = 0L;
        Console.WriteLine("y:{0}",y);
        long __expected = 4L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        long x = 932599670050L;
        Console.WriteLine("x:{0}",x);
        long y = 67400241741L;
        Console.WriteLine("y:{0}",y);
        long __expected = 1047062L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        long x = 7L;
        Console.WriteLine("x:{0}",x);
        long y = 13L;
        Console.WriteLine("y:{0}",y);
        long __expected = -1L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        long x = 0L;
        Console.WriteLine("x:{0}",x);
        long y = 0L;
        Console.WriteLine("y:{0}",y);
        long __expected = 0L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        long x = 100000L;
        Console.WriteLine("x:{0}",x);
        long y = 400500L;
        Console.WriteLine("y:{0}",y);
        long __expected = 106L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
