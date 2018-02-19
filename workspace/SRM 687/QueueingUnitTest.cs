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
    public void ManualTest(int len1, int len2, int p1, int p2)
    {
        Console.WriteLine("len1:{0}", len1);
        Console.WriteLine("len2:{0}", len2);
        Console.WriteLine("p1:{0}", p1);
        Console.WriteLine("p2:{0}", p2);
        double __result = new Queueing().probFirst(len1, len2, p1, p2);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int len1 = 1;
        Console.WriteLine("len1:{0}", len1);
        int len2 = 2;
        Console.WriteLine("len2:{0}", len2);
        int p1 = 2;
        Console.WriteLine("p1:{0}", p1);
        int p2 = 1;
        Console.WriteLine("p2:{0}", p2);
        double __expected = 0.5;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Queueing().probFirst(len1, len2, p1, p2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int len1 = 1;
        Console.WriteLine("len1:{0}", len1);
        int len2 = 3;
        Console.WriteLine("len2:{0}", len2);
        int p1 = 3;
        Console.WriteLine("p1:{0}", p1);
        int p2 = 7;
        Console.WriteLine("p2:{0}", p2);
        double __expected = 0.9835390946502058;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Queueing().probFirst(len1, len2, p1, p2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int len1 = 3;
        Console.WriteLine("len1:{0}", len1);
        int len2 = 1;
        Console.WriteLine("len2:{0}", len2);
        int p1 = 7;
        Console.WriteLine("p1:{0}", p1);
        int p2 = 3;
        Console.WriteLine("p2:{0}", p2);
        double __expected = 0.010973936899862834;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Queueing().probFirst(len1, len2, p1, p2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example3()
    {
        int len1 = 12;
        Console.WriteLine("len1:{0}", len1);
        int len2 = 34;
        Console.WriteLine("len2:{0}", len2);
        int p1 = 56;
        Console.WriteLine("p1:{0}", p1);
        int p2 = 78;
        Console.WriteLine("p2:{0}", p2);
        double __expected = 0.999996203228025;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Queueing().probFirst(len1, len2, p1, p2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example4()
    {
        int len1 = 3;
        Console.WriteLine("len1:{0}", len1);
        int len2 = 6;
        Console.WriteLine("len2:{0}", len2);
        int p1 = 8;
        Console.WriteLine("p1:{0}", p1);
        int p2 = 4;
        Console.WriteLine("p2:{0}", p2);
        double __expected = 0.5229465300297028;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new Queueing().probFirst(len1, len2, p1, p2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
