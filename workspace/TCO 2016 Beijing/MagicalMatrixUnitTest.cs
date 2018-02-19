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
    public void ManualTest(int n, int m, int[] prob)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("m:{0}", m);
        Console.WriteLine(string.Format("prob:{0}", string.Join(" ",prob)));
        double __result = new MagicalMatrix().MagicalInspection(n, m, prob);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 1;
        Console.WriteLine("n:{0}", n);
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int[] prob = new int[] {
            50
        };
        Console.WriteLine(string.Format("prob:{0}", string.Join(" ", prob)));
        double __expected = 1.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new MagicalMatrix().MagicalInspection(n, m, prob);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int n = 1;
        Console.WriteLine("n:{0}", n);
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int[] prob = new int[] {
            99
        };
        Console.WriteLine(string.Format("prob:{0}", string.Join(" ", prob)));
        double __expected = 1.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new MagicalMatrix().MagicalInspection(n, m, prob);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int[] prob = new int[] {
            50,
            50,
            50,
            50
        };
        Console.WriteLine(string.Format("prob:{0}", string.Join(" ", prob)));
        double __expected = 2.625;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new MagicalMatrix().MagicalInspection(n, m, prob);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 3;
        Console.WriteLine("m:{0}", m);
        int[] prob = new int[] {
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("prob:{0}", string.Join(" ", prob)));
        double __expected = 3.0296970101000005;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new MagicalMatrix().MagicalInspection(n, m, prob);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int[] prob = new int[] {
            60,
            70,
            90,
            80
        };
        Console.WriteLine(string.Format("prob:{0}", string.Join(" ", prob)));
        double __expected = 2.382;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new MagicalMatrix().MagicalInspection(n, m, prob);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
