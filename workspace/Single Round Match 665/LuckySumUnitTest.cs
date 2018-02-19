using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        string note = Scanner.In.@string();
        Console.WriteLine("note:{0}", note);
        long __result = new LuckySum().construct(note);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string note)
    {
                        Console.WriteLine("note:{0}", note);
                long __result = new LuckySum().construct(note);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string note = "?";
        Console.WriteLine("note:{0}", note);
        long __expected = 8L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new LuckySum().construct(note);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string note = "?1";
        Console.WriteLine("note:{0}", note);
        long __expected = 11L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new LuckySum().construct(note);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string note = "4?8";
        Console.WriteLine("note:{0}", note);
        long __expected = 448L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new LuckySum().construct(note);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string note = "2??";
        Console.WriteLine("note:{0}", note);
        long __expected = -1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new LuckySum().construct(note);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string note = "??????????????";
        Console.WriteLine("note:{0}", note);
        long __expected = 11888888888888L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new LuckySum().construct(note);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
