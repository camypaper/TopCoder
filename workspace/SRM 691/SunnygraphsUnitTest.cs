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
    public void ManualTest(int[] a)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        long __result = new Sunnygraphs().count(a);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        long __expected = 4L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sunnygraphs().count(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            2,
            2,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        long __expected = 7L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sunnygraphs().count(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            2,
            3,
            0,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        long __expected = 9L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sunnygraphs().count(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            2,
            2,
            3,
            4,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        long __expected = 30L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sunnygraphs().count(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] a = new int[] {
            18,
            18,
            20,
            28,
            7,
            27,
            8,
            13,
            40,
            3,
            7,
            21,
            30,
            17,
            13,
            34,
            29,
            16,
            15,
            11,
            0,
            9,
            39,
            36,
            38,
            23,
            24,
            8,
            4,
            9,
            29,
            22,
            35,
            5,
            13,
            23,
            3,
            27,
            34,
            23,
            8
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        long __expected = 2198754820096L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sunnygraphs().count(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
