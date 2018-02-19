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
        int[] nextLevel = Scanner.In.int_array();
        Console.WriteLine(string.Format("nextLevel:{0}", string.Join(" ",nextLevel)));
        string __result = new DevuAndGame().canWin(nextLevel);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] nextLevel)
    {
                        Console.WriteLine(string.Format("nextLevel:{0}", string.Join(" ",nextLevel)));
                string __result = new DevuAndGame().canWin(nextLevel);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] nextLevel = new int[] {
            1,
            -1
        };
        Console.WriteLine(string.Format("nextLevel:{0}", string.Join(" ", nextLevel)));
        string __expected = "Win";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DevuAndGame().canWin(nextLevel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] nextLevel = new int[] {
            1,
            0,
            -1
        };
        Console.WriteLine(string.Format("nextLevel:{0}", string.Join(" ", nextLevel)));
        string __expected = "Lose";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DevuAndGame().canWin(nextLevel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] nextLevel = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("nextLevel:{0}", string.Join(" ", nextLevel)));
        string __expected = "Lose";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DevuAndGame().canWin(nextLevel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] nextLevel = new int[] {
            29,
            33,
            28,
            16,
            -1,
            11,
            10,
            14,
            6,
            31,
            7,
            35,
            34,
            8,
            15,
            17,
            26,
            12,
            13,
            22,
            1,
            20,
            2,
            21,
            -1,
            5,
            19,
            9,
            18,
            4,
            25,
            32,
            3,
            30,
            23,
            10,
            27
        };
        Console.WriteLine(string.Format("nextLevel:{0}", string.Join(" ", nextLevel)));
        string __expected = "Win";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DevuAndGame().canWin(nextLevel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] nextLevel = new int[] {
            17,
            43,
            20,
            41,
            42,
            15,
            18,
            35,
            -1,
            31,
            7,
            33,
            23,
            33,
            -1,
            -1,
            0,
            33,
            19,
            12,
            42,
            -1,
            -1,
            9,
            9,
            -1,
            39,
            -1,
            31,
            46,
            -1,
            20,
            44,
            41,
            -1,
            -1,
            12,
            -1,
            36,
            -1,
            -1,
            6,
            47,
            10,
            2,
            4,
            1,
            29
        };
        Console.WriteLine(string.Format("nextLevel:{0}", string.Join(" ", nextLevel)));
        string __expected = "Win";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DevuAndGame().canWin(nextLevel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] nextLevel = new int[] {
            3,
            1,
            1,
            2,
            -1,
            4
        };
        Console.WriteLine(string.Format("nextLevel:{0}", string.Join(" ", nextLevel)));
        string __expected = "Lose";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DevuAndGame().canWin(nextLevel);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
