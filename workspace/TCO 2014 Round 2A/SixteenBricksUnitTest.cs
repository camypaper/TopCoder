using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int[] height = Scanner.In.int_array();
        Console.WriteLine(string.Format("height:{0}", string.Join(" ",height)));
        int __result = new SixteenBricks().maximumSurface(height);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] height)
    {
                        Console.WriteLine(string.Format("height:{0}", string.Join(" ",height)));
                int __result = new SixteenBricks().maximumSurface(height);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] height = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("height:{0}", string.Join(" ", height)));
        int __expected = 32;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SixteenBricks().maximumSurface(height);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] height = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("height:{0}", string.Join(" ", height)));
        int __expected = 64;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SixteenBricks().maximumSurface(height);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] height = new int[] {
            77,
            78,
            58,
            34,
            30,
            20,
            8,
            71,
            37,
            74,
            21,
            45,
            39,
            16,
            4,
            59
        };
        Console.WriteLine(string.Format("height:{0}", string.Join(" ", height)));
        int __expected = 1798;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SixteenBricks().maximumSurface(height);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
