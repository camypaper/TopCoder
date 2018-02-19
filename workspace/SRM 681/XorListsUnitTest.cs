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
    public void ManualTest(int[] s, int m)
    {
        Console.WriteLine(string.Format("s:{0}", string.Join(" ",s)));
        Console.WriteLine("m:{0}", m);
        int __result = new XorLists().countLists(s, m);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] s = new int[] {
            0
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int m = 10000;
        Console.WriteLine("m:{0}", m);
        int __expected = 10001;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new XorLists().countLists(s, m);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] s = new int[] {
            1
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int m = 10000;
        Console.WriteLine("m:{0}", m);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new XorLists().countLists(s, m);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] s = new int[] {
            0,
            1,
            2,
            1,
            0,
            3,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int m = 5;
        Console.WriteLine("m:{0}", m);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new XorLists().countLists(s, m);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] s = new int[] {
            0,
            3,
            3,
            0
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new XorLists().countLists(s, m);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] s = new int[] {
            0,
            18955782,
            19774078,
            15197314,
            10559559,
            9167552,
            1059865,
            10395923,
            23165910,
            45583720,
            18955782,
            0,
            820344,
            29809284,
            25173569,
            27974854,
            19993119,
            29335317,
            4212176,
            60207982,
            19774078,
            820344,
            0,
            30039804,
            25991737,
            27678910,
            20813415,
            28515181,
            5030312,
            60438294,
            15197314,
            29809284,
            30039804,
            0,
            4637893,
            7079490,
            16238747,
            7947665,
            25599828,
            38824426,
            10559559,
            25173569,
            25991737,
            4637893,
            0,
            2802311,
            11603038,
            4161876,
            29383569,
            35040559,
            9167552,
            27974854,
            27678910,
            7079490,
            2802311,
            0,
            10211033,
            1393619,
            32151830,
            37515176,
            1059865,
            19993119,
            20813415,
            16238747,
            11603038,
            10211033,
            0,
            9342218,
            24205263,
            44540273,
            10395923,
            29335317,
            28515181,
            7947665,
            4161876,
            1393619,
            9342218,
            0,
            33544901,
            36252795,
            23165910,
            4212176,
            5030312,
            25599828,
            29383569,
            32151830,
            24205263,
            33544901,
            0,
            64419518,
            45583720,
            60207982,
            60438294,
            38824426,
            35040559,
            37515176,
            44540273,
            36252795,
            64419518,
            0
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int m = 1000000000;
        Console.WriteLine("m:{0}", m);
        int __expected = 976248323;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new XorLists().countLists(s, m);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
