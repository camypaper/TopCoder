using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);    }
    public void ManualTest(int C, int[] bottles, int[] prices)
    {
        Console.WriteLine("C:{0}", C);
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ",bottles)));
        Console.WriteLine(string.Format("prices:{0}", string.Join(" ",prices)));
        int __result = new KiwiJuice().theProfit(C, bottles, prices);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int C = 10;
        Console.WriteLine("C:{0}", C);
        int[] bottles = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ", bottles)));
        int[] prices = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            10
        };
        Console.WriteLine(string.Format("prices:{0}", string.Join(" ", prices)));
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new KiwiJuice().theProfit(C, bottles, prices);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int C = 10;
        Console.WriteLine("C:{0}", C);
        int[] bottles = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ", bottles)));
        int[] prices = new int[] {
            0,
            0,
            0,
            0,
            0,
            10,
            10,
            10,
            10,
            10,
            10
        };
        Console.WriteLine(string.Format("prices:{0}", string.Join(" ", prices)));
        int __expected = 20;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new KiwiJuice().theProfit(C, bottles, prices);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int C = 10;
        Console.WriteLine("C:{0}", C);
        int[] bottles = new int[] {
            4,
            5,
            3,
            7
        };
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ", bottles)));
        int[] prices = new int[] {
            14,
            76,
            12,
            35,
            6,
            94,
            26,
            3,
            93,
            90,
            420
        };
        Console.WriteLine(string.Format("prices:{0}", string.Join(" ", prices)));
        int __expected = 625;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new KiwiJuice().theProfit(C, bottles, prices);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int C = 1;
        Console.WriteLine("C:{0}", C);
        int[] bottles = new int[] {
            0
        };
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ", bottles)));
        int[] prices = new int[] {
            1000000,
            1000000
        };
        Console.WriteLine(string.Format("prices:{0}", string.Join(" ", prices)));
        int __expected = 1000000;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new KiwiJuice().theProfit(C, bottles, prices);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int C = 49;
        Console.WriteLine("C:{0}", C);
        int[] bottles = new int[] {
            2,
            47,
            24,
            14,
            0,
            32,
            9,
            12,
            31,
            46,
            39,
            12,
            16,
            22,
            29
        };
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ", bottles)));
        int[] prices = new int[] {
            428668,
            995687,
            128567,
            37241,
            496916,
            238624,
            304781,
            997819,
            85856,
            417008,
            398570,
            951499,
            750349,
            333625,
            927594,
            188616,
            942498,
            259414,
            654344,
            354809,
            25303,
            226854,
            98578,
            207140,
            305527,
            358343,
            393213,
            256248,
            282644,
            103327,
            667191,
            103402,
            609183,
            619323,
            189127,
            518006,
            778846,
            400460,
            128334,
            795097,
            605203,
            669142,
            121825,
            934404,
            837430,
            554265,
            610818,
            546228,
            80784,
            949440
        };
        Console.WriteLine(string.Format("prices:{0}", string.Join(" ", prices)));
        int __expected = 12873962;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new KiwiJuice().theProfit(C, bottles, prices);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
