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
    public void ManualTest(string state)
    {
        Console.WriteLine("state:{0}", state);
        int __result = new CoinFlipsDiv2().countCoins(state);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string state = "HT";
        Console.WriteLine("state:{0}", state);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CoinFlipsDiv2().countCoins(state);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string state = "T";
        Console.WriteLine("state:{0}", state);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CoinFlipsDiv2().countCoins(state);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string state = "HHH";
        Console.WriteLine("state:{0}", state);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CoinFlipsDiv2().countCoins(state);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string state = "HHTHHH";
        Console.WriteLine("state:{0}", state);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CoinFlipsDiv2().countCoins(state);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string state = "HHHTTTHHHTTTHTHTH";
        Console.WriteLine("state:{0}", state);
        int __expected = 12;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CoinFlipsDiv2().countCoins(state);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
