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
    public void ManualTest(string S)
    {
        Console.WriteLine("S:{0}", S);
        int __result = new MagicalStringDiv1().getLongest(S);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string S = "<><><<>";
        Console.WriteLine("S:{0}", S);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MagicalStringDiv1().getLongest(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string S = ">>><<<";
        Console.WriteLine("S:{0}", S);
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MagicalStringDiv1().getLongest(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string S = "<<<>>>";
        Console.WriteLine("S:{0}", S);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MagicalStringDiv1().getLongest(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string S = "<<<<><>>><>>><>><>><>>><<<<>><>>>>><<>>>>><><<<<>>";
        Console.WriteLine("S:{0}", S);
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MagicalStringDiv1().getLongest(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
