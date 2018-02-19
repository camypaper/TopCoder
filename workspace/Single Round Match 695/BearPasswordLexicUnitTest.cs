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
    public void ManualTest(int[] x)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        string __result = new BearPasswordLexic().findPassword(x);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            5,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        string __expected = "ababa";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearPasswordLexic().findPassword(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            4,
            2,
            1,
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        string __expected = "aaab";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearPasswordLexic().findPassword(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            3,
            1,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        string __expected = "";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearPasswordLexic().findPassword(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        string __expected = "aaaa";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearPasswordLexic().findPassword(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        string __expected = "";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearPasswordLexic().findPassword(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] x = new int[] {
            4,
            0,
            3,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        string __expected = "";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new BearPasswordLexic().findPassword(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
