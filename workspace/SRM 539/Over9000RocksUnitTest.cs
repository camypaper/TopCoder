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
    public void ManualTest(int[] lowerBound, int[] upperBound)
    {
        Console.WriteLine(string.Format("lowerBound:{0}", string.Join(" ",lowerBound)));
        Console.WriteLine(string.Format("upperBound:{0}", string.Join(" ",upperBound)));
        int __result = new Over9000Rocks().countPossibilities(lowerBound, upperBound);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] lowerBound = new int[] {
            9000
        };
        Console.WriteLine(string.Format("lowerBound:{0}", string.Join(" ", lowerBound)));
        int[] upperBound = new int[] {
            9001
        };
        Console.WriteLine(string.Format("upperBound:{0}", string.Join(" ", upperBound)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Over9000Rocks().countPossibilities(lowerBound, upperBound);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] lowerBound = new int[] {
            9000,
            1,
            10
        };
        Console.WriteLine(string.Format("lowerBound:{0}", string.Join(" ", lowerBound)));
        int[] upperBound = new int[] {
            9000,
            2,
            20
        };
        Console.WriteLine(string.Format("upperBound:{0}", string.Join(" ", upperBound)));
        int __expected = 15;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Over9000Rocks().countPossibilities(lowerBound, upperBound);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] lowerBound = new int[] {
            1001,
            2001,
            3001,
            3001
        };
        Console.WriteLine(string.Format("lowerBound:{0}", string.Join(" ", lowerBound)));
        int[] upperBound = new int[] {
            1003,
            2003,
            3003,
            3003
        };
        Console.WriteLine(string.Format("upperBound:{0}", string.Join(" ", upperBound)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Over9000Rocks().countPossibilities(lowerBound, upperBound);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] lowerBound = new int[] {
            9000,
            90000,
            1,
            10
        };
        Console.WriteLine(string.Format("lowerBound:{0}", string.Join(" ", lowerBound)));
        int[] upperBound = new int[] {
            9000,
            90000,
            3,
            15
        };
        Console.WriteLine(string.Format("upperBound:{0}", string.Join(" ", upperBound)));
        int __expected = 38;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Over9000Rocks().countPossibilities(lowerBound, upperBound);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] lowerBound = new int[] {
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("lowerBound:{0}", string.Join(" ", lowerBound)));
        int[] upperBound = new int[] {
            3,
            4,
            5,
            6,
            7,
            8
        };
        Console.WriteLine(string.Format("upperBound:{0}", string.Join(" ", upperBound)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Over9000Rocks().countPossibilities(lowerBound, upperBound);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
