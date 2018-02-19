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
    public void ManualTest(string[] answer)
    {
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ",answer)));
        int __result = new DistinguishableSetDiv2().count(answer);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] answer = new string[] {
            "AA",
            "AB",
            "CC"
        };
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ", answer)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DistinguishableSetDiv2().count(answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] answer = new string[] {
            "XYZ",
            "XYZ",
            "XYZ"
        };
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ", answer)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DistinguishableSetDiv2().count(answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] answer = new string[] {
            "AAAA",
            "BACA",
            "CDCE"
        };
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ", answer)));
        int __expected = 11;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DistinguishableSetDiv2().count(answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] answer = new string[] {
            "HGHHGUHUHI",
            "BQHJWOSZMM",
            "NDKSKCNXND",
            "QOEOEIWIDS",
            "IIQIWUNNZM"
        };
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ", answer)));
        int __expected = 1017;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DistinguishableSetDiv2().count(answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] answer = new string[] {
            "XYZ",
            "XAB",
            "YAC"
        };
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ", answer)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new DistinguishableSetDiv2().count(answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
