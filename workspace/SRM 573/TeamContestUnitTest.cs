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
        int __result = new TeamContest().worstRank(strength);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] strength = new int[] {
            5,
            7,
            3,
            5,
            7,
            3,
            5,
            7,
            3
        };
        Console.WriteLine(string.Format("strength:{0}", string.Join(" ", strength)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TeamContest().worstRank(strength);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] strength = new int[] {
            5,
            7,
            3
        };
        Console.WriteLine(string.Format("strength:{0}", string.Join(" ", strength)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TeamContest().worstRank(strength);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] strength = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("strength:{0}", string.Join(" ", strength)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TeamContest().worstRank(strength);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] strength = new int[] {
            3,
            9,
            4,
            6,
            2,
            6,
            1,
            6,
            9,
            1,
            4,
            1,
            3,
            8,
            5
        };
        Console.WriteLine(string.Format("strength:{0}", string.Join(" ", strength)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TeamContest().worstRank(strength);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] strength = new int[] {
            53,
            47,
            88,
            79,
            99,
            75,
            28,
            54,
            65,
            14,
            22,
            13,
            11,
            31,
            43
        };
        Console.WriteLine(string.Format("strength:{0}", string.Join(" ", strength)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TeamContest().worstRank(strength);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
