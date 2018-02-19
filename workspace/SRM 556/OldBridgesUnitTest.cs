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
    public void ManualTest(string[] bridges, int a1, int a2, int an, int b1, int b2, int bn)
    {
        Console.WriteLine(string.Format("bridges:{0}", string.Join(" ",bridges)));
        Console.WriteLine("a1:{0}", a1);
        Console.WriteLine("a2:{0}", a2);
        Console.WriteLine("an:{0}", an);
        Console.WriteLine("b1:{0}", b1);
        Console.WriteLine("b2:{0}", b2);
        Console.WriteLine("bn:{0}", bn);
        string __result = new OldBridges().isPossible(bridges, a1, a2, an, b1, b2, bn);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] bridges = new string[] {
            "XOXX",
            "OXOX",
            "XOXO",
            "XXOX"
        };
        Console.WriteLine(string.Format("bridges:{0}", string.Join(" ", bridges)));
        int a1 = 0;
        Console.WriteLine("a1:{0}", a1);
        int a2 = 1;
        Console.WriteLine("a2:{0}", a2);
        int an = 1;
        Console.WriteLine("an:{0}", an);
        int b1 = 2;
        Console.WriteLine("b1:{0}", b1);
        int b2 = 3;
        Console.WriteLine("b2:{0}", b2);
        int bn = 1;
        Console.WriteLine("bn:{0}", bn);
        string __expected = "Yes";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new OldBridges().isPossible(bridges, a1, a2, an, b1, b2, bn);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] bridges = new string[] {
            "XOXX",
            "OXOX",
            "XOXO",
            "XXOX"
        };
        Console.WriteLine(string.Format("bridges:{0}", string.Join(" ", bridges)));
        int a1 = 0;
        Console.WriteLine("a1:{0}", a1);
        int a2 = 2;
        Console.WriteLine("a2:{0}", a2);
        int an = 1;
        Console.WriteLine("an:{0}", an);
        int b1 = 1;
        Console.WriteLine("b1:{0}", b1);
        int b2 = 3;
        Console.WriteLine("b2:{0}", b2);
        int bn = 1;
        Console.WriteLine("bn:{0}", bn);
        string __expected = "No";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new OldBridges().isPossible(bridges, a1, a2, an, b1, b2, bn);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] bridges = new string[] {
            "XOXO",
            "OXOX",
            "XOXO",
            "OXOX"
        };
        Console.WriteLine(string.Format("bridges:{0}", string.Join(" ", bridges)));
        int a1 = 0;
        Console.WriteLine("a1:{0}", a1);
        int a2 = 2;
        Console.WriteLine("a2:{0}", a2);
        int an = 1;
        Console.WriteLine("an:{0}", an);
        int b1 = 1;
        Console.WriteLine("b1:{0}", b1);
        int b2 = 3;
        Console.WriteLine("b2:{0}", b2);
        int bn = 1;
        Console.WriteLine("bn:{0}", bn);
        string __expected = "Yes";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new OldBridges().isPossible(bridges, a1, a2, an, b1, b2, bn);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] bridges = new string[] {
            "XNXO",
            "NXOX",
            "XOXO",
            "OXOX"
        };
        Console.WriteLine(string.Format("bridges:{0}", string.Join(" ", bridges)));
        int a1 = 0;
        Console.WriteLine("a1:{0}", a1);
        int a2 = 2;
        Console.WriteLine("a2:{0}", a2);
        int an = 1;
        Console.WriteLine("an:{0}", an);
        int b1 = 1;
        Console.WriteLine("b1:{0}", b1);
        int b2 = 3;
        Console.WriteLine("b2:{0}", b2);
        int bn = 2;
        Console.WriteLine("bn:{0}", bn);
        string __expected = "No";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new OldBridges().isPossible(bridges, a1, a2, an, b1, b2, bn);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] bridges = new string[] {
            "XOXOO",
            "OXOXO",
            "XOXOO",
            "OXOXO",
            "OOOOX"
        };
        Console.WriteLine(string.Format("bridges:{0}", string.Join(" ", bridges)));
        int a1 = 0;
        Console.WriteLine("a1:{0}", a1);
        int a2 = 2;
        Console.WriteLine("a2:{0}", a2);
        int an = 2;
        Console.WriteLine("an:{0}", an);
        int b1 = 1;
        Console.WriteLine("b1:{0}", b1);
        int b2 = 3;
        Console.WriteLine("b2:{0}", b2);
        int bn = 2;
        Console.WriteLine("bn:{0}", bn);
        string __expected = "Yes";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new OldBridges().isPossible(bridges, a1, a2, an, b1, b2, bn);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] bridges = new string[] {
            "XOOOX",
            "OXOOX",
            "OOXOX",
            "OOOXN",
            "XXXNX"
        };
        Console.WriteLine(string.Format("bridges:{0}", string.Join(" ", bridges)));
        int a1 = 0;
        Console.WriteLine("a1:{0}", a1);
        int a2 = 4;
        Console.WriteLine("a2:{0}", a2);
        int an = 3;
        Console.WriteLine("an:{0}", an);
        int b1 = 1;
        Console.WriteLine("b1:{0}", b1);
        int b2 = 2;
        Console.WriteLine("b2:{0}", b2);
        int bn = 2;
        Console.WriteLine("bn:{0}", bn);
        string __expected = "No";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new OldBridges().isPossible(bridges, a1, a2, an, b1, b2, bn);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
