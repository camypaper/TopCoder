using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, 5, };
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
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int[] X = Scanner.In.int_array();
        Console.WriteLine(string.Format("X:{0}", string.Join(" ",X)));
        int[] Y = Scanner.In.int_array();
        Console.WriteLine(string.Format("Y:{0}", string.Join(" ",Y)));
        int limit = Scanner.In.@int();
        Console.WriteLine("limit:{0}", limit);
        int __result = new PilingRectsDiv2().getmax(X, Y, limit);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] X, int[] Y, int limit)
    {
                        Console.WriteLine(string.Format("X:{0}", string.Join(" ",X)));
                        Console.WriteLine(string.Format("Y:{0}", string.Join(" ",Y)));
                        Console.WriteLine("limit:{0}", limit);
                int __result = new PilingRectsDiv2().getmax(X, Y, limit);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] X = new int[] {
            1,
            2,
            3,
            1
        };
        Console.WriteLine(string.Format("X:{0}", string.Join(" ", X)));
        int[] Y = new int[] {
            3,
            2,
            4,
            4
        };
        Console.WriteLine(string.Format("Y:{0}", string.Join(" ", Y)));
        int limit = 3;
        Console.WriteLine("limit:{0}", limit);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PilingRectsDiv2().getmax(X, Y, limit);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] X = new int[] {
            4,
            7
        };
        Console.WriteLine(string.Format("X:{0}", string.Join(" ", X)));
        int[] Y = new int[] {
            7,
            4
        };
        Console.WriteLine(string.Format("Y:{0}", string.Join(" ", Y)));
        int limit = 25;
        Console.WriteLine("limit:{0}", limit);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PilingRectsDiv2().getmax(X, Y, limit);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] X = new int[] {
            10
        };
        Console.WriteLine(string.Format("X:{0}", string.Join(" ", X)));
        int[] Y = new int[] {
            10
        };
        Console.WriteLine(string.Format("Y:{0}", string.Join(" ", Y)));
        int limit = 9999;
        Console.WriteLine("limit:{0}", limit);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PilingRectsDiv2().getmax(X, Y, limit);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] X = new int[] {
            10
        };
        Console.WriteLine(string.Format("X:{0}", string.Join(" ", X)));
        int[] Y = new int[] {
            3
        };
        Console.WriteLine(string.Format("Y:{0}", string.Join(" ", Y)));
        int limit = 30;
        Console.WriteLine("limit:{0}", limit);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PilingRectsDiv2().getmax(X, Y, limit);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] X = new int[] {
            3,
            6,
            5,
            8,
            2,
            9,
            14
        };
        Console.WriteLine(string.Format("X:{0}", string.Join(" ", X)));
        int[] Y = new int[] {
            14,
            6,
            13,
            8,
            15,
            6,
            3
        };
        Console.WriteLine(string.Format("Y:{0}", string.Join(" ", Y)));
        int limit = 27;
        Console.WriteLine("limit:{0}", limit);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PilingRectsDiv2().getmax(X, Y, limit);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] X = new int[] {
            121,
            168,
            86,
            106,
            36,
            10,
            125,
            97,
            53,
            26,
            148,
            129,
            41,
            18,
            173,
            55,
            13,
            73,
            91,
            174,
            177,
            190,
            28,
            164,
            122,
            92,
            5,
            26,
            58,
            188,
            14,
            67,
            48,
            196,
            41,
            94,
            24,
            89,
            54,
            117,
            12,
            6,
            155,
            103,
            200,
            128,
            184,
            29,
            92,
            149
        };
        Console.WriteLine(string.Format("X:{0}", string.Join(" ", X)));
        int[] Y = new int[] {
            199,
            182,
            43,
            191,
            2,
            145,
            15,
            53,
            38,
            37,
            61,
            45,
            157,
            129,
            119,
            123,
            177,
            178,
            183,
            188,
            132,
            108,
            112,
            137,
            92,
            59,
            75,
            196,
            102,
            152,
            114,
            121,
            181,
            93,
            32,
            3,
            24,
            116,
            4,
            163,
            96,
            159,
            196,
            43,
            59,
            150,
            79,
            113,
            20,
            146
        };
        Console.WriteLine(string.Format("Y:{0}", string.Join(" ", Y)));
        int limit = 5345;
        Console.WriteLine("limit:{0}", limit);
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PilingRectsDiv2().getmax(X, Y, limit);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
