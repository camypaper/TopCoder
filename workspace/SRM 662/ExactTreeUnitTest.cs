using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);    }
    public void ManualTest(int n, int m, int r)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("m:{0}", m);
        Console.WriteLine("r:{0}", r);
        int __result = new ExactTree().getTree(n, m, r);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int m = 100;
        Console.WriteLine("m:{0}", m);
        int r = 9;
        Console.WriteLine("r:{0}", r);
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ExactTree().getTree(n, m, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int m = 100;
        Console.WriteLine("m:{0}", m);
        int r = 10;
        Console.WriteLine("r:{0}", r);
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ExactTree().getTree(n, m, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int m = 100;
        Console.WriteLine("m:{0}", m);
        int r = 0;
        Console.WriteLine("r:{0}", r);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ExactTree().getTree(n, m, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int r = 0;
        Console.WriteLine("r:{0}", r);
        int __expected = 28;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ExactTree().getTree(n, m, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int r = 1;
        Console.WriteLine("r:{0}", r);
        int __expected = 25;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ExactTree().getTree(n, m, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int n = 25;
        Console.WriteLine("n:{0}", n);
        int m = 100;
        Console.WriteLine("m:{0}", m);
        int r = 0;
        Console.WriteLine("r:{0}", r);
        int __expected = 700;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ExactTree().getTree(n, m, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int n = 50;
        Console.WriteLine("n:{0}", n);
        int m = 97;
        Console.WriteLine("m:{0}", m);
        int r = 89;
        Console.WriteLine("r:{0}", r);
        int __expected = 2708;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ExactTree().getTree(n, m, r);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
