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
    public void ManualTest(int E, int EM, int M, int MH, int H)
    {
        Console.WriteLine("E:{0}", E);
        Console.WriteLine("EM:{0}", EM);
        Console.WriteLine("M:{0}", M);
        Console.WriteLine("MH:{0}", MH);
        Console.WriteLine("H:{0}", H);
        int __result = new ProblemSetsEasy().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int E = 2;
        Console.WriteLine("E:{0}", E);
        int EM = 2;
        Console.WriteLine("EM:{0}", EM);
        int M = 1;
        Console.WriteLine("M:{0}", M);
        int MH = 2;
        Console.WriteLine("MH:{0}", MH);
        int H = 2;
        Console.WriteLine("H:{0}", H);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ProblemSetsEasy().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int E = 100;
        Console.WriteLine("E:{0}", E);
        int EM = 100;
        Console.WriteLine("EM:{0}", EM);
        int M = 100;
        Console.WriteLine("M:{0}", M);
        int MH = 0;
        Console.WriteLine("MH:{0}", MH);
        int H = 0;
        Console.WriteLine("H:{0}", H);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ProblemSetsEasy().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int E = 657;
        Console.WriteLine("E:{0}", E);
        int EM = 657;
        Console.WriteLine("EM:{0}", EM);
        int M = 657;
        Console.WriteLine("M:{0}", M);
        int MH = 657;
        Console.WriteLine("MH:{0}", MH);
        int H = 657;
        Console.WriteLine("H:{0}", H);
        int __expected = 1095;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ProblemSetsEasy().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int E = 1;
        Console.WriteLine("E:{0}", E);
        int EM = 2;
        Console.WriteLine("EM:{0}", EM);
        int M = 3;
        Console.WriteLine("M:{0}", M);
        int MH = 4;
        Console.WriteLine("MH:{0}", MH);
        int H = 5;
        Console.WriteLine("H:{0}", H);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ProblemSetsEasy().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int E = 100000;
        Console.WriteLine("E:{0}", E);
        int EM = 100000;
        Console.WriteLine("EM:{0}", EM);
        int M = 100000;
        Console.WriteLine("M:{0}", M);
        int MH = 100000;
        Console.WriteLine("MH:{0}", MH);
        int H = 100000;
        Console.WriteLine("H:{0}", H);
        int __expected = 166666;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ProblemSetsEasy().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
