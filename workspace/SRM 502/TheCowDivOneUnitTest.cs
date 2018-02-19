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
        int N = Scanner.In.@int();
        Console.WriteLine("N:{0}", N);
        int K = Scanner.In.@int();
        Console.WriteLine("K:{0}", K);
        int __result = new TheCowDivOne().find(N, K);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int N, int K)
    {
                        Console.WriteLine("N:{0}", N);
                        Console.WriteLine("K:{0}", K);
                int __result = new TheCowDivOne().find(N, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 7;
        Console.WriteLine("N:{0}", N);
        int K = 4;
        Console.WriteLine("K:{0}", K);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheCowDivOne().find(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheCowDivOne().find(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 58;
        Console.WriteLine("N:{0}", N);
        int K = 4;
        Console.WriteLine("K:{0}", K);
        int __expected = 7322;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheCowDivOne().find(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 1000;
        Console.WriteLine("N:{0}", N);
        int K = 47;
        Console.WriteLine("K:{0}", K);
        int __expected = 219736903;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheCowDivOne().find(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 1000000000;
        Console.WriteLine("N:{0}", N);
        int K = 1000;
        Console.WriteLine("K:{0}", K);
        int __expected = 666683069;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheCowDivOne().find(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
