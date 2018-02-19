using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);Tests.Add(Example7);Tests.Add(Example8);Tests.Add(Example9);    }
    public void ManualTest(int n, int k, int[] x, int[] y)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("k:{0}", k);
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine(string.Format("y:{0}", string.Join(" ",y)));
        string __result = new DarkMatterParticles().SplitParticles(n, k, x, y);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int[] x = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DarkMatterParticles().SplitParticles(n, k, x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int k = 4;
        Console.WriteLine("k:{0}", k);
        int[] x = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DarkMatterParticles().SplitParticles(n, k, x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int[] x = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            2,
            3,
            0,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DarkMatterParticles().SplitParticles(n, k, x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int[] x = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            2,
            3,
            0,
            1
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DarkMatterParticles().SplitParticles(n, k, x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int[] x = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DarkMatterParticles().SplitParticles(n, k, x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int[] x = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            0
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DarkMatterParticles().SplitParticles(n, k, x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int[] x = new int[] {
            0,
            1,
            4
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            5
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DarkMatterParticles().SplitParticles(n, k, x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example7()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int[] x = new int[] {
            0,
            1,
            4
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            5
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DarkMatterParticles().SplitParticles(n, k, x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example8()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int[] x = new int[] {
            0,
            1,
            4
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            5
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DarkMatterParticles().SplitParticles(n, k, x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example9()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int k = 6;
        Console.WriteLine("k:{0}", k);
        int[] x = new int[] {
            0,
            1,
            4
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] y = new int[] {
            1,
            2,
            5
        };
        Console.WriteLine(string.Format("y:{0}", string.Join(" ", y)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new DarkMatterParticles().SplitParticles(n, k, x, y);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
