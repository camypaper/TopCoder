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
        int[] t = Scanner.In.int_array();
        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
        int[] x = Scanner.In.int_array();
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        int C = Scanner.In.@int();
        Console.WriteLine("C:{0}", C);
        double __result = new WaterTank().minOutputRate(t, x, C);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] t, int[] x, int C)
    {
                        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
                        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
                        Console.WriteLine("C:{0}", C);
                double __result = new WaterTank().minOutputRate(t, x, C);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] t = new int[] {
            3,
            3
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int[] x = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int C = 3;
        Console.WriteLine("C:{0}", C);
        double __expected = 0.9999999999999999;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new WaterTank().minOutputRate(t, x, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] t = new int[] {
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int[] x = new int[] {
            5,
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int C = 10;
        Console.WriteLine("C:{0}", C);
        double __expected = 1.9999999999999996;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new WaterTank().minOutputRate(t, x, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] t = new int[] {
            5949,
            3198,
            376,
            3592,
            4019,
            3481,
            5609,
            3840,
            6092,
            4059
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int[] x = new int[] {
            29,
            38,
            96,
            84,
            10,
            2,
            39,
            27,
            76,
            94
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int C = 1000000000;
        Console.WriteLine("C:{0}", C);
        double __expected = 0.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new WaterTank().minOutputRate(t, x, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] t = new int[] {
            9,
            3,
            4,
            8,
            1,
            2,
            5,
            7,
            6
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int[] x = new int[] {
            123,
            456,
            789,
            1011,
            1213,
            1415,
            1617,
            1819,
            2021
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int C = 11;
        Console.WriteLine("C:{0}", C);
        double __expected = 2019.1666666666665;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new WaterTank().minOutputRate(t, x, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] t = new int[] {
            100
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int[] x = new int[] {
            1000
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int C = 12345;
        Console.WriteLine("C:{0}", C);
        double __expected = 876.55;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new WaterTank().minOutputRate(t, x, C);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
