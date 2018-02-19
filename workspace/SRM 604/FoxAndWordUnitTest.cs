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
    public void ManualTest(string[] words)
    {
        Console.WriteLine(string.Format("words:{0}", string.Join(" ",words)));
        int __result = new FoxAndWord().howManyPairs(words);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] words = new string[] {
            "tokyo",
            "kyoto"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndWord().howManyPairs(words);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] words = new string[] {
            "aaaaa",
            "bbbbb"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndWord().howManyPairs(words);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] words = new string[] {
            "ababab",
            "bababa",
            "aaabbb"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndWord().howManyPairs(words);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] words = new string[] {
            "eel",
            "ele",
            "lee"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndWord().howManyPairs(words);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] words = new string[] {
            "aaa",
            "aab",
            "aba",
            "abb",
            "baa",
            "bab",
            "bba",
            "bbb"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndWord().howManyPairs(words);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] words = new string[] {
            "top",
            "coder"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FoxAndWord().howManyPairs(words);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
