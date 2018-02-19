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
        int n = Scanner.In.@int();
        Console.WriteLine("n:{0}", n);
        int k = Scanner.In.@int();
        Console.WriteLine("k:{0}", k);
        int __result = new PairsOfStrings().getNumber(n, k);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int n, int k)
    {
                        Console.WriteLine("n:{0}", n);
                        Console.WriteLine("k:{0}", k);
                int __result = new PairsOfStrings().getNumber(n, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PairsOfStrings().getNumber(n, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 20;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PairsOfStrings().getNumber(n, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int k = 4;
        Console.WriteLine("k:{0}", k);
        int __expected = 184;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PairsOfStrings().getNumber(n, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 348;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PairsOfStrings().getNumber(n, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 100;
        Console.WriteLine("n:{0}", n);
        int k = 26;
        Console.WriteLine("k:{0}", k);
        int __expected = 46519912;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PairsOfStrings().getNumber(n, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
