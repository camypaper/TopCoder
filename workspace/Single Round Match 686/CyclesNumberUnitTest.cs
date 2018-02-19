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
    public void ManualTest(int[] n, int[] m)
    {
        Console.WriteLine(string.Format("n:{0}", string.Join(" ",n)));
        Console.WriteLine(string.Format("m:{0}", string.Join(" ",m)));
        int[] __result = new CyclesNumber().getExpectation(n, m);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int[] n = new int[] {
            2
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int[] m = new int[] {
            2
        };
        Console.WriteLine(string.Format("m:{0}", string.Join(" ", m)));
        int[] __expected = new int[] {
            5
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CyclesNumber().getExpectation(n, m);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int[] n = new int[] {
            3
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int[] m = new int[] {
            0
        };
        Console.WriteLine(string.Format("m:{0}", string.Join(" ", m)));
        int[] __expected = new int[] {
            6
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CyclesNumber().getExpectation(n, m);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int[] n = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int[] m = new int[] {
            1,
            3,
            3
        };
        Console.WriteLine(string.Format("m:{0}", string.Join(" ", m)));
        int[] __expected = new int[] {
            1,
            9,
            53
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CyclesNumber().getExpectation(n, m);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int[] n = new int[] {
            10,
            20,
            30
        };
        Console.WriteLine(string.Format("n:{0}", string.Join(" ", n)));
        int[] m = new int[] {
            10,
            20,
            30
        };
        Console.WriteLine(string.Format("m:{0}", string.Join(" ", m)));
        int[] __expected = new int[] {
            586836447,
            544389755,
            327675273
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CyclesNumber().getExpectation(n, m);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
