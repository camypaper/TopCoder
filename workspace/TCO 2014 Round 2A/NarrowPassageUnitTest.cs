using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);    }
    public void ManualTest(int L, int[] a, int[] b)
    {
        Console.WriteLine("L:{0}", L);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        int __result = new NarrowPassage().minDist(L, a, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int L = 5;
        Console.WriteLine("L:{0}", L);
        int[] a = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            3,
            4
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NarrowPassage().minDist(L, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int L = 10;
        Console.WriteLine("L:{0}", L);
        int[] a = new int[] {
            3,
            9
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            8,
            6
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 14;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NarrowPassage().minDist(L, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int L = 265467;
        Console.WriteLine("L:{0}", L);
        int[] a = new int[] {
            133548,
            103861,
            29821,
            199848,
            92684,
            219824,
            215859,
            62821,
            172409,
            109235,
            38563,
            148854,
            24742,
            174068,
            205005,
            75922,
            87316,
            5542,
            57484,
            40792,
            25229,
            152216,
            21547,
            22203,
            84712,
            231522,
            235703,
            184895,
            100787,
            174440,
            156904,
            84898,
            185568,
            108732,
            260098,
            89488,
            221604,
            104555,
            165775,
            90444,
            81952,
            149671,
            209674,
            22185,
            45420,
            41928,
            16098,
            65324,
            90870,
            35243
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            150289,
            135139,
            69841,
            227226,
            177427,
            230314,
            199175,
            81572,
            220468,
            151049,
            40009,
            145963,
            115246,
            252932,
            263651,
            38434,
            120096,
            69576,
            29789,
            115046,
            33310,
            260771,
            5723,
            80733,
            107864,
            142447,
            235490,
            242149,
            124564,
            134602,
            245962,
            7078,
            215816,
            219864,
            190499,
            210237,
            212894,
            142760,
            126472,
            201935,
            119308,
            120211,
            235235,
            19446,
            87314,
            17286,
            61990,
            102050,
            261812,
            257
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 7148670;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NarrowPassage().minDist(L, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int L = 1000000;
        Console.WriteLine("L:{0}", L);
        int[] a = new int[] {
            706292,
            756214,
            490048,
            228791,
            567805,
            353900,
            640393,
            562496,
            217533,
            934149,
            938644,
            127480,
            777134,
            999144,
            41485,
            544051,
            417987,
            767415,
            971662,
            959022,
            670563,
            34065,
            518183,
            750574,
            546576,
            207758,
            159932,
            429345,
            670513,
            271901,
            476062,
            392721,
            774733,
            502586,
            915436,
            120280,
            951729,
            699859,
            581770,
            268966,
            79392,
            888601,
            378829,
            350198,
            939459,
            644983,
            605862,
            721305,
            269232,
            137587
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            322468,
            673534,
            83223,
            551733,
            341310,
            485064,
            885415,
            927526,
            159402,
            28144,
            441619,
            305530,
            883149,
            413745,
            932694,
            214862,
            677401,
            104356,
            836580,
            300580,
            409942,
            748444,
            744205,
            119051,
            999286,
            462508,
            984346,
            887773,
            856655,
            245559,
            418763,
            840266,
            999775,
            962927,
            779570,
            488394,
            760591,
            326325,
            206948,
            13999,
            285467,
            401562,
            786209,
            169847,
            171326,
            2901,
            296531,
            572035,
            364920,
            939046
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int __expected = 45670501;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NarrowPassage().minDist(L, a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
