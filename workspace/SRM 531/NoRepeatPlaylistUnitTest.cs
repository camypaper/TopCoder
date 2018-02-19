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
    public void ManualTest(int N, int M, int P)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("M:{0}", M);
        Console.WriteLine("P:{0}", P);
        int __result = new NoRepeatPlaylist().numPlaylists(N, M, P);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int M = 0;
        Console.WriteLine("M:{0}", M);
        int P = 3;
        Console.WriteLine("P:{0}", P);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NoRepeatPlaylist().numPlaylists(N, M, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int M = 1;
        Console.WriteLine("M:{0}", M);
        int P = 3;
        Console.WriteLine("P:{0}", P);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NoRepeatPlaylist().numPlaylists(N, M, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int M = 0;
        Console.WriteLine("M:{0}", M);
        int P = 3;
        Console.WriteLine("P:{0}", P);
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NoRepeatPlaylist().numPlaylists(N, M, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int M = 0;
        Console.WriteLine("M:{0}", M);
        int P = 4;
        Console.WriteLine("P:{0}", P);
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NoRepeatPlaylist().numPlaylists(N, M, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int M = 1;
        Console.WriteLine("M:{0}", M);
        int P = 4;
        Console.WriteLine("P:{0}", P);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NoRepeatPlaylist().numPlaylists(N, M, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int N = 50;
        Console.WriteLine("N:{0}", N);
        int M = 5;
        Console.WriteLine("M:{0}", M);
        int P = 100;
        Console.WriteLine("P:{0}", P);
        int __expected = 222288991;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new NoRepeatPlaylist().numPlaylists(N, M, P);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
