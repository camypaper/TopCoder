using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);Tests.Add(Example7);    }
    public void ManualTest(int[] x, int t)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine("t:{0}", t);
        string __result = new LCMGCD().isPossible(x, t);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            2,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int t = 6;
        Console.WriteLine("t:{0}", t);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LCMGCD().isPossible(x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            4,
            9
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int t = 6;
        Console.WriteLine("t:{0}", t);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LCMGCD().isPossible(x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            6,
            12,
            24,
            18,
            36,
            72,
            54,
            108,
            216
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int t = 36;
        Console.WriteLine("t:{0}", t);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LCMGCD().isPossible(x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            6,
            27,
            81,
            729
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int t = 6;
        Console.WriteLine("t:{0}", t);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LCMGCD().isPossible(x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
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
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int t = 1;
        Console.WriteLine("t:{0}", t);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LCMGCD().isPossible(x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] x = new int[] {
            72,
            16,
            16,
            16,
            16,
            16,
            27,
            27,
            27,
            27,
            27,
            27,
            27,
            27,
            27
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int t = 72;
        Console.WriteLine("t:{0}", t);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LCMGCD().isPossible(x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] x = new int[] {
            100663296,
            544195584,
            229582512,
            59049
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int t = 60466176;
        Console.WriteLine("t:{0}", t);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LCMGCD().isPossible(x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example7()
    {
        int[] x = new int[] {
            2,
            4,
            8,
            16,
            32,
            64
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int t = 256;
        Console.WriteLine("t:{0}", t);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new LCMGCD().isPossible(x, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
