using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class NumberGameAgainTest
{
    [TestMethod]
    public void Example0()
    {
        int k = 3;
        Console.WriteLine("k:{0}",k);
        long[] table = new long[] {
            2L,
            4L,
            6L
        };
        Console.WriteLine(string.Format("table:{0}",string.Join(" ",table)));
        long __expected = 2L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new NumberGameAgain().solve(k, table);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int k = 5;
        Console.WriteLine("k:{0}",k);
        long[] table = new long[] {
            2L,
            3L
        };
        Console.WriteLine(string.Format("table:{0}",string.Join(" ",table)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new NumberGameAgain().solve(k, table);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int k = 5;
        Console.WriteLine("k:{0}",k);
        long[] table = new long[] {
        };
        Console.WriteLine(string.Format("table:{0}",string.Join(" ",table)));
        long __expected = 30L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new NumberGameAgain().solve(k, table);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int k = 40;
        Console.WriteLine("k:{0}",k);
        long[] table = new long[] {
            2L,
            4L,
            8L,
            16L,
            32141531L,
            2324577L,
            1099511627775L,
            2222222222L,
            33333333333L,
            4444444444L,
            2135L
        };
        Console.WriteLine(string.Format("table:{0}",string.Join(" ",table)));
        long __expected = 549755748288L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new NumberGameAgain().solve(k, table);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int k = 40;
        Console.WriteLine("k:{0}",k);
        long[] table = new long[] {
        };
        Console.WriteLine(string.Format("table:{0}",string.Join(" ",table)));
        long __expected = 1099511627774L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new NumberGameAgain().solve(k, table);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
