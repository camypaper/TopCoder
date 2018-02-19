using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, 5, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            case 5: Example5(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        string s = Scanner.In.@string();
        Console.WriteLine("s:{0}", s);
        string t = Scanner.In.@string();
        Console.WriteLine("t:{0}", t);
        string __result = new InfiniteString().equal(s, t);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string s, string t)
    {
                        Console.WriteLine("s:{0}", s);
                        Console.WriteLine("t:{0}", t);
                string __result = new InfiniteString().equal(s, t);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "ab";
        Console.WriteLine("s:{0}", s);
        string t = "abab";
        Console.WriteLine("t:{0}", t);
        string __expected = "Equal";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new InfiniteString().equal(s, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "abc";
        Console.WriteLine("s:{0}", s);
        string t = "bca";
        Console.WriteLine("t:{0}", t);
        string __expected = "Not equal";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new InfiniteString().equal(s, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "abab";
        Console.WriteLine("s:{0}", s);
        string t = "aba";
        Console.WriteLine("t:{0}", t);
        string __expected = "Not equal";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new InfiniteString().equal(s, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "aaaaa";
        Console.WriteLine("s:{0}", s);
        string t = "aaaaaa";
        Console.WriteLine("t:{0}", t);
        string __expected = "Equal";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new InfiniteString().equal(s, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "ababab";
        Console.WriteLine("s:{0}", s);
        string t = "abab";
        Console.WriteLine("t:{0}", t);
        string __expected = "Equal";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new InfiniteString().equal(s, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string s = "a";
        Console.WriteLine("s:{0}", s);
        string t = "z";
        Console.WriteLine("t:{0}", t);
        string __expected = "Not equal";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new InfiniteString().equal(s, t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
