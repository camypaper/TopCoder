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
    public void ManualTest(string[] score, int[] result)
    {
        Console.WriteLine(string.Format("score:{0}", string.Join(" ",score)));
        Console.WriteLine(string.Format("result:{0}", string.Join(" ",result)));
        string __result = new CandidatesSelection().possible(score, result);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] score = new string[] {
            "CC",
            "AA",
            "BB"
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int[] result = new int[] {
            1,
            2,
            0
        };
        Console.WriteLine(string.Format("result:{0}", string.Join(" ", result)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CandidatesSelection().possible(score, result);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] score = new string[] {
            "BAB",
            "ABB",
            "AAB",
            "ABA"
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int[] result = new int[] {
            2,
            0,
            1,
            3
        };
        Console.WriteLine(string.Format("result:{0}", string.Join(" ", result)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CandidatesSelection().possible(score, result);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] score = new string[] {
            "BAB",
            "ABB",
            "AAB",
            "ABA"
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int[] result = new int[] {
            0,
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("result:{0}", string.Join(" ", result)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CandidatesSelection().possible(score, result);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] score = new string[] {
            "AAA",
            "ZZZ"
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int[] result = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("result:{0}", string.Join(" ", result)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CandidatesSelection().possible(score, result);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] score = new string[] {
            "ZZZ",
            "AAA"
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int[] result = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("result:{0}", string.Join(" ", result)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CandidatesSelection().possible(score, result);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] score = new string[] {
            "ZYYYYX",
            "YXZYXY",
            "ZZZZXX",
            "XZXYYX",
            "ZZZYYZ",
            "ZZXXYZ",
            "ZYZZXZ",
            "XZYYZX"
        };
        Console.WriteLine(string.Format("score:{0}", string.Join(" ", score)));
        int[] result = new int[] {
            3,
            7,
            1,
            0,
            2,
            5,
            6,
            4
        };
        Console.WriteLine(string.Format("result:{0}", string.Join(" ", result)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new CandidatesSelection().possible(score, result);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
