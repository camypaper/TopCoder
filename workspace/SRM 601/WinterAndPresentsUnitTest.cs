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
        int[] apple = Scanner.In.int_array();
        Console.WriteLine(string.Format("apple:{0}", string.Join(" ",apple)));
        int[] orange = Scanner.In.int_array();
        Console.WriteLine(string.Format("orange:{0}", string.Join(" ",orange)));
        long __result = new WinterAndPresents().getNumber(apple, orange);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] apple, int[] orange)
    {
                        Console.WriteLine(string.Format("apple:{0}", string.Join(" ",apple)));
                        Console.WriteLine(string.Format("orange:{0}", string.Join(" ",orange)));
                long __result = new WinterAndPresents().getNumber(apple, orange);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] apple = new int[] {
            1
        };
        Console.WriteLine(string.Format("apple:{0}", string.Join(" ", apple)));
        int[] orange = new int[] {
            1
        };
        Console.WriteLine(string.Format("orange:{0}", string.Join(" ", orange)));
        long __expected = 3L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new WinterAndPresents().getNumber(apple, orange);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] apple = new int[] {
            1,
            2,
            0,
            3
        };
        Console.WriteLine(string.Format("apple:{0}", string.Join(" ", apple)));
        int[] orange = new int[] {
            4,
            5,
            0,
            6
        };
        Console.WriteLine(string.Format("orange:{0}", string.Join(" ", orange)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new WinterAndPresents().getNumber(apple, orange);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] apple = new int[] {
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("apple:{0}", string.Join(" ", apple)));
        int[] orange = new int[] {
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("orange:{0}", string.Join(" ", orange)));
        long __expected = 16L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new WinterAndPresents().getNumber(apple, orange);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] apple = new int[] {
            7,
            4,
            5
        };
        Console.WriteLine(string.Format("apple:{0}", string.Join(" ", apple)));
        int[] orange = new int[] {
            1,
            10,
            2
        };
        Console.WriteLine(string.Format("orange:{0}", string.Join(" ", orange)));
        long __expected = 46L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new WinterAndPresents().getNumber(apple, orange);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] apple = new int[] {
            1000000
        };
        Console.WriteLine(string.Format("apple:{0}", string.Join(" ", apple)));
        int[] orange = new int[] {
            1000000
        };
        Console.WriteLine(string.Format("orange:{0}", string.Join(" ", orange)));
        long __expected = 1000002000000L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new WinterAndPresents().getNumber(apple, orange);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
