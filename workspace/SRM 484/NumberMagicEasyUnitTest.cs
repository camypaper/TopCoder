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
    public void ManualTest(string answer)
    {
        Console.WriteLine("answer:{0}", answer);
        int __result = new NumberMagicEasy().theNumber(answer);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string answer = "YNYY";
        Console.WriteLine("answer:{0}", answer);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NumberMagicEasy().theNumber(answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string answer = "YNNN";
        Console.WriteLine("answer:{0}", answer);
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NumberMagicEasy().theNumber(answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string answer = "NNNN";
        Console.WriteLine("answer:{0}", answer);
        int __expected = 16;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NumberMagicEasy().theNumber(answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string answer = "YYYY";
        Console.WriteLine("answer:{0}", answer);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NumberMagicEasy().theNumber(answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string answer = "NYNY";
        Console.WriteLine("answer:{0}", answer);
        int __expected = 11;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NumberMagicEasy().theNumber(answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
