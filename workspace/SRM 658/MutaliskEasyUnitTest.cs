using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, 5, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            case 5: Example5(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int[] x = Scanner.In.int_array();
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        int __result = new MutaliskEasy().minimalAttacks(x);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] x)
    {
                        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
                int __result = new MutaliskEasy().minimalAttacks(x);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            12,
            10,
            4
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MutaliskEasy().minimalAttacks(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            54,
            18,
            6
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MutaliskEasy().minimalAttacks(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            55,
            60,
            53
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int __expected = 13;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MutaliskEasy().minimalAttacks(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MutaliskEasy().minimalAttacks(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            60,
            40
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MutaliskEasy().minimalAttacks(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] x = new int[] {
            60
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int __expected = 7;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MutaliskEasy().minimalAttacks(x);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
