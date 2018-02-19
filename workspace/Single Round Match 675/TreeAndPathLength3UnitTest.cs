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
        int s = Scanner.In.@int();
        Console.WriteLine("s:{0}", s);
        int[] __result = new TreeAndPathLength3().construct(s);
        Console.WriteLine(string.Format("__result:{0}", string.Join(" ", __result)));
    }

    public void ManualTest(int s)
    {
                        Console.WriteLine("s:{0}", s);
                int[] __result = new TreeAndPathLength3().construct(s);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int s = 1;
        Console.WriteLine("s:{0}", s);
        int[] __expected = new int[] {
            0,
            1,
            1,
            2,
            2,
            3
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TreeAndPathLength3().construct(s);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int s = 2;
        Console.WriteLine("s:{0}", s);
        int[] __expected = new int[] {
            0,
            1,
            1,
            2,
            2,
            3,
            3,
            4
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TreeAndPathLength3().construct(s);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int s = 6;
        Console.WriteLine("s:{0}", s);
        int[] __expected = new int[] {
            0,
            1,
            1,
            2,
            0,
            3,
            3,
            4,
            0,
            5,
            5,
            6
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TreeAndPathLength3().construct(s);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int s = 8;
        Console.WriteLine("s:{0}", s);
        int[] __expected = new int[] {
            0,
            1,
            1,
            2,
            1,
            3,
            3,
            4,
            3,
            5,
            5,
            6,
            5,
            7
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TreeAndPathLength3().construct(s);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
