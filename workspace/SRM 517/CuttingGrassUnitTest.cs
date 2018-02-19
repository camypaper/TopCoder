using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);    }
    public void ManualTest(int[] init, int[] grow, int H)
    {
        Console.WriteLine(string.Format("init:{0}", string.Join(" ",init)));
        Console.WriteLine(string.Format("grow:{0}", string.Join(" ",grow)));
        Console.WriteLine("H:{0}", H);
        int __result = new CuttingGrass().theMin(init, grow, H);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] init = new int[] {
            5,
            8,
            58
        };
        Console.WriteLine(string.Format("init:{0}", string.Join(" ", init)));
        int[] grow = new int[] {
            2,
            1,
            1
        };
        Console.WriteLine(string.Format("grow:{0}", string.Join(" ", grow)));
        int H = 16;
        Console.WriteLine("H:{0}", H);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CuttingGrass().theMin(init, grow, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] init = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("init:{0}", string.Join(" ", init)));
        int[] grow = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("grow:{0}", string.Join(" ", grow)));
        int H = 58;
        Console.WriteLine("H:{0}", H);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CuttingGrass().theMin(init, grow, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] init = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("init:{0}", string.Join(" ", init)));
        int[] grow = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("grow:{0}", string.Join(" ", grow)));
        int H = 0;
        Console.WriteLine("H:{0}", H);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CuttingGrass().theMin(init, grow, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] init = new int[] {
            5,
            1,
            6,
            5,
            8,
            4,
            7
        };
        Console.WriteLine(string.Format("init:{0}", string.Join(" ", init)));
        int[] grow = new int[] {
            2,
            1,
            1,
            1,
            4,
            3,
            2
        };
        Console.WriteLine(string.Format("grow:{0}", string.Join(" ", grow)));
        int H = 33;
        Console.WriteLine("H:{0}", H);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CuttingGrass().theMin(init, grow, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] init = new int[] {
            49,
            13,
            62,
            95,
            69,
            75,
            62,
            96,
            97,
            22,
            69,
            69,
            52
        };
        Console.WriteLine(string.Format("init:{0}", string.Join(" ", init)));
        int[] grow = new int[] {
            7,
            2,
            4,
            3,
            6,
            5,
            7,
            6,
            5,
            4,
            7,
            7,
            4
        };
        Console.WriteLine(string.Format("grow:{0}", string.Join(" ", grow)));
        int H = 517;
        Console.WriteLine("H:{0}", H);
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CuttingGrass().theMin(init, grow, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] init = new int[] {
            1231,
            1536,
            1519,
            1940,
            1539,
            1385,
            1599,
            1613,
            1394,
            1803,
            1763,
            1706,
            1863,
            1452,
            1818,
            1914,
            1386,
            1954,
            1496,
            1722,
            1616,
            1862,
            1755,
            1215,
            1233,
            1078,
            1448,
            1241,
            1732,
            1561,
            1633,
            1307,
            1844,
            1911,
            1371,
            1338,
            1989,
            1789,
            1656,
            1413,
            1929,
            1182,
            1815,
            1474,
            1540,
            1797,
            1586,
            1427,
            1996,
            1202
        };
        Console.WriteLine(string.Format("init:{0}", string.Join(" ", init)));
        int[] grow = new int[] {
            86,
            55,
            2,
            86,
            96,
            71,
            81,
            53,
            79,
            22,
            23,
            8,
            69,
            32,
            35,
            39,
            30,
            18,
            92,
            64,
            88,
            1,
            48,
            81,
            91,
            75,
            44,
            77,
            3,
            33,
            9,
            52,
            56,
            4,
            19,
            73,
            52,
            18,
            8,
            77,
            91,
            59,
            50,
            62,
            42,
            87,
            89,
            24,
            71,
            67
        };
        Console.WriteLine(string.Format("grow:{0}", string.Join(" ", grow)));
        int H = 63601;
        Console.WriteLine("H:{0}", H);
        int __expected = 36;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CuttingGrass().theMin(init, grow, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
