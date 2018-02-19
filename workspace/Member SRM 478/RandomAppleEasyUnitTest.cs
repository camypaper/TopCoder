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
    public void ManualTest(int[] red, int[] green)
    {
        Console.WriteLine(string.Format("red:{0}", string.Join(" ",red)));
        Console.WriteLine(string.Format("green:{0}", string.Join(" ",green)));
        double __result = new RandomAppleEasy().theRed(red, green);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] red = new int[] {
            5
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            8
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        double __expected = 0.38461538461538464;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomAppleEasy().theRed(red, green);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] red = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        double __expected = 0.5888888888888888;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomAppleEasy().theRed(red, green);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] red = new int[] {
            2,
            5,
            6,
            4,
            9,
            10,
            6,
            2
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            2,
            5,
            6,
            4,
            9,
            10,
            6,
            2
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        double __expected = 0.4999999999999999;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomAppleEasy().theRed(red, green);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] red = new int[] {
            2,
            5,
            6,
            4,
            9,
            10,
            6,
            2
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            6,
            7,
            4,
            5,
            3,
            2,
            9,
            1
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        double __expected = 0.5429014970733334;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomAppleEasy().theRed(red, green);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] red = new int[] {
            5,
            1,
            2,
            8,
            4,
            1,
            1,
            2,
            3,
            4,
            5,
            2,
            10,
            2,
            6,
            2,
            8,
            7,
            9,
            3
        };
        Console.WriteLine(string.Format("red:{0}", string.Join(" ", red)));
        int[] green = new int[] {
            4,
            7,
            1,
            1,
            10,
            3,
            4,
            1,
            6,
            2,
            7,
            6,
            10,
            5,
            2,
            9,
            3,
            8,
            1,
            8
        };
        Console.WriteLine(string.Format("green:{0}", string.Join(" ", green)));
        double __expected = 0.46460213827476854;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new RandomAppleEasy().theRed(red, green);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
