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
        int L = Scanner.In.@int();
        Console.WriteLine("L:{0}", L);
        int[] width = Scanner.In.int_array();
        Console.WriteLine(string.Format("width:{0}", string.Join(" ",width)));
        string[] __result = new LongSeat().canSit(L, width);
        Console.WriteLine(string.Format("__result:{0}", string.Join(" ", __result)));
    }

    public void ManualTest(int L, int[] width)
    {
                        Console.WriteLine("L:{0}", L);
                        Console.WriteLine(string.Format("width:{0}", string.Join(" ",width)));
                string[] __result = new LongSeat().canSit(L, width);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int L = 2;
        Console.WriteLine("L:{0}", L);
        int[] width = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("width:{0}", string.Join(" ", width)));
        string[] __expected = new string[] {
            "Sit",
            "Unsure"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new LongSeat().canSit(L, width);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int L = 10;
        Console.WriteLine("L:{0}", L);
        int[] width = new int[] {
            100,
            2,
            4,
            2
        };
        Console.WriteLine(string.Format("width:{0}", string.Join(" ", width)));
        string[] __expected = new string[] {
            "Stand",
            "Sit",
            "Sit",
            "Unsure"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new LongSeat().canSit(L, width);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int L = 37;
        Console.WriteLine("L:{0}", L);
        int[] width = new int[] {
            3,
            7,
            5,
            6,
            4,
            4,
            1,
            3
        };
        Console.WriteLine(string.Format("width:{0}", string.Join(" ", width)));
        string[] __expected = new string[] {
            "Sit",
            "Sit",
            "Sit",
            "Unsure",
            "Unsure",
            "Unsure",
            "Sit",
            "Unsure"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new LongSeat().canSit(L, width);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int L = 400;
        Console.WriteLine("L:{0}", L);
        int[] width = new int[] {
            92,
            65,
            99,
            46,
            24,
            85,
            95,
            84
        };
        Console.WriteLine(string.Format("width:{0}", string.Join(" ", width)));
        string[] __expected = new string[] {
            "Sit",
            "Sit",
            "Unsure",
            "Unsure",
            "Unsure",
            "Unsure",
            "Stand",
            "Unsure"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new LongSeat().canSit(L, width);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        int L = 1000000000;
        Console.WriteLine("L:{0}", L);
        int[] width = new int[] {
            1000000000,
            1000000000,
            1000000000,
            1000000000,
            1000000000,
            1000000000,
            1000000000,
            1000000000
        };
        Console.WriteLine(string.Format("width:{0}", string.Join(" ", width)));
        string[] __expected = new string[] {
            "Sit",
            "Stand",
            "Stand",
            "Stand",
            "Stand",
            "Stand",
            "Stand",
            "Stand"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new LongSeat().canSit(L, width);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example5()
    {
        int L = 1;
        Console.WriteLine("L:{0}", L);
        int[] width = new int[] {
            1000000000,
            1000000000,
            1000000000,
            1000000000,
            1000000000,
            1000000000,
            1000000000,
            1000000000
        };
        Console.WriteLine(string.Format("width:{0}", string.Join(" ", width)));
        string[] __expected = new string[] {
            "Stand",
            "Stand",
            "Stand",
            "Stand",
            "Stand",
            "Stand",
            "Stand",
            "Stand"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new LongSeat().canSit(L, width);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
