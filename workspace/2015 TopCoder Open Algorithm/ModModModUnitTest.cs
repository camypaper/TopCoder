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
        int[] m = Scanner.In.int_array();
        Console.WriteLine(string.Format("m:{0}", string.Join(" ",m)));
        int R = Scanner.In.@int();
        Console.WriteLine("R:{0}", R);
        long __result = new ModModMod().findSum(m, R);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] m, int R)
    {
                        Console.WriteLine(string.Format("m:{0}", string.Join(" ",m)));
                        Console.WriteLine("R:{0}", R);
                long __result = new ModModMod().findSum(m, R);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] m = new int[] {
            5,
            3,
            2
        };
        Console.WriteLine(string.Format("m:{0}", string.Join(" ", m)));
        int R = 10;
        Console.WriteLine("R:{0}", R);
        long __expected = 4L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ModModMod().findSum(m, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] m = new int[] {
            33,
            15,
            7,
            10,
            100,
            9,
            5
        };
        Console.WriteLine(string.Format("m:{0}", string.Join(" ", m)));
        int R = 64;
        Console.WriteLine("R:{0}", R);
        long __expected = 92L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ModModMod().findSum(m, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] m = new int[] {
            995,
            149,
            28,
            265,
            275,
            107,
            555,
            241,
            702,
            462,
            519,
            212,
            362,
            478,
            783,
            381,
            602,
            546,
            183,
            886,
            59,
            317,
            977,
            612,
            328,
            91,
            771,
            131
        };
        Console.WriteLine(string.Format("m:{0}", string.Join(" ", m)));
        int R = 992363;
        Console.WriteLine("R:{0}", R);
        long __expected = 12792005L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ModModMod().findSum(m, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] m = new int[] {
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100,
            100
        };
        Console.WriteLine(string.Format("m:{0}", string.Join(" ", m)));
        int R = 100;
        Console.WriteLine("R:{0}", R);
        long __expected = 4950L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ModModMod().findSum(m, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] m = new int[] {
            2934
        };
        Console.WriteLine(string.Format("m:{0}", string.Join(" ", m)));
        int R = 10000000;
        Console.WriteLine("R:{0}", R);
        long __expected = 14664070144L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ModModMod().findSum(m, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
