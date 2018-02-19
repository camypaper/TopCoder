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
    public void ManualTest(int N, int[] from, int[] to)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("from:{0}", string.Join(" ",from)));
        Console.WriteLine(string.Format("to:{0}", string.Join(" ",to)));
        string __result = new WalkingToSchool().canWalkExactly(N, from, to);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] from = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("from:{0}", string.Join(" ", from)));
        int[] to = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("to:{0}", string.Join(" ", to)));
        string __expected = "Chores";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new WalkingToSchool().canWalkExactly(N, from, to);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int[] from = new int[] {
            0,
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("from:{0}", string.Join(" ", from)));
        int[] to = new int[] {
            1,
            0,
            2,
            0
        };
        Console.WriteLine(string.Format("to:{0}", string.Join(" ", to)));
        string __expected = "Freedom";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new WalkingToSchool().canWalkExactly(N, from, to);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int[] from = new int[] {
            0,
            2,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("from:{0}", string.Join(" ", from)));
        int[] to = new int[] {
            2,
            0,
            3,
            0,
            1
        };
        Console.WriteLine(string.Format("to:{0}", string.Join(" ", to)));
        string __expected = "Chores";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new WalkingToSchool().canWalkExactly(N, from, to);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 10;
        Console.WriteLine("N:{0}", N);
        int[] from = new int[] {
            0,
            0,
            0,
            0,
            0,
            1,
            1,
            2,
            2,
            2,
            2,
            3,
            3,
            5,
            5,
            5,
            6,
            6,
            6,
            7,
            8,
            9,
            9,
            9,
            9
        };
        Console.WriteLine(string.Format("from:{0}", string.Join(" ", from)));
        int[] to = new int[] {
            4,
            5,
            6,
            7,
            9,
            4,
            6,
            0,
            1,
            3,
            8,
            4,
            6,
            1,
            4,
            8,
            1,
            7,
            8,
            1,
            4,
            2,
            5,
            6,
            8
        };
        Console.WriteLine(string.Format("to:{0}", string.Join(" ", to)));
        string __expected = "Chores";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new WalkingToSchool().canWalkExactly(N, from, to);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 8;
        Console.WriteLine("N:{0}", N);
        int[] from = new int[] {
            0,
            1,
            4,
            6,
            7,
            5,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("from:{0}", string.Join(" ", from)));
        int[] to = new int[] {
            1,
            4,
            6,
            7,
            5,
            2,
            3,
            0,
            7
        };
        Console.WriteLine(string.Format("to:{0}", string.Join(" ", to)));
        string __expected = "Freedom";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new WalkingToSchool().canWalkExactly(N, from, to);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int N = 2000;
        Console.WriteLine("N:{0}", N);
        int[] from = new int[] {
        };
        Console.WriteLine(string.Format("from:{0}", string.Join(" ", from)));
        int[] to = new int[] {
        };
        Console.WriteLine(string.Format("to:{0}", string.Join(" ", to)));
        string __expected = "Chores";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new WalkingToSchool().canWalkExactly(N, from, to);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
