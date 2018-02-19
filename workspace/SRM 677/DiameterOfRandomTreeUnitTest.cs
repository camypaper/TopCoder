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
    public void ManualTest(int[] a, int[] b)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        double __result = new DiameterOfRandomTree().getExpectation(a, b);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        double __expected = 6.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new DiameterOfRandomTree().getExpectation(a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        double __expected = 3.375;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new DiameterOfRandomTree().getExpectation(a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            0,
            0,
            0,
            1,
            4
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        double __expected = 6.25;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new DiameterOfRandomTree().getExpectation(a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        double __expected = 3.9609375;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new DiameterOfRandomTree().getExpectation(a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] a = new int[] {
            0,
            0,
            0,
            1,
            2,
            3,
            5,
            6,
            8
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
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
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        double __expected = 10.53125;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new DiameterOfRandomTree().getExpectation(a, b);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
