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
    public void ManualTest(int[] sticks, int C, int K)
    {
        Console.WriteLine(string.Format("sticks:{0}", string.Join(" ",sticks)));
        Console.WriteLine("C:{0}", C);
        Console.WriteLine("K:{0}", K);
        double __result = new CutSticks().maxKth(sticks, C, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] sticks = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("sticks:{0}", string.Join(" ", sticks)));
        int C = 1;
        Console.WriteLine("C:{0}", C);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        double __expected = 8.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CutSticks().maxKth(sticks, C, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] sticks = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("sticks:{0}", string.Join(" ", sticks)));
        int C = 1;
        Console.WriteLine("C:{0}", C);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        double __expected = 5.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CutSticks().maxKth(sticks, C, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] sticks = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("sticks:{0}", string.Join(" ", sticks)));
        int C = 1;
        Console.WriteLine("C:{0}", C);
        int K = 3;
        Console.WriteLine("K:{0}", K);
        double __expected = 4.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CutSticks().maxKth(sticks, C, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] sticks = new int[] {
            1000000000,
            1000000000,
            1
        };
        Console.WriteLine(string.Format("sticks:{0}", string.Join(" ", sticks)));
        int C = 2;
        Console.WriteLine("C:{0}", C);
        int K = 5;
        Console.WriteLine("K:{0}", K);
        double __expected = 1.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CutSticks().maxKth(sticks, C, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] sticks = new int[] {
            76,
            594,
            17,
            6984,
            26,
            57,
            9,
            876,
            5816,
            73,
            969,
            527,
            49
        };
        Console.WriteLine(string.Format("sticks:{0}", string.Join(" ", sticks)));
        int C = 789;
        Console.WriteLine("C:{0}", C);
        int K = 456;
        Console.WriteLine("K:{0}", K);
        double __expected = 34.92;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new CutSticks().maxKth(sticks, C, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
