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
        int A = Scanner.In.@int();
        Console.WriteLine("A:{0}", A);
        int B = Scanner.In.@int();
        Console.WriteLine("B:{0}", B);
        int K = Scanner.In.@int();
        Console.WriteLine("K:{0}", K);
        int __result = new BearPlays().pileSize(A, B, K);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int A, int B, int K)
    {
                        Console.WriteLine("A:{0}", A);
                        Console.WriteLine("B:{0}", B);
                        Console.WriteLine("K:{0}", K);
                int __result = new BearPlays().pileSize(A, B, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int A = 4;
        Console.WriteLine("A:{0}", A);
        int B = 7;
        Console.WriteLine("B:{0}", B);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPlays().pileSize(A, B, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int A = 5;
        Console.WriteLine("A:{0}", A);
        int B = 5;
        Console.WriteLine("B:{0}", B);
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPlays().pileSize(A, B, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int A = 2;
        Console.WriteLine("A:{0}", A);
        int B = 6;
        Console.WriteLine("B:{0}", B);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPlays().pileSize(A, B, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int A = 2;
        Console.WriteLine("A:{0}", A);
        int B = 8;
        Console.WriteLine("B:{0}", B);
        int K = 2000000000;
        Console.WriteLine("K:{0}", K);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPlays().pileSize(A, B, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int A = 900000000;
        Console.WriteLine("A:{0}", A);
        int B = 350000000;
        Console.WriteLine("B:{0}", B);
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 300000000;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearPlays().pileSize(A, B, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
