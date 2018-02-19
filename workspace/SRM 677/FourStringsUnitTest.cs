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
    public void ManualTest(string a, string b, string c, string d)
    {
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine("c:{0}", c);
        Console.WriteLine("d:{0}", d);
        int __result = new FourStrings().shortestLength(a, b, c, d);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string a = "abc";
        Console.WriteLine("a:{0}", a);
        string b = "ab";
        Console.WriteLine("b:{0}", b);
        string c = "bc";
        Console.WriteLine("c:{0}", c);
        string d = "b";
        Console.WriteLine("d:{0}", d);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FourStrings().shortestLength(a, b, c, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string a = "a";
        Console.WriteLine("a:{0}", a);
        string b = "bc";
        Console.WriteLine("b:{0}", b);
        string c = "def";
        Console.WriteLine("c:{0}", c);
        string d = "ghij";
        Console.WriteLine("d:{0}", d);
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FourStrings().shortestLength(a, b, c, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string a = "top";
        Console.WriteLine("a:{0}", a);
        string b = "coder";
        Console.WriteLine("b:{0}", b);
        string c = "opco";
        Console.WriteLine("c:{0}", c);
        string d = "pcode";
        Console.WriteLine("d:{0}", d);
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FourStrings().shortestLength(a, b, c, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string a = "thereare";
        Console.WriteLine("a:{0}", a);
        string b = "arelots";
        Console.WriteLine("b:{0}", b);
        string c = "lotsof";
        Console.WriteLine("c:{0}", c);
        string d = "ofcases";
        Console.WriteLine("d:{0}", d);
        int __expected = 19;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FourStrings().shortestLength(a, b, c, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string a = "aba";
        Console.WriteLine("a:{0}", a);
        string b = "b";
        Console.WriteLine("b:{0}", b);
        string c = "b";
        Console.WriteLine("c:{0}", c);
        string d = "b";
        Console.WriteLine("d:{0}", d);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FourStrings().shortestLength(a, b, c, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string a = "x";
        Console.WriteLine("a:{0}", a);
        string b = "x";
        Console.WriteLine("b:{0}", b);
        string c = "x";
        Console.WriteLine("c:{0}", c);
        string d = "x";
        Console.WriteLine("d:{0}", d);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new FourStrings().shortestLength(a, b, c, d);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
