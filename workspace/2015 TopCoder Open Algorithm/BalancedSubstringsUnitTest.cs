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
        int __result = new BalancedSubstrings().countSubstrings(s);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string s)
    {
                        Console.WriteLine("s:{0}", s);
                int __result = new BalancedSubstrings().countSubstrings(s);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = "011";
        Console.WriteLine("s:{0}", s);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BalancedSubstrings().countSubstrings(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "10111";
        Console.WriteLine("s:{0}", s);
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BalancedSubstrings().countSubstrings(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "00000";
        Console.WriteLine("s:{0}", s);
        int __expected = 15;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BalancedSubstrings().countSubstrings(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "0000001000000";
        Console.WriteLine("s:{0}", s);
        int __expected = 91;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BalancedSubstrings().countSubstrings(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "100110001001";
        Console.WriteLine("s:{0}", s);
        int __expected = 49;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BalancedSubstrings().countSubstrings(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
