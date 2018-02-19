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
        int[] bags = Scanner.In.int_array();
        Console.WriteLine(string.Format("bags:{0}", string.Join(" ",bags)));
        int K = Scanner.In.@int();
        Console.WriteLine("K:{0}", K);
        int __result = new WinterAndMandarins().getNumber(bags, K);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] bags, int K)
    {
                        Console.WriteLine(string.Format("bags:{0}", string.Join(" ",bags)));
                        Console.WriteLine("K:{0}", K);
                int __result = new WinterAndMandarins().getNumber(bags, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] bags = new int[] {
            10,
            20,
            30
        };
        Console.WriteLine(string.Format("bags:{0}", string.Join(" ", bags)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 10;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndMandarins().getNumber(bags, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] bags = new int[] {
            4,
            7,
            4
        };
        Console.WriteLine(string.Format("bags:{0}", string.Join(" ", bags)));
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndMandarins().getNumber(bags, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] bags = new int[] {
            4,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("bags:{0}", string.Join(" ", bags)));
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndMandarins().getNumber(bags, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] bags = new int[] {
            5,
            4,
            6,
            1,
            9,
            4,
            2,
            7,
            5,
            6
        };
        Console.WriteLine(string.Format("bags:{0}", string.Join(" ", bags)));
        int K = 4;
        Console.WriteLine("K:{0}", K);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndMandarins().getNumber(bags, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] bags = new int[] {
            47,
            1000000000,
            1,
            74
        };
        Console.WriteLine(string.Format("bags:{0}", string.Join(" ", bags)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 27;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndMandarins().getNumber(bags, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
