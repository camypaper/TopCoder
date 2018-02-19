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
    public void ManualTest(int[] ducks, int[] spellOne, int[] spellTwo, int K)
    {
        Console.WriteLine(string.Format("ducks:{0}", string.Join(" ",ducks)));
        Console.WriteLine(string.Format("spellOne:{0}", string.Join(" ",spellOne)));
        Console.WriteLine(string.Format("spellTwo:{0}", string.Join(" ",spellTwo)));
        Console.WriteLine("K:{0}", K);
        double __result = new KingXMagicSpells().expectedNumber(ducks, spellOne, spellTwo, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] ducks = new int[] {
            5,
            3,
            7
        };
        Console.WriteLine(string.Format("ducks:{0}", string.Join(" ", ducks)));
        int[] spellOne = new int[] {
            1,
            7,
            4
        };
        Console.WriteLine(string.Format("spellOne:{0}", string.Join(" ", spellOne)));
        int[] spellTwo = new int[] {
            1,
            0,
            2
        };
        Console.WriteLine(string.Format("spellTwo:{0}", string.Join(" ", spellTwo)));
        int K = 1;
        Console.WriteLine("K:{0}", K);
        double __expected = 3.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new KingXMagicSpells().expectedNumber(ducks, spellOne, spellTwo, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] ducks = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("ducks:{0}", string.Join(" ", ducks)));
        int[] spellOne = new int[] {
            53,
            7
        };
        Console.WriteLine(string.Format("spellOne:{0}", string.Join(" ", spellOne)));
        int[] spellTwo = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("spellTwo:{0}", string.Join(" ", spellTwo)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        double __expected = 21.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new KingXMagicSpells().expectedNumber(ducks, spellOne, spellTwo, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] ducks = new int[] {
            123,
            456,
            789,
            1234,
            56789
        };
        Console.WriteLine(string.Format("ducks:{0}", string.Join(" ", ducks)));
        int[] spellOne = new int[] {
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("spellOne:{0}", string.Join(" ", spellOne)));
        int[] spellTwo = new int[] {
            0,
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("spellTwo:{0}", string.Join(" ", spellTwo)));
        int K = 50;
        Console.WriteLine("K:{0}", K);
        double __expected = 123.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new KingXMagicSpells().expectedNumber(ducks, spellOne, spellTwo, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] ducks = new int[] {
            83291232,
            3124231,
            192412,
            3813249,
            629231,
            9998989
        };
        Console.WriteLine(string.Format("ducks:{0}", string.Join(" ", ducks)));
        int[] spellOne = new int[] {
            58,
            37,
            44,
            66,
            72,
            19
        };
        Console.WriteLine(string.Format("spellOne:{0}", string.Join(" ", spellOne)));
        int[] spellTwo = new int[] {
            2,
            0,
            1,
            5,
            4,
            3
        };
        Console.WriteLine(string.Format("spellTwo:{0}", string.Join(" ", spellTwo)));
        int K = 11;
        Console.WriteLine("K:{0}", K);
        double __expected = 2.888186784716797E7;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new KingXMagicSpells().expectedNumber(ducks, spellOne, spellTwo, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
