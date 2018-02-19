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
    public void ManualTest(string s, int[] L, int[] R)
    {
        Console.WriteLine("s:{0}", s);
        Console.WriteLine(string.Format("L:{0}", string.Join(" ",L)));
        Console.WriteLine(string.Format("R:{0}", string.Join(" ",R)));
        int __result = new ParenthesesDiv1Medium().minSwaps(s, L, R);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string s = ")(";
        Console.WriteLine("s:{0}", s);
        int[] L = new int[] {
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("L:{0}", string.Join(" ", L)));
        int[] R = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ParenthesesDiv1Medium().minSwaps(s, L, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string s = "(())";
        Console.WriteLine("s:{0}", s);
        int[] L = new int[] {
            0,
            2
        };
        Console.WriteLine(string.Format("L:{0}", string.Join(" ", L)));
        int[] R = new int[] {
            1,
            3
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ParenthesesDiv1Medium().minSwaps(s, L, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string s = "(((())";
        Console.WriteLine("s:{0}", s);
        int[] L = new int[] {
            0,
            2
        };
        Console.WriteLine(string.Format("L:{0}", string.Join(" ", L)));
        int[] R = new int[] {
            1,
            3
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ParenthesesDiv1Medium().minSwaps(s, L, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string s = "(((((((((";
        Console.WriteLine("s:{0}", s);
        int[] L = new int[] {
            0,
            2
        };
        Console.WriteLine(string.Format("L:{0}", string.Join(" ", L)));
        int[] R = new int[] {
            1,
            3
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ParenthesesDiv1Medium().minSwaps(s, L, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string s = "()()()()";
        Console.WriteLine("s:{0}", s);
        int[] L = new int[] {
            0,
            0,
            0,
            0,
            2,
            2,
            2,
            4,
            4,
            6
        };
        Console.WriteLine(string.Format("L:{0}", string.Join(" ", L)));
        int[] R = new int[] {
            1,
            3,
            5,
            7,
            3,
            5,
            7,
            5,
            7,
            7
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ParenthesesDiv1Medium().minSwaps(s, L, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string s = ")()(()()((())()()()()()()))(()())()()()(";
        Console.WriteLine("s:{0}", s);
        int[] L = new int[] {
            3,
            5,
            17,
            25,
            35
        };
        Console.WriteLine(string.Format("L:{0}", string.Join(" ", L)));
        int[] R = new int[] {
            12,
            10,
            30,
            30,
            38
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ParenthesesDiv1Medium().minSwaps(s, L, R);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
