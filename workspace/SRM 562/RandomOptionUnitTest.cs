using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class RandomOptionTest
{
    [TestMethod]
    public void Example0()
    {
        int keyCount = 5;
        Console.WriteLine("keyCount:{0}",keyCount);
        int[] badLane1 = new int[] {
            0
        };
        Console.WriteLine(string.Format("badLane1:{0}",string.Join(" ",badLane1)));
        int[] badLane2 = new int[] {
            3
        };
        Console.WriteLine(string.Format("badLane2:{0}",string.Join(" ",badLane2)));
        double __expected = 0.6;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new RandomOption().getProbability(keyCount, badLane1, badLane2);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example1()
    {
        int keyCount = 5;
        Console.WriteLine("keyCount:{0}",keyCount);
        int[] badLane1 = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("badLane1:{0}",string.Join(" ",badLane1)));
        int[] badLane2 = new int[] {
            1,
            2,
            0
        };
        Console.WriteLine(string.Format("badLane2:{0}",string.Join(" ",badLane2)));
        double __expected = 0.1;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new RandomOption().getProbability(keyCount, badLane1, badLane2);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example2()
    {
        int keyCount = 5;
        Console.WriteLine("keyCount:{0}",keyCount);
        int[] badLane1 = new int[] {
            2,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("badLane1:{0}",string.Join(" ",badLane1)));
        int[] badLane2 = new int[] {
            0,
            1,
            3,
            4
        };
        Console.WriteLine(string.Format("badLane2:{0}",string.Join(" ",badLane2)));
        double __expected = 0.0;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new RandomOption().getProbability(keyCount, badLane1, badLane2);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example3()
    {
        int keyCount = 7;
        Console.WriteLine("keyCount:{0}",keyCount);
        int[] badLane1 = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("badLane1:{0}",string.Join(" ",badLane1)));
        int[] badLane2 = new int[] {
            6,
            5,
            4
        };
        Console.WriteLine(string.Format("badLane2:{0}",string.Join(" ",badLane2)));
        double __expected = 0.3904761904761904;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new RandomOption().getProbability(keyCount, badLane1, badLane2);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example4()
    {
        int keyCount = 7;
        Console.WriteLine("keyCount:{0}",keyCount);
        int[] badLane1 = new int[] {
            3,
            5,
            1,
            0,
            2,
            6,
            4
        };
        Console.WriteLine(string.Format("badLane1:{0}",string.Join(" ",badLane1)));
        int[] badLane2 = new int[] {
            0,
            2,
            4,
            6,
            1,
            5,
            3
        };
        Console.WriteLine(string.Format("badLane2:{0}",string.Join(" ",badLane2)));
        double __expected = 0.09166666666666667;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new RandomOption().getProbability(keyCount, badLane1, badLane2);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

}
