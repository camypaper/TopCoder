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
    public void ManualTest(string word)
    {
        Console.WriteLine("word:{0}", word);
        int __result = new AppleWord().minRep(word);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string word = "Apple";
        Console.WriteLine("word:{0}", word);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AppleWord().minRep(word);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string word = "apPpPPlE";
        Console.WriteLine("word:{0}", word);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AppleWord().minRep(word);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string word = "APLE";
        Console.WriteLine("word:{0}", word);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AppleWord().minRep(word);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string word = "TopCoder";
        Console.WriteLine("word:{0}", word);
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new AppleWord().minRep(word);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
