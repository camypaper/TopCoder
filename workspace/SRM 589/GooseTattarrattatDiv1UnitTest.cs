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
        string S = Scanner.In.@string();
        Console.WriteLine("S:{0}", S);
        int __result = new GooseTattarrattatDiv1().getmin(S);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string S)
    {
                        Console.WriteLine("S:{0}", S);
                int __result = new GooseTattarrattatDiv1().getmin(S);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string S = "geese";
        Console.WriteLine("S:{0}", S);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GooseTattarrattatDiv1().getmin(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string S = "tattarrattat";
        Console.WriteLine("S:{0}", S);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GooseTattarrattatDiv1().getmin(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string S = "xyyzzzxxx";
        Console.WriteLine("S:{0}", S);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GooseTattarrattatDiv1().getmin(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string S = "xrepayuyubctwtykrauccnquqfuqvccuaakylwlcjuyhyammag";
        Console.WriteLine("S:{0}", S);
        int __expected = 11;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GooseTattarrattatDiv1().getmin(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string S = "abaabb";
        Console.WriteLine("S:{0}", S);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GooseTattarrattatDiv1().getmin(S);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
