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
    public void ManualTest(int x)
    {
        Console.WriteLine("x:{0}", x);
        int[] __result = new MultiplicationTable3().construct(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int x = 2;
        Console.WriteLine("x:{0}", x);
        int[] __expected = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new MultiplicationTable3().construct(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int x = 3;
        Console.WriteLine("x:{0}", x);
        int[] __expected = new int[] {
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new MultiplicationTable3().construct(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int x = 6;
        Console.WriteLine("x:{0}", x);
        int[] __expected = new int[] {
            0,
            1,
            1,
            0,
            1,
            2,
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new MultiplicationTable3().construct(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int x = 31;
        Console.WriteLine("x:{0}", x);
        int[] __expected = new int[] {
            0,
            1,
            2,
            3,
            4,
            0,
            1,
            2,
            3,
            4,
            0,
            1,
            2,
            3,
            4,
            0,
            1,
            2,
            3,
            4,
            0,
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new MultiplicationTable3().construct(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        int x = 1;
        Console.WriteLine("x:{0}", x);
        int[] __expected = new int[] {
            0
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new MultiplicationTable3().construct(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
