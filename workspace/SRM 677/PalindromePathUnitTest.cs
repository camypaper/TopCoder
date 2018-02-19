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
    public void ManualTest(int n, int[] a, int[] b, string c)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        Console.WriteLine("c:{0}", c);
        int __result = new PalindromePath().shortestLength(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            2,
            2,
            0,
            3,
            4
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            0,
            1,
            3,
            4,
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string c = "abxyx";
        Console.WriteLine("c:{0}", c);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromePath().shortestLength(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            2,
            2,
            0,
            3,
            4
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            0,
            1,
            3,
            4,
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string c = "abxyz";
        Console.WriteLine("c:{0}", c);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromePath().shortestLength(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 7;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            0,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            2,
            3,
            4,
            5,
            6,
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string c = "abaaaa";
        Console.WriteLine("c:{0}", c);
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromePath().shortestLength(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            0,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            2,
            3,
            4,
            5,
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string c = "abaaa";
        Console.WriteLine("c:{0}", c);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromePath().shortestLength(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string c = "x";
        Console.WriteLine("c:{0}", c);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromePath().shortestLength(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int n = 20;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            18
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            19
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        string c = "z";
        Console.WriteLine("c:{0}", c);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromePath().shortestLength(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
