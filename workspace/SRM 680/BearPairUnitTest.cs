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
    public void ManualTest(string s)
    {
        Console.WriteLine("s:{0}", s);
        int __result = new BearPair().bigDistance(s);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "bear";
        Console.WriteLine("s:{0}", s);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPair().bigDistance(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "abcba";
        Console.WriteLine("s:{0}", s);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPair().bigDistance(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "oooohyeahpotato";
        Console.WriteLine("s:{0}", s);
        int __expected = 13;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPair().bigDistance(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "zzzzzzzzzzzzzzzzzzzzz";
        Console.WriteLine("s:{0}", s);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPair().bigDistance(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "qw";
        Console.WriteLine("s:{0}", s);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPair().bigDistance(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string s = "xxyyxyxyyyyyyxxxyxyxxxyxyxyyyyyxxxxxxyyyyyyyyxxxxx";
        Console.WriteLine("s:{0}", s);
        int __expected = 47;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPair().bigDistance(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
