using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int[] cnt = Scanner.In.int_array();
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ",cnt)));
        int baseCost = Scanner.In.@int();
        Console.WriteLine("baseCost:{0}", baseCost);
        int seatCost = Scanner.In.@int();
        Console.WriteLine("seatCost:{0}", seatCost);
        int __result = new TheShuttles().getLeastCost(cnt, baseCost, seatCost);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] cnt, int baseCost, int seatCost)
    {
                        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ",cnt)));
                        Console.WriteLine("baseCost:{0}", baseCost);
                        Console.WriteLine("seatCost:{0}", seatCost);
                int __result = new TheShuttles().getLeastCost(cnt, baseCost, seatCost);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] cnt = new int[] {
            9
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int baseCost = 30;
        Console.WriteLine("baseCost:{0}", baseCost);
        int seatCost = 5;
        Console.WriteLine("seatCost:{0}", seatCost);
        int __expected = 75;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheShuttles().getLeastCost(cnt, baseCost, seatCost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] cnt = new int[] {
            9,
            4
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int baseCost = 30;
        Console.WriteLine("baseCost:{0}", baseCost);
        int seatCost = 5;
        Console.WriteLine("seatCost:{0}", seatCost);
        int __expected = 150;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheShuttles().getLeastCost(cnt, baseCost, seatCost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] cnt = new int[] {
            9,
            4
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int baseCost = 10;
        Console.WriteLine("baseCost:{0}", baseCost);
        int seatCost = 5;
        Console.WriteLine("seatCost:{0}", seatCost);
        int __expected = 105;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheShuttles().getLeastCost(cnt, baseCost, seatCost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] cnt = new int[] {
            51,
            1,
            77,
            14,
            17,
            10,
            80
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int baseCost = 32;
        Console.WriteLine("baseCost:{0}", baseCost);
        int seatCost = 40;
        Console.WriteLine("seatCost:{0}", seatCost);
        int __expected = 12096;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheShuttles().getLeastCost(cnt, baseCost, seatCost);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
