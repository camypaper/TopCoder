using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class NarrowPassage2EasyTest
{
    [TestMethod]
    public void Example0()
    {
        int[] size = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("size:{0}",string.Join(" ",size)));
        int maxSizeSum = 3;
        Console.WriteLine("maxSizeSum:{0}",maxSizeSum);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new NarrowPassage2Easy().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] size = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("size:{0}",string.Join(" ",size)));
        int maxSizeSum = 1000;
        Console.WriteLine("maxSizeSum:{0}",maxSizeSum);
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new NarrowPassage2Easy().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] size = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("size:{0}",string.Join(" ",size)));
        int maxSizeSum = 4;
        Console.WriteLine("maxSizeSum:{0}",maxSizeSum);
        int __expected = 3;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new NarrowPassage2Easy().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] size = new int[] {
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("size:{0}",string.Join(" ",size)));
        int maxSizeSum = 2;
        Console.WriteLine("maxSizeSum:{0}",maxSizeSum);
        int __expected = 720;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new NarrowPassage2Easy().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] size = new int[] {
            2,
            4,
            6,
            1,
            3,
            5
        };
        Console.WriteLine(string.Format("size:{0}",string.Join(" ",size)));
        int maxSizeSum = 8;
        Console.WriteLine("maxSizeSum:{0}",maxSizeSum);
        int __expected = 60;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new NarrowPassage2Easy().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        int[] size = new int[] {
            1000
        };
        Console.WriteLine(string.Format("size:{0}",string.Join(" ",size)));
        int maxSizeSum = 1000;
        Console.WriteLine("maxSizeSum:{0}",maxSizeSum);
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new NarrowPassage2Easy().count(size, maxSizeSum);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
