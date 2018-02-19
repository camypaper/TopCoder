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
    public void ManualTest(long E, long EM, long M, long MH, long H)
    {
        Console.WriteLine("E:{0}", E);
        Console.WriteLine("EM:{0}", EM);
        Console.WriteLine("M:{0}", M);
        Console.WriteLine("MH:{0}", MH);
        Console.WriteLine("H:{0}", H);
        long __result = new ProblemSets().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        long E = 2L;
        Console.WriteLine("E:{0}", E);
        long EM = 2L;
        Console.WriteLine("EM:{0}", EM);
        long M = 1L;
        Console.WriteLine("M:{0}", M);
        long MH = 2L;
        Console.WriteLine("MH:{0}", MH);
        long H = 2L;
        Console.WriteLine("H:{0}", H);
        long __expected = 3L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ProblemSets().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        long E = 100L;
        Console.WriteLine("E:{0}", E);
        long EM = 100L;
        Console.WriteLine("EM:{0}", EM);
        long M = 100L;
        Console.WriteLine("M:{0}", M);
        long MH = 0L;
        Console.WriteLine("MH:{0}", MH);
        long H = 0L;
        Console.WriteLine("H:{0}", H);
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ProblemSets().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        long E = 657L;
        Console.WriteLine("E:{0}", E);
        long EM = 657L;
        Console.WriteLine("EM:{0}", EM);
        long M = 657L;
        Console.WriteLine("M:{0}", M);
        long MH = 657L;
        Console.WriteLine("MH:{0}", MH);
        long H = 657L;
        Console.WriteLine("H:{0}", H);
        long __expected = 1095L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ProblemSets().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        long E = 1L;
        Console.WriteLine("E:{0}", E);
        long EM = 2L;
        Console.WriteLine("EM:{0}", EM);
        long M = 3L;
        Console.WriteLine("M:{0}", M);
        long MH = 4L;
        Console.WriteLine("MH:{0}", MH);
        long H = 5L;
        Console.WriteLine("H:{0}", H);
        long __expected = 3L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ProblemSets().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        long E = 1000000000000000000L;
        Console.WriteLine("E:{0}", E);
        long EM = 1000000000000000000L;
        Console.WriteLine("EM:{0}", EM);
        long M = 1000000000000000000L;
        Console.WriteLine("M:{0}", M);
        long MH = 1000000000000000000L;
        Console.WriteLine("MH:{0}", MH);
        long H = 1000000000000000000L;
        Console.WriteLine("H:{0}", H);
        long __expected = 1666666666666666666L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new ProblemSets().maxSets(E, EM, M, MH, H);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
