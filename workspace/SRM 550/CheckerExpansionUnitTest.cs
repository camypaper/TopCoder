using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);    }
    public void ManualTest(long t, long x0, long y0, int w, int h)
    {
        Console.WriteLine("t:{0}", t);
        Console.WriteLine("x0:{0}", x0);
        Console.WriteLine("y0:{0}", y0);
        Console.WriteLine("w:{0}", w);
        Console.WriteLine("h:{0}", h);
        string[] __result = new CheckerExpansion().resultAfter(t, x0, y0, w, h);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        long t = 1L;
        Console.WriteLine("t:{0}", t);
        long x0 = 0L;
        Console.WriteLine("x0:{0}", x0);
        long y0 = 0L;
        Console.WriteLine("y0:{0}", y0);
        int w = 4;
        Console.WriteLine("w:{0}", w);
        int h = 4;
        Console.WriteLine("h:{0}", h);
        string[] __expected = new string[] {
            "....",
            "....",
            "....",
            "A..."
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new CheckerExpansion().resultAfter(t, x0, y0, w, h);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        long t = 5L;
        Console.WriteLine("t:{0}", t);
        long x0 = 4L;
        Console.WriteLine("x0:{0}", x0);
        long y0 = 1L;
        Console.WriteLine("y0:{0}", y0);
        int w = 3;
        Console.WriteLine("w:{0}", w);
        int h = 4;
        Console.WriteLine("h:{0}", h);
        string[] __expected = new string[] {
            "A..",
            "...",
            "B..",
            ".B."
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new CheckerExpansion().resultAfter(t, x0, y0, w, h);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        long t = 1024L;
        Console.WriteLine("t:{0}", t);
        long x0 = 1525L;
        Console.WriteLine("x0:{0}", x0);
        long y0 = 512L;
        Console.WriteLine("y0:{0}", y0);
        int w = 20;
        Console.WriteLine("w:{0}", w);
        int h = 2;
        Console.WriteLine("h:{0}", h);
        string[] __expected = new string[] {
            "B...B...B...........",
            ".B.A.B.A.B.........."
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new CheckerExpansion().resultAfter(t, x0, y0, w, h);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        long t = 53L;
        Console.WriteLine("t:{0}", t);
        long x0 = 85L;
        Console.WriteLine("x0:{0}", x0);
        long y0 = 6L;
        Console.WriteLine("y0:{0}", y0);
        int w = 5;
        Console.WriteLine("w:{0}", w);
        int h = 14;
        Console.WriteLine("h:{0}", h);
        string[] __expected = new string[] {
            ".....",
            ".....",
            "B....",
            ".B.A.",
            ".....",
            ".....",
            ".....",
            ".....",
            ".....",
            ".....",
            "B....",
            ".B...",
            "..B..",
            ".A.B."
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new CheckerExpansion().resultAfter(t, x0, y0, w, h);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
