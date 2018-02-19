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
    public void ManualTest(int C, int X, int[] high)
    {
        Console.WriteLine("C:{0}", C);
        Console.WriteLine("X:{0}", X);
        Console.WriteLine(string.Format("high:{0}", string.Join(" ",high)));
        int __result = new MysticAndCandiesEasy().minBoxes(C, X, high);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int C = 10;
        Console.WriteLine("C:{0}", C);
        int X = 10;
        Console.WriteLine("X:{0}", X);
        int[] high = new int[] {
            20
        };
        Console.WriteLine(string.Format("high:{0}", string.Join(" ", high)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MysticAndCandiesEasy().minBoxes(C, X, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int C = 10;
        Console.WriteLine("C:{0}", C);
        int X = 7;
        Console.WriteLine("X:{0}", X);
        int[] high = new int[] {
            3,
            3,
            3,
            3,
            3
        };
        Console.WriteLine(string.Format("high:{0}", string.Join(" ", high)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MysticAndCandiesEasy().minBoxes(C, X, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int C = 100;
        Console.WriteLine("C:{0}", C);
        int X = 63;
        Console.WriteLine("X:{0}", X);
        int[] high = new int[] {
            12,
            34,
            23,
            45,
            34
        };
        Console.WriteLine(string.Format("high:{0}", string.Join(" ", high)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MysticAndCandiesEasy().minBoxes(C, X, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int C = 19;
        Console.WriteLine("C:{0}", C);
        int X = 12;
        Console.WriteLine("X:{0}", X);
        int[] high = new int[] {
            12,
            9,
            15,
            1,
            6,
            4,
            9,
            10,
            10,
            10,
            14,
            14,
            1,
            1,
            12,
            10,
            9,
            2,
            3,
            6,
            1,
            7,
            3,
            4,
            10,
            3,
            14
        };
        Console.WriteLine(string.Format("high:{0}", string.Join(" ", high)));
        int __expected = 22;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MysticAndCandiesEasy().minBoxes(C, X, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int C = 326;
        Console.WriteLine("C:{0}", C);
        int X = 109;
        Console.WriteLine("X:{0}", X);
        int[] high = new int[] {
            9,
            13,
            6,
            6,
            6,
            16,
            16,
            16,
            10,
            16,
            4,
            3,
            10,
            8,
            11,
            17,
            12,
            5,
            7,
            8,
            7,
            4,
            15,
            7,
            14,
            2,
            2,
            1,
            17,
            1,
            7,
            7,
            12,
            17,
            2,
            9,
            7,
            1,
            8,
            16,
            7,
            4,
            16,
            2,
            13,
            3,
            13,
            1,
            17,
            6
        };
        Console.WriteLine(string.Format("high:{0}", string.Join(" ", high)));
        int __expected = 15;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MysticAndCandiesEasy().minBoxes(C, X, high);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
