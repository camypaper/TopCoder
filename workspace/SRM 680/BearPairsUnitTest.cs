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
    public void ManualTest(string s, int[] cost, int k)
    {
        Console.WriteLine("s:{0}", s);
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ",cost)));
        Console.WriteLine("k:{0}", k);
        int __result = new BearPairs().minCost(s, cost, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "aabcde";
        Console.WriteLine("s:{0}", s);
        int[] cost = new int[] {
            1,
            1,
            100000,
            100000,
            100000,
            100000
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 200402;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPairs().minCost(s, cost, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "cdbcadc";
        Console.WriteLine("s:{0}", s);
        int[] cost = new int[] {
            261,
            208,
            150,
            250,
            92,
            226,
            176
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int __expected = 1402;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPairs().minCost(s, cost, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "deebaffafdaaceaa";
        Console.WriteLine("s:{0}", s);
        int[] cost = new int[] {
            160,
            268,
            253,
            210,
            34,
            28,
            180,
            70,
            5,
            42,
            177,
            234,
            108,
            117,
            215,
            1
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 2507;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPairs().minCost(s, cost, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "babbbabbbbababababbb";
        Console.WriteLine("s:{0}", s);
        int[] cost = new int[] {
            184,
            189,
            202,
            170,
            296,
            71,
            136,
            48,
            51,
            161,
            221,
            24,
            221,
            186,
            223,
            228,
            73,
            274,
            279,
            22
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int k = 4;
        Console.WriteLine("k:{0}", k);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPairs().minCost(s, cost, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "aaaaaaaaaaaaaaaaaa";
        Console.WriteLine("s:{0}", s);
        int[] cost = new int[] {
            237,
            185,
            24,
            175,
            107,
            251,
            299,
            81,
            282,
            20,
            150,
            164,
            240,
            225,
            166,
            261,
            164,
            123
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int k = 4;
        Console.WriteLine("k:{0}", k);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPairs().minCost(s, cost, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string s = "acadeffbffbfccbe";
        Console.WriteLine("s:{0}", s);
        int[] cost = new int[] {
            62,
            113,
            189,
            161,
            211,
            150,
            69,
            60,
            99,
            212,
            37,
            274,
            110,
            265,
            199,
            192
        };
        Console.WriteLine(string.Format("cost:{0}", string.Join(" ", cost)));
        int k = 4;
        Console.WriteLine("k:{0}", k);
        int __expected = 2235;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPairs().minCost(s, cost, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
