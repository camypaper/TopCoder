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
    public void ManualTest(int[] revenues)
    {
        Console.WriteLine(string.Format("revenues:{0}", string.Join(" ",revenues)));
        double __result = new MergersDivOne().findMaximum(revenues);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] revenues = new int[] {
            5,
            -7,
            3
        };
        Console.WriteLine(string.Format("revenues:{0}", string.Join(" ", revenues)));
        double __expected = 1.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new MergersDivOne().findMaximum(revenues);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] revenues = new int[] {
            10,
            -17
        };
        Console.WriteLine(string.Format("revenues:{0}", string.Join(" ", revenues)));
        double __expected = -3.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new MergersDivOne().findMaximum(revenues);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] revenues = new int[] {
            12,
            12,
            12,
            12,
            12
        };
        Console.WriteLine(string.Format("revenues:{0}", string.Join(" ", revenues)));
        double __expected = 12.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new MergersDivOne().findMaximum(revenues);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] revenues = new int[] {
            0,
            0,
            0,
            0,
            0,
            100
        };
        Console.WriteLine(string.Format("revenues:{0}", string.Join(" ", revenues)));
        double __expected = 50.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new MergersDivOne().findMaximum(revenues);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] revenues = new int[] {
            10,
            -10,
            100,
            -100,
            1000,
            -1000
        };
        Console.WriteLine(string.Format("revenues:{0}", string.Join(" ", revenues)));
        double __expected = 491.25;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new MergersDivOne().findMaximum(revenues);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
