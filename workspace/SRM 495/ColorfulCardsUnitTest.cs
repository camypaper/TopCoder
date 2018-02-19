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
    public void ManualTest(int N, string colors)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("colors:{0}", colors);
        int[] __result = new ColorfulCards().theCards(N, colors);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        string colors = "RRR";
        Console.WriteLine("colors:{0}", colors);
        int[] __expected = new int[] {
            2,
            3,
            5
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ColorfulCards().theCards(N, colors);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int N = 7;
        Console.WriteLine("N:{0}", N);
        string colors = "BBB";
        Console.WriteLine("colors:{0}", colors);
        int[] __expected = new int[] {
            1,
            4,
            6
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ColorfulCards().theCards(N, colors);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int N = 6;
        Console.WriteLine("N:{0}", N);
        string colors = "RBR";
        Console.WriteLine("colors:{0}", colors);
        int[] __expected = new int[] {
            -1,
            4,
            5
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ColorfulCards().theCards(N, colors);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int N = 58;
        Console.WriteLine("N:{0}", N);
        string colors = "RBRRBRBBRBRRBBRRBBBRRBBBRR";
        Console.WriteLine("colors:{0}", colors);
        int[] __expected = new int[] {
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            17,
            18,
            19,
            23,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            47,
            53
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ColorfulCards().theCards(N, colors);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        int N = 495;
        Console.WriteLine("N:{0}", N);
        string colors = "RBRRBRBBRBRRBBRRBBBRRBBBRR";
        Console.WriteLine("colors:{0}", colors);
        int[] __expected = new int[] {
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1,
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ColorfulCards().theCards(N, colors);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
