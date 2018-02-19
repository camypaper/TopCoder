using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        string front = Scanner.In.@string();
        Console.WriteLine("front:{0}", front);
        string side = Scanner.In.@string();
        Console.WriteLine("side:{0}", side);
        int __result = new BlackBoxDiv2().count(front, side);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string front, string side)
    {
                        Console.WriteLine("front:{0}", front);
                        Console.WriteLine("side:{0}", side);
                int __result = new BlackBoxDiv2().count(front, side);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string front = "BB";
        Console.WriteLine("front:{0}", front);
        string side = "BB";
        Console.WriteLine("side:{0}", side);
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlackBoxDiv2().count(front, side);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string front = "...";
        Console.WriteLine("front:{0}", front);
        string side = ".....";
        Console.WriteLine("side:{0}", side);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlackBoxDiv2().count(front, side);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string front = "...";
        Console.WriteLine("front:{0}", front);
        string side = "BBB";
        Console.WriteLine("side:{0}", side);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlackBoxDiv2().count(front, side);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string front = "...BB.B....";
        Console.WriteLine("front:{0}", front);
        string side = "B.B.B.B.B";
        Console.WriteLine("side:{0}", side);
        int __expected = 16081;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlackBoxDiv2().count(front, side);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string front = "BBBBB.BBBBBBBBB.BBBBBBB.BBBB.B.BB..BB.B.BBBBBBBBBB";
        Console.WriteLine("front:{0}", front);
        string side = ".B.BBB..BBBBBB.BBBB.B...BBBB.BB.BBBBBBBBBB.....BBB";
        Console.WriteLine("side:{0}", side);
        int __expected = 771030153;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BlackBoxDiv2().count(front, side);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
