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
    public void ManualTest(int N, int M, string[] a)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("M:{0}", M);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        int __result = new CampLunch().count(N, M, a);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int M = 2;
        Console.WriteLine("M:{0}", M);
        string[] a = new string[] {
            "AB",
            "AB"
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CampLunch().count(N, M, a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int M = 3;
        Console.WriteLine("M:{0}", M);
        string[] a = new string[] {
            "ABC",
            "ABC"
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 22;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CampLunch().count(N, M, a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int M = 3;
        Console.WriteLine("M:{0}", M);
        string[] a = new string[] {
            "ABC",
            "BAC"
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 21;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CampLunch().count(N, M, a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int M = 1;
        Console.WriteLine("M:{0}", M);
        string[] a = new string[] {
            "A"
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CampLunch().count(N, M, a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int M = 10;
        Console.WriteLine("M:{0}", M);
        string[] a = new string[] {
            "ABDEFHIGJC"
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 89;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CampLunch().count(N, M, a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int N = 16;
        Console.WriteLine("N:{0}", N);
        int M = 16;
        Console.WriteLine("M:{0}", M);
        string[] a = new string[] {
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP",
            "ABCDEFGHIJKLMNOP"
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int __expected = 950052677;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CampLunch().count(N, M, a);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
