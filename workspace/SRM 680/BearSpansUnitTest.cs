using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);    }
    public void ManualTest(int n, int m, int k)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("m:{0}", m);
        Console.WriteLine("k:{0}", k);
        int[] __result = new BearSpans().findAnyGraph(n, m, k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int n = 17;
        Console.WriteLine("n:{0}", n);
        int m = 22;
        Console.WriteLine("m:{0}", m);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            1,
            2,
            1,
            3,
            1,
            4,
            1,
            5,
            1,
            6,
            1,
            7,
            1,
            8,
            1,
            9,
            1,
            10,
            1,
            11,
            1,
            12,
            1,
            13,
            1,
            14,
            1,
            15,
            1,
            16,
            1,
            17,
            2,
            3,
            2,
            8,
            3,
            9,
            8,
            9,
            10,
            12,
            12,
            14
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearSpans().findAnyGraph(n, m, k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int n = 9;
        Console.WriteLine("n:{0}", n);
        int m = 12;
        Console.WriteLine("m:{0}", m);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            6,
            5,
            7,
            6,
            1,
            2,
            3,
            4,
            8,
            9,
            3,
            5,
            7,
            4,
            1,
            9,
            6,
            2,
            6,
            1,
            1,
            8,
            4,
            5
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearSpans().findAnyGraph(n, m, k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int n = 9;
        Console.WriteLine("n:{0}", n);
        int m = 12;
        Console.WriteLine("m:{0}", m);
        int k = 7;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearSpans().findAnyGraph(n, m, k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int n = 1000;
        Console.WriteLine("n:{0}", n);
        int m = 999;
        Console.WriteLine("m:{0}", m);
        int k = 970;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearSpans().findAnyGraph(n, m, k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearSpans().findAnyGraph(n, m, k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example5()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            1,
            2,
            1,
            3
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearSpans().findAnyGraph(n, m, k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example6()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int m = 3;
        Console.WriteLine("m:{0}", m);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearSpans().findAnyGraph(n, m, k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
