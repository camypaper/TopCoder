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
    public void ManualTest(int[] a)
    {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        double __result = new Privateparty().getexp(a);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        double __expected = 2.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Privateparty().getexp(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        double __expected = 1.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Privateparty().getexp(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        double __expected = 2.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Privateparty().getexp(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            0,
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        double __expected = 3.166666666666667;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Privateparty().getexp(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int[] a = new int[] {
            3,
            2,
            1,
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        double __expected = 2.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Privateparty().getexp(a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
