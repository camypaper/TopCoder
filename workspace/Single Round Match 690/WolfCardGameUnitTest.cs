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
    public void ManualTest(int N, int K)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        int[] __result = new WolfCardGame().createAnswer(N, K);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int N = 20;
        Console.WriteLine("N:{0}", N);
        int K = 4;
        Console.WriteLine("K:{0}", K);
        int[] __expected = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new WolfCardGame().createAnswer(N, K);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int N = 40;
        Console.WriteLine("N:{0}", N);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int[] __expected = new int[] {
            39
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new WolfCardGame().createAnswer(N, K);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int N = 97;
        Console.WriteLine("N:{0}", N);
        int K = 6;
        Console.WriteLine("K:{0}", K);
        int[] __expected = new int[] {
            7,
            68,
            9,
            10,
            62,
            58
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new WolfCardGame().createAnswer(N, K);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int K = 12;
        Console.WriteLine("K:{0}", K);
        int[] __expected = new int[] {
            33,
            69,
            42,
            45,
            96,
            15,
            57,
            12,
            93,
            9,
            54,
            99
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new WolfCardGame().createAnswer(N, K);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
