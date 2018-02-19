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
    public void ManualTest(int N, int[] pos)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ",pos)));
        int __result = new PermutationCounts().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int[] pos = new int[] {
            3
        };
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ", pos)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PermutationCounts().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 13;
        Console.WriteLine("N:{0}", N);
        int[] pos = new int[] {
            12,
            11,
            10,
            9,
            8,
            7,
            6,
            5,
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ", pos)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PermutationCounts().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 13;
        Console.WriteLine("N:{0}", N);
        int[] pos = new int[] {
        };
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ", pos)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PermutationCounts().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 9;
        Console.WriteLine("N:{0}", N);
        int[] pos = new int[] {
            2,
            4,
            5
        };
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ", pos)));
        int __expected = 1421;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PermutationCounts().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 80;
        Console.WriteLine("N:{0}", N);
        int[] pos = new int[] {
            31,
            41,
            59,
            26,
            53,
            58,
            9,
            79,
            32,
            3,
            8,
            46
        };
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ", pos)));
        int __expected = 82650786;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PermutationCounts().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int N = 875;
        Console.WriteLine("N:{0}", N);
        int[] pos = new int[] {
            295,
            311,
            98,
            345,
            420,
            547,
            646,
            734,
            380,
            325,
            608,
            783,
            141,
            65,
            305,
            437,
            769,
            252,
            44,
            872,
            123,
            6,
            50,
            507,
            450,
            426,
            343,
            740,
            69,
            695,
            101,
            607,
            597,
            535,
            342,
            307,
            329,
            837,
            803,
            237,
            459,
            444,
            498,
            15,
            712,
            134,
            473,
            14,
            715,
            223,
            787,
            192,
            710,
            750,
            193,
            293,
            242,
            652,
            212,
            580,
            545,
            488,
            506,
            533,
            774,
            460,
            285,
            534,
            350,
            210,
            559,
            805,
            686,
            67,
            159,
            541,
            706,
            514,
            657,
            801,
            373,
            754,
            310,
            800,
            589,
            736,
            863,
            675,
            254,
            283,
            604,
            27,
            628,
            103,
            81,
            235,
            677,
            461,
            609,
            30,
            581,
            75,
            756,
            688,
            262,
            563,
            679,
            21,
            217,
            515,
            836,
            868,
            13,
            728,
            717,
            309,
            267,
            767,
            259,
            414,
            332,
            744,
            129,
            859,
            4,
            179,
            632,
            415,
            278,
            812,
            79,
            77,
            784,
            573,
            433,
            865,
            407,
            121,
            477,
            567,
            790,
            127,
            593,
            57,
            674,
            114,
            239,
            599,
            552,
            738
        };
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ", pos)));
        int __expected = 169176190;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PermutationCounts().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
