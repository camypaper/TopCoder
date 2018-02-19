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
    public void ManualTest(int[] knob1, int[] knob2)
    {
        Console.WriteLine(string.Format("knob1:{0}", string.Join(" ",knob1)));
        Console.WriteLine(string.Format("knob2:{0}", string.Join(" ",knob2)));
        long __result = new HatRack().countWays(knob1, knob2);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] knob1 = new int[] {
            1
        };
        Console.WriteLine(string.Format("knob1:{0}", string.Join(" ", knob1)));
        int[] knob2 = new int[] {
            2
        };
        Console.WriteLine(string.Format("knob2:{0}", string.Join(" ", knob2)));
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HatRack().countWays(knob1, knob2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] knob1 = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("knob1:{0}", string.Join(" ", knob1)));
        int[] knob2 = new int[] {
            2,
            3
        };
        Console.WriteLine(string.Format("knob2:{0}", string.Join(" ", knob2)));
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HatRack().countWays(knob1, knob2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] knob1 = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("knob1:{0}", string.Join(" ", knob1)));
        int[] knob2 = new int[] {
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("knob2:{0}", string.Join(" ", knob2)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HatRack().countWays(knob1, knob2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] knob1 = new int[] {
            6,
            6,
            6,
            4,
            1
        };
        Console.WriteLine(string.Format("knob1:{0}", string.Join(" ", knob1)));
        int[] knob2 = new int[] {
            1,
            2,
            4,
            5,
            3
        };
        Console.WriteLine(string.Format("knob2:{0}", string.Join(" ", knob2)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HatRack().countWays(knob1, knob2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] knob1 = new int[] {
            1,
            1,
            2,
            2,
            11,
            11,
            8,
            8,
            3,
            3,
            4,
            4,
            5
        };
        Console.WriteLine(string.Format("knob1:{0}", string.Join(" ", knob1)));
        int[] knob2 = new int[] {
            2,
            3,
            11,
            8,
            12,
            13,
            9,
            10,
            4,
            5,
            7,
            6,
            14
        };
        Console.WriteLine(string.Format("knob2:{0}", string.Join(" ", knob2)));
        long __expected = 16L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HatRack().countWays(knob1, knob2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] knob1 = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9
        };
        Console.WriteLine(string.Format("knob1:{0}", string.Join(" ", knob1)));
        int[] knob2 = new int[] {
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10
        };
        Console.WriteLine(string.Format("knob2:{0}", string.Join(" ", knob2)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HatRack().countWays(knob1, knob2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
