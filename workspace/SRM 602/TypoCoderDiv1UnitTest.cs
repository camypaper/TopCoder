using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, 5, 6, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            case 5: Example5(); break;
            case 6: Example6(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int[] D = Scanner.In.int_array();
        Console.WriteLine(string.Format("D:{0}", string.Join(" ",D)));
        int X = Scanner.In.@int();
        Console.WriteLine("X:{0}", X);
        int __result = new TypoCoderDiv1().getmax(D, X);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] D, int X)
    {
                        Console.WriteLine(string.Format("D:{0}", string.Join(" ",D)));
                        Console.WriteLine("X:{0}", X);
                int __result = new TypoCoderDiv1().getmax(D, X);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] D = new int[] {
            100,
            200,
            100,
            1,
            1
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        int X = 2000;
        Console.WriteLine("X:{0}", X);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv1().getmax(D, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] D = new int[] {
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        int X = 2199;
        Console.WriteLine("X:{0}", X);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv1().getmax(D, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] D = new int[] {
            90000,
            80000,
            70000,
            60000,
            50000,
            40000,
            30000,
            20000,
            10000
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        int X = 0;
        Console.WriteLine("X:{0}", X);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv1().getmax(D, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] D = new int[] {
            1000000000,
            1000000000,
            10000,
            100000,
            2202,
            1
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        int X = 1000;
        Console.WriteLine("X:{0}", X);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv1().getmax(D, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] D = new int[] {
            2048,
            1024,
            5012,
            256,
            128,
            64,
            32,
            16,
            8,
            4,
            2,
            1,
            0
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        int X = 2199;
        Console.WriteLine("X:{0}", X);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv1().getmax(D, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] D = new int[] {
            61,
            666,
            512,
            229,
            618,
            419,
            757,
            217,
            458,
            883,
            23,
            932,
            547,
            679,
            565,
            767,
            513,
            798,
            870,
            31,
            379,
            294,
            929,
            892,
            173,
            127,
            796,
            353,
            913,
            115,
            802,
            803,
            948,
            592,
            959,
            127,
            501,
            319,
            140,
            694,
            851,
            189,
            924,
            590,
            790,
            3,
            669,
            541,
            342,
            272
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        int X = 1223;
        Console.WriteLine("X:{0}", X);
        int __expected = 29;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv1().getmax(D, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] D = new int[] {
            34,
            64,
            43,
            14,
            58,
            30,
            2,
            16,
            90,
            58,
            35,
            55,
            46,
            24,
            14,
            73,
            96,
            13,
            9,
            42,
            64,
            36,
            89,
            42,
            42,
            64,
            52,
            68,
            53,
            76,
            52,
            54,
            23,
            88,
            32,
            52,
            28,
            96,
            70,
            32,
            26,
            3,
            23,
            78,
            47,
            23,
            54,
            30,
            86,
            32
        };
        Console.WriteLine(string.Format("D:{0}", string.Join(" ", D)));
        int X = 1328;
        Console.WriteLine("X:{0}", X);
        int __expected = 20;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TypoCoderDiv1().getmax(D, X);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
