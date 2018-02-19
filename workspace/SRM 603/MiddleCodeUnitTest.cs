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
        string s = Scanner.In.@string();
        Console.WriteLine("s:{0}", s);
        string __result = new MiddleCode().encode(s);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string s)
    {
                        Console.WriteLine("s:{0}", s);
                string __result = new MiddleCode().encode(s);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "word";
        Console.WriteLine("s:{0}", s);
        string __expected = "ordw";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new MiddleCode().encode(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "aaaaa";
        Console.WriteLine("s:{0}", s);
        string __expected = "aaaaa";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new MiddleCode().encode(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "abacaba";
        Console.WriteLine("s:{0}", s);
        string __expected = "caabbaa";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new MiddleCode().encode(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "shjegr";
        Console.WriteLine("s:{0}", s);
        string __expected = "ejghrs";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new MiddleCode().encode(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "adafaaaadafawafwfasdaa";
        Console.WriteLine("s:{0}", s);
        string __expected = "afawadafawafaafsadadaa";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new MiddleCode().encode(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
