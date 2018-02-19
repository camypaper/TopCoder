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
    public void ManualTest(int C, int X, int[] low, int[] high)
    {
        Console.WriteLine("C:{0}", C);
        Console.WriteLine("X:{0}", X);
        Console.WriteLine(string.Format("low:{0}", string.Join(" ",low)));
        Console.WriteLine(string.Format("high:{0}", string.Join(" ",high)));
        int __result = new MysticAndCandies().minBoxes(C, X, low, high);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int C = 15;
        Console.WriteLine("C:{0}", C);
        int X = 12;
        Console.WriteLine("X:{0}", X);
        int[] low = new int[] {
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("low:{0}", string.Join(" ", low)));
        int[] high = new int[] {
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("high:{0}", string.Join(" ", high)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MysticAndCandies().minBoxes(C, X, low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int C = 60;
        Console.WriteLine("C:{0}", C);
        int X = 8;
        Console.WriteLine("X:{0}", X);
        int[] low = new int[] {
            5,
            2,
            3
        };
        Console.WriteLine(string.Format("low:{0}", string.Join(" ", low)));
        int[] high = new int[] {
            49,
            48,
            47
        };
        Console.WriteLine(string.Format("high:{0}", string.Join(" ", high)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MysticAndCandies().minBoxes(C, X, low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int C = 58;
        Console.WriteLine("C:{0}", C);
        int X = 30;
        Console.WriteLine("X:{0}", X);
        int[] low = new int[] {
            3,
            9,
            12,
            6,
            15
        };
        Console.WriteLine(string.Format("low:{0}", string.Join(" ", low)));
        int[] high = new int[] {
            8,
            12,
            20,
            8,
            15
        };
        Console.WriteLine(string.Format("high:{0}", string.Join(" ", high)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MysticAndCandies().minBoxes(C, X, low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int C = 207581165;
        Console.WriteLine("C:{0}", C);
        int X = 172146543;
        Console.WriteLine("X:{0}", X);
        int[] low = new int[] {
            4725448,
            2753824,
            6019698,
            4199708,
            4070001,
            3589497,
            5358499,
            3637585,
            5393667,
            2837466,
            2747807,
            2918199,
            3638042,
            5199002,
            3072044,
            3858909,
            3762101,
            3657754,
            3218704,
            3888861,
            3195689,
            4768935,
            3137633,
            4124272,
            4125056,
            6087486,
            3632970,
            3620489,
            2748765,
            5917493,
            3958996,
            3335021,
            3517186,
            5543440,
            2951006,
            3403270,
            3299481,
            3093204,
            4092331
        };
        Console.WriteLine(string.Format("low:{0}", string.Join(" ", low)));
        int[] high = new int[] {
            5702812,
            6805664,
            6823687,
            5337687,
            4286533,
            4999849,
            6567411,
            4563235,
            6618139,
            6260135,
            6249469,
            3821449,
            5963157,
            6385012,
            4255959,
            5786920,
            6112817,
            4103918,
            6371537,
            4231698,
            3409172,
            6806782,
            5623563,
            4511221,
            6407338,
            6491490,
            5209517,
            6076093,
            6530132,
            6111464,
            5833839,
            6253088,
            5595160,
            6236805,
            5772388,
            5285713,
            5617002,
            4650978,
            5234740
        };
        Console.WriteLine(string.Format("high:{0}", string.Join(" ", high)));
        int __expected = 31;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MysticAndCandies().minBoxes(C, X, low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int C = 43873566;
        Console.WriteLine("C:{0}", C);
        int X = 32789748;
        Console.WriteLine("X:{0}", X);
        int[] low = new int[] {
            2053198,
            2175819,
            4260803,
            1542497,
            1418952,
            5000015,
            1381849,
            2462882,
            6466891,
            1827580,
            6943641,
            5775477
        };
        Console.WriteLine(string.Format("low:{0}", string.Join(" ", low)));
        int[] high = new int[] {
            2827461,
            3726335,
            5410505,
            4781355,
            4925909,
            5621160,
            7325774,
            5025476,
            7876037,
            8072075,
            6979462,
            6647628
        };
        Console.WriteLine(string.Format("high:{0}", string.Join(" ", high)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MysticAndCandies().minBoxes(C, X, low, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
