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
    public void ManualTest(int N, int K)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        int __result = new TheCowDivTwo().find(N, K);
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
        int __result = new TheCowDivTwo().find(N, K);
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
        int __result = new TheCowDivTwo().find(N, K);
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
        int __result = new TheCowDivTwo().find(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 502;
        Console.WriteLine("N:{0}", N);
        int K = 7;
        Console.WriteLine("K:{0}", K);
        int __expected = 704466492;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheCowDivTwo().find(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 1000;
        Console.WriteLine("N:{0}", N);
        int K = 47;
        Console.WriteLine("K:{0}", K);
        int __expected = 219736903;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheCowDivTwo().find(N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
