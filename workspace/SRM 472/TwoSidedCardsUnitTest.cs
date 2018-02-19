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
    public void ManualTest(int[] taro, int[] hanako)
    {
        Console.WriteLine(string.Format("taro:{0}", string.Join(" ",taro)));
        Console.WriteLine(string.Format("hanako:{0}", string.Join(" ",hanako)));
        int __result = new TwoSidedCards().theCount(taro, hanako);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] taro = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("taro:{0}", string.Join(" ", taro)));
        int[] hanako = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("hanako:{0}", string.Join(" ", hanako)));
        int __expected = 12;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TwoSidedCards().theCount(taro, hanako);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] taro = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("taro:{0}", string.Join(" ", taro)));
        int[] hanako = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("hanako:{0}", string.Join(" ", hanako)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TwoSidedCards().theCount(taro, hanako);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] taro = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("taro:{0}", string.Join(" ", taro)));
        int[] hanako = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("hanako:{0}", string.Join(" ", hanako)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TwoSidedCards().theCount(taro, hanako);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] taro = new int[] {
            5,
            8,
            1,
            2,
            3,
            4,
            6,
            7
        };
        Console.WriteLine(string.Format("taro:{0}", string.Join(" ", taro)));
        int[] hanako = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8
        };
        Console.WriteLine(string.Format("hanako:{0}", string.Join(" ", hanako)));
        int __expected = 2177280;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TwoSidedCards().theCount(taro, hanako);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] taro = new int[] {
            41,
            22,
            17,
            36,
            26,
            15,
            10,
            23,
            33,
            48,
            49,
            9,
            34,
            6,
            21,
            2,
            46,
            16,
            25,
            3,
            24,
            13,
            40,
            37,
            35,
            50,
            44,
            42,
            31,
            12,
            29,
            7,
            43,
            18,
            30,
            19,
            45,
            32,
            39,
            14,
            8,
            27,
            1,
            5,
            38,
            11,
            4,
            20,
            47,
            28
        };
        Console.WriteLine(string.Format("taro:{0}", string.Join(" ", taro)));
        int[] hanako = new int[] {
            19,
            6,
            23,
            35,
            17,
            7,
            50,
            2,
            33,
            36,
            12,
            31,
            46,
            21,
            30,
            13,
            47,
            22,
            44,
            4,
            25,
            24,
            3,
            15,
            20,
            48,
            10,
            28,
            26,
            18,
            5,
            45,
            49,
            16,
            40,
            42,
            43,
            14,
            1,
            37,
            29,
            8,
            41,
            38,
            9,
            11,
            34,
            32,
            39,
            27
        };
        Console.WriteLine(string.Format("hanako:{0}", string.Join(" ", hanako)));
        int __expected = 529165844;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TwoSidedCards().theCount(taro, hanako);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
