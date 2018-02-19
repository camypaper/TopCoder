using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int[] numbers = Scanner.In.int_array();
        Console.WriteLine(string.Format("numbers:{0}", string.Join(" ",numbers)));
        int goal = Scanner.In.@int();
        Console.WriteLine("goal:{0}", goal);
        int __result = new ORSolitaire().getMinimum(numbers, goal);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] numbers, int goal)
    {
                        Console.WriteLine(string.Format("numbers:{0}", string.Join(" ",numbers)));
                        Console.WriteLine("goal:{0}", goal);
                int __result = new ORSolitaire().getMinimum(numbers, goal);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] numbers = new int[] {
            1,
            2,
            4
        };
        Console.WriteLine(string.Format("numbers:{0}", string.Join(" ", numbers)));
        int goal = 7;
        Console.WriteLine("goal:{0}", goal);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ORSolitaire().getMinimum(numbers, goal);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] numbers = new int[] {
            1,
            2,
            4,
            7,
            8
        };
        Console.WriteLine(string.Format("numbers:{0}", string.Join(" ", numbers)));
        int goal = 7;
        Console.WriteLine("goal:{0}", goal);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ORSolitaire().getMinimum(numbers, goal);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] numbers = new int[] {
            12571295,
            2174218,
            2015120
        };
        Console.WriteLine(string.Format("numbers:{0}", string.Join(" ", numbers)));
        int goal = 1;
        Console.WriteLine("goal:{0}", goal);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ORSolitaire().getMinimum(numbers, goal);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] numbers = new int[] {
            5,
            2,
            4,
            52,
            62,
            9,
            8,
            3,
            1,
            11,
            6
        };
        Console.WriteLine(string.Format("numbers:{0}", string.Join(" ", numbers)));
        int goal = 11;
        Console.WriteLine("goal:{0}", goal);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ORSolitaire().getMinimum(numbers, goal);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] numbers = new int[] {
            503,
            505,
            152,
            435,
            491,
            512,
            1023,
            355,
            510,
            500,
            502,
            255,
            63,
            508,
            509,
            511,
            60,
            250,
            254,
            346
        };
        Console.WriteLine(string.Format("numbers:{0}", string.Join(" ", numbers)));
        int goal = 510;
        Console.WriteLine("goal:{0}", goal);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ORSolitaire().getMinimum(numbers, goal);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
