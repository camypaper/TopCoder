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
    public void ManualTest(int[] tree, int[] A, int[] B)
    {
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ",tree)));
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        Console.WriteLine(string.Format("B:{0}", string.Join(" ",B)));
        int __result = new Treestrat().roundcnt(tree, A, B);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] tree = new int[] {
            0
        };
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ", tree)));
        int[] A = new int[] {
            0
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Treestrat().roundcnt(tree, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] tree = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ", tree)));
        int[] A = new int[] {
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            2
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Treestrat().roundcnt(tree, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] tree = new int[] {
            0,
            0,
            0,
            3,
            4
        };
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ", tree)));
        int[] A = new int[] {
            2
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            1
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Treestrat().roundcnt(tree, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] tree = new int[] {
            0,
            0,
            0,
            3,
            4,
            2
        };
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ", tree)));
        int[] A = new int[] {
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            6
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Treestrat().roundcnt(tree, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] tree = new int[] {
            0,
            0,
            0,
            3,
            4,
            2
        };
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ", tree)));
        int[] A = new int[] {
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            6,
            5
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Treestrat().roundcnt(tree, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] tree = new int[] {
            0,
            0,
            0,
            3,
            4,
            2
        };
        Console.WriteLine(string.Format("tree:{0}", string.Join(" ", tree)));
        int[] A = new int[] {
            4,
            1
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int[] B = new int[] {
            3,
            6
        };
        Console.WriteLine(string.Format("B:{0}", string.Join(" ", B)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Treestrat().roundcnt(tree, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
