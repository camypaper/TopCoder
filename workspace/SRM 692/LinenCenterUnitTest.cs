using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);Tests.Add(Example7);    }
    public void ManualTest(string S, int N, int K)
    {
        Console.WriteLine("S:{0}", S);
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        int __result = new LinenCenter().countStrings(S, N, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string S = "xy";
        Console.WriteLine("S:{0}", S);
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int __expected = 2079;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LinenCenter().countStrings(S, N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string S = "q";
        Console.WriteLine("S:{0}", S);
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int __expected = 1926;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LinenCenter().countStrings(S, N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string S = "ababab";
        Console.WriteLine("S:{0}", S);
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int K = 4;
        Console.WriteLine("K:{0}", K);
        int __expected = 527166180;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LinenCenter().countStrings(S, N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string S = "fgcdx";
        Console.WriteLine("S:{0}", S);
        int N = 500;
        Console.WriteLine("N:{0}", N);
        int K = 10;
        Console.WriteLine("K:{0}", K);
        int __expected = 942389748;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LinenCenter().countStrings(S, N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string S = "ghjhhhgjhjhgjhghghjhjg";
        Console.WriteLine("S:{0}", S);
        int N = 8;
        Console.WriteLine("N:{0}", N);
        int K = 10000000;
        Console.WriteLine("K:{0}", K);
        int __expected = 618639712;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LinenCenter().countStrings(S, N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string S = "pdpfrpfdfdpfdpfdpfpdfldfpfldpfdlfpdlfdpflepflfldpflofpwpldlfpde";
        Console.WriteLine("S:{0}", S);
        int N = 999;
        Console.WriteLine("N:{0}", N);
        int K = 500000000;
        Console.WriteLine("K:{0}", K);
        int __expected = 852730493;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LinenCenter().countStrings(S, N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        string S = "a";
        Console.WriteLine("S:{0}", S);
        int N = 100;
        Console.WriteLine("N:{0}", N);
        int K = 0;
        Console.WriteLine("K:{0}", K);
        int __expected = 990669582;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LinenCenter().countStrings(S, N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example7()
    {
        string S = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
        Console.WriteLine("S:{0}", S);
        int N = 1000;
        Console.WriteLine("N:{0}", N);
        int K = 1000000000;
        Console.WriteLine("K:{0}", K);
        int __expected = 286425258;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new LinenCenter().countStrings(S, N, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
