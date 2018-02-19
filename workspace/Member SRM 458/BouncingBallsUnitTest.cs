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
    public void ManualTest(int[] x, int T)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine("T:{0}", T);
        double __result = new BouncingBalls().expectedBounces(x, T);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int T = 2;
        Console.WriteLine("T:{0}", T);
        double __expected = 0.25;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BouncingBalls().expectedBounces(x, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int T = 1;
        Console.WriteLine("T:{0}", T);
        double __expected = 0.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BouncingBalls().expectedBounces(x, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            91,
            857,
            692,
            54,
            8679,
            83,
            792,
            86,
            9537,
            913,
            64,
            592
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int T = 458;
        Console.WriteLine("T:{0}", T);
        double __expected = 11.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BouncingBalls().expectedBounces(x, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            75432
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int T = 386;
        Console.WriteLine("T:{0}", T);
        double __expected = 0.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BouncingBalls().expectedBounces(x, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int T = 3;
        Console.WriteLine("T:{0}", T);
        double __expected = 12.75;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BouncingBalls().expectedBounces(x, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
