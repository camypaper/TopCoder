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
    public void ManualTest(int[] frequencies, int[] keySizes)
    {
        Console.WriteLine(string.Format("frequencies:{0}", string.Join(" ",frequencies)));
        Console.WriteLine(string.Format("keySizes:{0}", string.Join(" ",keySizes)));
        int __result = new TomekPhone().minKeystrokes(frequencies, keySizes);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] frequencies = new int[] {
            7,
            3,
            4,
            1
        };
        Console.WriteLine(string.Format("frequencies:{0}", string.Join(" ", frequencies)));
        int[] keySizes = new int[] {
            2,
            2
        };
        Console.WriteLine(string.Format("keySizes:{0}", string.Join(" ", keySizes)));
        int __expected = 19;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TomekPhone().minKeystrokes(frequencies, keySizes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] frequencies = new int[] {
            13,
            7,
            4,
            20
        };
        Console.WriteLine(string.Format("frequencies:{0}", string.Join(" ", frequencies)));
        int[] keySizes = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("keySizes:{0}", string.Join(" ", keySizes)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TomekPhone().minKeystrokes(frequencies, keySizes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] frequencies = new int[] {
            11,
            23,
            4,
            50,
            1000,
            7,
            18
        };
        Console.WriteLine(string.Format("frequencies:{0}", string.Join(" ", frequencies)));
        int[] keySizes = new int[] {
            3,
            1,
            4
        };
        Console.WriteLine(string.Format("keySizes:{0}", string.Join(" ", keySizes)));
        int __expected = 1164;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TomekPhone().minKeystrokes(frequencies, keySizes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] frequencies = new int[] {
            100,
            1000,
            1,
            10
        };
        Console.WriteLine(string.Format("frequencies:{0}", string.Join(" ", frequencies)));
        int[] keySizes = new int[] {
            50
        };
        Console.WriteLine(string.Format("keySizes:{0}", string.Join(" ", keySizes)));
        int __expected = 1234;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TomekPhone().minKeystrokes(frequencies, keySizes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] frequencies = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30,
            31,
            32,
            33,
            34,
            35,
            36,
            37,
            38,
            39,
            40,
            41,
            42,
            43,
            44,
            45,
            46,
            47,
            48,
            49,
            50
        };
        Console.WriteLine(string.Format("frequencies:{0}", string.Join(" ", frequencies)));
        int[] keySizes = new int[] {
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10
        };
        Console.WriteLine(string.Format("keySizes:{0}", string.Join(" ", keySizes)));
        int __expected = 3353;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TomekPhone().minKeystrokes(frequencies, keySizes);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
