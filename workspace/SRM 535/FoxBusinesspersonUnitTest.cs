using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);    }
    public void ManualTest(int K, int totalWork, int[] a, int[] p)
    {
        Console.WriteLine("K:{0}", K);
        Console.WriteLine("totalWork:{0}", totalWork);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("p:{0}", string.Join(" ",p)));
        double __result = new FoxAndBusiness().minimumCost(K, totalWork, a, p);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int totalWork = 10;
        Console.WriteLine("totalWork:{0}", totalWork);
        int[] a = new int[] {
            10
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] p = new int[] {
            20
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        double __expected = 3800.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new FoxAndBusiness().minimumCost(K, totalWork, a, p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int totalWork = 100;
        Console.WriteLine("totalWork:{0}", totalWork);
        int[] a = new int[] {
            50,
            60
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] p = new int[] {
            1000,
            2000
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        double __expected = 107200.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new FoxAndBusiness().minimumCost(K, totalWork, a, p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int totalWork = 300;
        Console.WriteLine("totalWork:{0}", totalWork);
        int[] a = new int[] {
            10,
            20,
            47
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] p = new int[] {
            15,
            20,
            98765
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        double __expected = 77500.0;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new FoxAndBusiness().minimumCost(K, totalWork, a, p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int K = 4;
        Console.WriteLine("K:{0}", K);
        int totalWork = 1000;
        Console.WriteLine("totalWork:{0}", totalWork);
        int[] a = new int[] {
            1,
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
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] p = new int[] {
            20,
            30,
            40,
            58,
            60,
            70,
            80,
            90,
            100,
            150
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        double __expected = 531764.705882353;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new FoxAndBusiness().minimumCost(K, totalWork, a, p);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
