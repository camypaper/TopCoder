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
    public void ManualTest(int[] strength)
    {
        Console.WriteLine(string.Format("strength:{0}", string.Join(" ",strength)));
        int __result = new TrySail().get(strength);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] strength = new int[] {
            2,
            3,
            3
        };
        Console.WriteLine(string.Format("strength:{0}", string.Join(" ", strength)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TrySail().get(strength);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] strength = new int[] {
            7,
            3,
            5,
            2
        };
        Console.WriteLine(string.Format("strength:{0}", string.Join(" ", strength)));
        int __expected = 17;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TrySail().get(strength);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] strength = new int[] {
            13,
            13,
            13,
            13,
            13,
            13,
            13,
            13
        };
        Console.WriteLine(string.Format("strength:{0}", string.Join(" ", strength)));
        int __expected = 26;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TrySail().get(strength);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] strength = new int[] {
            114,
            51,
            4,
            191,
            9,
            81,
            0,
            89,
            3
        };
        Console.WriteLine(string.Format("strength:{0}", string.Join(" ", strength)));
        int __expected = 470;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TrySail().get(strength);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] strength = new int[] {
            108,
            66,
            45,
            82,
            163,
            30,
            83,
            244,
            200,
            216,
            241,
            249,
            89,
            128,
            36,
            28,
            250,
            190,
            70,
            95,
            117,
            196,
            19,
            160,
            255,
            129,
            10,
            109,
            189,
            24,
            22,
            25,
            134,
            144,
            110,
            15,
            235,
            205,
            186,
            103,
            116,
            191,
            119,
            183,
            45,
            217,
            156,
            44,
            97,
            197
        };
        Console.WriteLine(string.Format("strength:{0}", string.Join(" ", strength)));
        int __expected = 567;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TrySail().get(strength);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
