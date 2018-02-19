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
    public void ManualTest(string s)
    {
        Console.WriteLine("s:{0}", s);
        int __result = new PolynomialGCD().gcd(s);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "111";
        Console.WriteLine("s:{0}", s);
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PolynomialGCD().gcd(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "00000";
        Console.WriteLine("s:{0}", s);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PolynomialGCD().gcd(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "2014";
        Console.WriteLine("s:{0}", s);
        int __expected = 16;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PolynomialGCD().gcd(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "31415926535";
        Console.WriteLine("s:{0}", s);
        int __expected = 659897170;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PolynomialGCD().gcd(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
