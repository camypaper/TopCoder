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
    public void ManualTest(int n, int minInv, string minStr)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("minInv:{0}", minInv);
        Console.WriteLine("minStr:{0}", minStr);
        string __result = new StrIIRec().recovstr(n, minInv, minStr);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int minInv = 1;
        Console.WriteLine("minInv:{0}", minInv);
        string minStr = "ab";
        Console.WriteLine("minStr:{0}", minStr);
        string __expected = "ba";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new StrIIRec().recovstr(n, minInv, minStr);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 9;
        Console.WriteLine("n:{0}", n);
        int minInv = 1;
        Console.WriteLine("minInv:{0}", minInv);
        string minStr = "efcdgab";
        Console.WriteLine("minStr:{0}", minStr);
        string __expected = "efcdgabhi";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new StrIIRec().recovstr(n, minInv, minStr);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 11;
        Console.WriteLine("n:{0}", n);
        int minInv = 55;
        Console.WriteLine("minInv:{0}", minInv);
        string minStr = "debgikjfc";
        Console.WriteLine("minStr:{0}", minStr);
        string __expected = "kjihgfedcba";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new StrIIRec().recovstr(n, minInv, minStr);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 15;
        Console.WriteLine("n:{0}", n);
        int minInv = 0;
        Console.WriteLine("minInv:{0}", minInv);
        string minStr = "e";
        Console.WriteLine("minStr:{0}", minStr);
        string __expected = "eabcdfghijklmno";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new StrIIRec().recovstr(n, minInv, minStr);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 9;
        Console.WriteLine("n:{0}", n);
        int minInv = 20;
        Console.WriteLine("minInv:{0}", minInv);
        string minStr = "fcdebiha";
        Console.WriteLine("minStr:{0}", minStr);
        string __expected = "fcdehigba";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new StrIIRec().recovstr(n, minInv, minStr);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
