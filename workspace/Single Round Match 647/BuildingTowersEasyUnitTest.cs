using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class BuildingTowersEasyTest
{
    [TestMethod]
    public void Example0()
    {
        int N = 10;
        Console.WriteLine("N:{0}",N);
        int[] x = new int[] {
            3,
            8
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] t = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("t:{0}",string.Join(" ",t)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BuildingTowersEasy().maxHeight(N, x, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int N = 100000;
        Console.WriteLine("N:{0}",N);
        int[] x = new int[] {
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] t = new int[] {
        };
        Console.WriteLine(string.Format("t:{0}",string.Join(" ",t)));
        int __expected = 99999;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BuildingTowersEasy().maxHeight(N, x, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int N = 2718;
        Console.WriteLine("N:{0}",N);
        int[] x = new int[] {
            1,
            30,
            400,
            1300,
            2500
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] t = new int[] {
            100000,
            100000,
            100000,
            100000,
            100000
        };
        Console.WriteLine(string.Format("t:{0}",string.Join(" ",t)));
        int __expected = 2717;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BuildingTowersEasy().maxHeight(N, x, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int N = 20;
        Console.WriteLine("N:{0}",N);
        int[] x = new int[] {
            4,
            7,
            13,
            15,
            18
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] t = new int[] {
            3,
            8,
            1,
            17,
            16
        };
        Console.WriteLine(string.Format("t:{0}",string.Join(" ",t)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BuildingTowersEasy().maxHeight(N, x, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int N = 447;
        Console.WriteLine("N:{0}",N);
        int[] x = new int[] {
            32,
            35,
            55,
            60,
            61,
            88,
            91,
            97,
            128,
            151,
            181,
            186,
            192,
            196,
            198,
            237,
            259,
            268,
            291,
            314,
            341,
            367,
            389,
            390,
            391,
            428,
            435
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] t = new int[] {
            81,
            221,
            172,
            641,
            25,
            953,
            330,
            141,
            123,
            440,
            692,
            394,
            200,
            649,
            78,
            726,
            50,
            810,
            501,
            4,
            216,
            407,
            2,
            172,
            0,
            29,
            14
        };
        Console.WriteLine(string.Format("t:{0}",string.Join(" ",t)));
        int __expected = 120;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BuildingTowersEasy().maxHeight(N, x, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        int N = 97638;
        Console.WriteLine("N:{0}",N);
        int[] x = new int[] {
            8,
            1749,
            4550,
            5388,
            6752,
            7089,
            9737,
            14891,
            16671,
            16821,
            17691,
            19753,
            24589,
            25348,
            30114,
            32213,
            34376,
            36467,
            37699,
            41490,
            44784,
            44893,
            57316,
            58275,
            58567,
            61122,
            61489,
            63195,
            64776,
            65905,
            68788,
            69908,
            72853,
            78152,
            78784,
            82779,
            84488,
            86277,
            88611,
            92793,
            93214,
            97583
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] t = new int[] {
            16610,
            6,
            497,
            14,
            42892,
            31,
            79,
            1203,
            518,
            31147,
            597,
            7846,
            1396,
            8309,
            12,
            14,
            1148,
            433,
            23693,
            13,
            1939,
            244,
            19,
            46,
            27,
            611,
            412,
            10,
            27023,
            19141,
            34,
            15667,
            588,
            10,
            229,
            83,
            390,
            14,
            38441,
            16021,
            4,
            39386
        };
        Console.WriteLine(string.Format("t:{0}",string.Join(" ",t)));
        int __expected = 6343;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BuildingTowersEasy().maxHeight(N, x, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
