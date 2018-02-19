using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);    }
    public void ManualTest(string[] island, int T)
    {
        Console.WriteLine(string.Format("island:{0}", string.Join(" ",island)));
        Console.WriteLine("T:{0}", T);
        int __result = new Desertification().desertArea(island, T);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] island = new string[] {
            "FFF",
            "FDF",
            "FFF"
        };
        Console.WriteLine(string.Format("island:{0}", string.Join(" ", island)));
        int T = 1;
        Console.WriteLine("T:{0}", T);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Desertification().desertArea(island, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] island = new string[] {
            "FFF",
            "FDF",
            "FFF"
        };
        Console.WriteLine(string.Format("island:{0}", string.Join(" ", island)));
        int T = 2;
        Console.WriteLine("T:{0}", T);
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Desertification().desertArea(island, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] island = new string[] {
            "FFFFF",
            "FFDFF",
            "FFFFD",
            "FFFFF",
            "FFFFF"
        };
        Console.WriteLine(string.Format("island:{0}", string.Join(" ", island)));
        int T = 2;
        Console.WriteLine("T:{0}", T);
        int __expected = 17;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Desertification().desertArea(island, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] island = new string[] {
            "FFFFFF",
            "FFFFFF",
            "FFFFFF",
            "FFFFFF"
        };
        Console.WriteLine(string.Format("island:{0}", string.Join(" ", island)));
        int T = 1000000000;
        Console.WriteLine("T:{0}", T);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Desertification().desertArea(island, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] island = new string[] {
            "FFFFFDFFFF",
            "FDFDFFFFFF",
            "FFFFFFFFFD",
            "FFFFFFFFFF",
            "DDFFFFFFFF",
            "FFFFFFFFFD",
            "FFFFFFFFFF",
            "FFFFFFFDFF",
            "FFFFFFFDFF",
            "FFFFDDFFFF"
        };
        Console.WriteLine(string.Format("island:{0}", string.Join(" ", island)));
        int T = 3;
        Console.WriteLine("T:{0}", T);
        int __expected = 90;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Desertification().desertArea(island, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] island = new string[] {
            "FFFFFDFFFF",
            "FDFDFFFFFF",
            "FFFFFFFFFD",
            "FFFFFFFFFF",
            "DDFFFFFFFF",
            "FFFFFFFFFD",
            "FFFFFFFFFF",
            "FFFFFFFDFF",
            "FFFFFFFDFF",
            "FFFFDDFFFF"
        };
        Console.WriteLine(string.Format("island:{0}", string.Join(" ", island)));
        int T = 98765432;
        Console.WriteLine("T:{0}", T);
        int __expected = 100;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Desertification().desertArea(island, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
