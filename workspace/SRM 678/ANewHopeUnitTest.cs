using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);    }
    public void ManualTest(int[] firstWeek, int[] lastWeek, int D)
    {
        Console.WriteLine(string.Format("firstWeek:{0}", string.Join(" ",firstWeek)));
        Console.WriteLine(string.Format("lastWeek:{0}", string.Join(" ",lastWeek)));
        Console.WriteLine("D:{0}", D);
        int __result = new ANewHope().count(firstWeek, lastWeek, D);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] firstWeek = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("firstWeek:{0}", string.Join(" ", firstWeek)));
        int[] lastWeek = new int[] {
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("lastWeek:{0}", string.Join(" ", lastWeek)));
        int D = 3;
        Console.WriteLine("D:{0}", D);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ANewHope().count(firstWeek, lastWeek, D);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] firstWeek = new int[] {
            8,
            5,
            4,
            1,
            7,
            6,
            3,
            2
        };
        Console.WriteLine(string.Format("firstWeek:{0}", string.Join(" ", firstWeek)));
        int[] lastWeek = new int[] {
            2,
            4,
            6,
            8,
            1,
            3,
            5,
            7
        };
        Console.WriteLine(string.Format("lastWeek:{0}", string.Join(" ", lastWeek)));
        int D = 3;
        Console.WriteLine("D:{0}", D);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ANewHope().count(firstWeek, lastWeek, D);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] firstWeek = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("firstWeek:{0}", string.Join(" ", firstWeek)));
        int[] lastWeek = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("lastWeek:{0}", string.Join(" ", lastWeek)));
        int D = 2;
        Console.WriteLine("D:{0}", D);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ANewHope().count(firstWeek, lastWeek, D);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
