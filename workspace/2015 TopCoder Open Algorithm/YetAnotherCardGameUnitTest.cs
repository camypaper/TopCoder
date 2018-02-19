using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int[] petr = Scanner.In.int_array();
        Console.WriteLine(string.Format("petr:{0}", string.Join(" ",petr)));
        int[] snuke = Scanner.In.int_array();
        Console.WriteLine(string.Format("snuke:{0}", string.Join(" ",snuke)));
        int __result = new YetAnotherCardGame().maxCards(petr, snuke);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] petr, int[] snuke)
    {
                        Console.WriteLine(string.Format("petr:{0}", string.Join(" ",petr)));
                        Console.WriteLine(string.Format("snuke:{0}", string.Join(" ",snuke)));
                int __result = new YetAnotherCardGame().maxCards(petr, snuke);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] petr = new int[] {
            2,
            5
        };
        Console.WriteLine(string.Format("petr:{0}", string.Join(" ", petr)));
        int[] snuke = new int[] {
            3,
            1
        };
        Console.WriteLine(string.Format("snuke:{0}", string.Join(" ", snuke)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new YetAnotherCardGame().maxCards(petr, snuke);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] petr = new int[] {
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("petr:{0}", string.Join(" ", petr)));
        int[] snuke = new int[] {
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("snuke:{0}", string.Join(" ", snuke)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new YetAnotherCardGame().maxCards(petr, snuke);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] petr = new int[] {
            1,
            4,
            6,
            7,
            3
        };
        Console.WriteLine(string.Format("petr:{0}", string.Join(" ", petr)));
        int[] snuke = new int[] {
            1,
            7,
            1,
            5,
            7
        };
        Console.WriteLine(string.Format("snuke:{0}", string.Join(" ", snuke)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new YetAnotherCardGame().maxCards(petr, snuke);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] petr = new int[] {
            19,
            99,
            86,
            30,
            98,
            68,
            73,
            92,
            37,
            69,
            93,
            28,
            58,
            36,
            86,
            32,
            46,
            34,
            71,
            29
        };
        Console.WriteLine(string.Format("petr:{0}", string.Join(" ", petr)));
        int[] snuke = new int[] {
            28,
            29,
            22,
            75,
            78,
            75,
            39,
            41,
            5,
            14,
            100,
            28,
            51,
            42,
            9,
            25,
            12,
            59,
            98,
            83
        };
        Console.WriteLine(string.Format("snuke:{0}", string.Join(" ", snuke)));
        int __expected = 28;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new YetAnotherCardGame().maxCards(petr, snuke);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
