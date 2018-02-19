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
    public void ManualTest(long[] values)
    {
        Console.WriteLine(string.Format("values:{0}", string.Join(" ",values)));
        int __result = new ColorfulCoins().minQueries(values);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        long[] values = new long[] {
            1L
        };
        Console.WriteLine(string.Format("values:{0}", string.Join(" ", values)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulCoins().minQueries(values);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        long[] values = new long[] {
            1L,
            3L
        };
        Console.WriteLine(string.Format("values:{0}", string.Join(" ", values)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulCoins().minQueries(values);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        long[] values = new long[] {
            1L,
            2L,
            4L
        };
        Console.WriteLine(string.Format("values:{0}", string.Join(" ", values)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulCoins().minQueries(values);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        long[] values = new long[] {
            1L,
            2L,
            4L,
            8L,
            16L
        };
        Console.WriteLine(string.Format("values:{0}", string.Join(" ", values)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulCoins().minQueries(values);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        long[] values = new long[] {
            1L,
            2L,
            6L,
            30L,
            90L,
            270L,
            810L,
            2430L,
            7290L,
            29160L,
            87480L,
            262440L,
            787320L,
            3149280L,
            9447840L,
            28343520L,
            56687040L,
            170061120L,
            510183360L,
            1530550080L,
            3061100160L,
            9183300480L,
            27549901440L,
            82649704320L,
            247949112960L,
            1239745564800L,
            3719236694400L,
            14876946777600L,
            44630840332800L,
            223154201664000L,
            669462604992000L,
            2008387814976000L,
            6025163444928000L,
            12050326889856000L,
            24100653779712000L,
            72301961339136000L,
            289207845356544000L,
            867623536069632000L
        };
        Console.WriteLine(string.Format("values:{0}", string.Join(" ", values)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ColorfulCoins().minQueries(values);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
