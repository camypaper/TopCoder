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
    public void ManualTest(int[] start, int[] d, int[] cnt)
    {
        Console.WriteLine(string.Format("start:{0}", string.Join(" ",start)));
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ",cnt)));
        int __result = new GCDLCM2().getMaximalSum(start, d, cnt);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] start = new int[] {
            1
        };
        Console.WriteLine(string.Format("start:{0}", string.Join(" ", start)));
        int[] d = new int[] {
            1
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] cnt = new int[] {
            3
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GCDLCM2().getMaximalSum(start, d, cnt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] start = new int[] {
            3
        };
        Console.WriteLine(string.Format("start:{0}", string.Join(" ", start)));
        int[] d = new int[] {
            0
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] cnt = new int[] {
            5
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int __expected = 15;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GCDLCM2().getMaximalSum(start, d, cnt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] start = new int[] {
            2
        };
        Console.WriteLine(string.Format("start:{0}", string.Join(" ", start)));
        int[] d = new int[] {
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] cnt = new int[] {
            4
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int __expected = 32;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GCDLCM2().getMaximalSum(start, d, cnt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] start = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("start:{0}", string.Join(" ", start)));
        int[] d = new int[] {
            2,
            3
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] cnt = new int[] {
            2,
            2
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int __expected = 33;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GCDLCM2().getMaximalSum(start, d, cnt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] start = new int[] {
            5,
            6
        };
        Console.WriteLine(string.Format("start:{0}", string.Join(" ", start)));
        int[] d = new int[] {
            23,
            45
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] cnt = new int[] {
            50000,
            50000
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int __expected = 804225394;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new GCDLCM2().getMaximalSum(start, d, cnt);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
