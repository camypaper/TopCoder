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
    public void ManualTest(int a, int b, int c)
    {
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine("c:{0}", c);
        int __result = new PolynomialRemainder().findRoot(a, b, c);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int a = 0;
        Console.WriteLine("a:{0}", a);
        int b = 0;
        Console.WriteLine("b:{0}", b);
        int c = 0;
        Console.WriteLine("c:{0}", c);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PolynomialRemainder().findRoot(a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int a = 0;
        Console.WriteLine("a:{0}", a);
        int b = 0;
        Console.WriteLine("b:{0}", b);
        int c = 1;
        Console.WriteLine("c:{0}", c);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PolynomialRemainder().findRoot(a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int a = 1;
        Console.WriteLine("a:{0}", a);
        int b = 2;
        Console.WriteLine("b:{0}", b);
        int c = 3;
        Console.WriteLine("c:{0}", c);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PolynomialRemainder().findRoot(a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int a = 123456000;
        Console.WriteLine("a:{0}", a);
        int b = 789012345;
        Console.WriteLine("b:{0}", b);
        int c = 678901230;
        Console.WriteLine("c:{0}", c);
        int __expected = 121618466;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PolynomialRemainder().findRoot(a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int a = 479659453;
        Console.WriteLine("a:{0}", a);
        int b = 928595613;
        Console.WriteLine("b:{0}", b);
        int c = 143451144;
        Console.WriteLine("c:{0}", c);
        int __expected = 647373336;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PolynomialRemainder().findRoot(a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
