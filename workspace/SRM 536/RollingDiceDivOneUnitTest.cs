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
    public void ManualTest(int[] dice)
    {
        Console.WriteLine(string.Format("dice:{0}", string.Join(" ",dice)));
        long __result = new RollingDiceDivOne().mostLikely(dice);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] dice = new int[] {
            6,
            6,
            8
        };
        Console.WriteLine(string.Format("dice:{0}", string.Join(" ", dice)));
        long __expected = 11L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new RollingDiceDivOne().mostLikely(dice);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] dice = new int[] {
            10
        };
        Console.WriteLine(string.Format("dice:{0}", string.Join(" ", dice)));
        long __expected = 1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new RollingDiceDivOne().mostLikely(dice);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] dice = new int[] {
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("dice:{0}", string.Join(" ", dice)));
        long __expected = 9L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new RollingDiceDivOne().mostLikely(dice);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] dice = new int[] {
            1,
            10,
            1
        };
        Console.WriteLine(string.Format("dice:{0}", string.Join(" ", dice)));
        long __expected = 3L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new RollingDiceDivOne().mostLikely(dice);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] dice = new int[] {
            382828264,
            942663792,
            291832707,
            887961277,
            546603677,
            545185615,
            146267547,
            6938117,
            167567032,
            84232402,
            700781193,
            452172304,
            816532384,
            951089120,
            448136091,
            280899512,
            256093435,
            39595226,
            631504901,
            154772240
        };
        Console.WriteLine(string.Format("dice:{0}", string.Join(" ", dice)));
        long __expected = 4366828428L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new RollingDiceDivOne().mostLikely(dice);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
