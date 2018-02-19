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
        string[] s = Scanner.In.string_array();
        Console.WriteLine(string.Format("s:{0}", string.Join(" ",s)));
        int __result = new OrderOfOperations().minTime(s);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string[] s)
    {
                        Console.WriteLine(string.Format("s:{0}", string.Join(" ",s)));
                int __result = new OrderOfOperations().minTime(s);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] s = new string[] {
            "111",
            "001",
            "010"
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OrderOfOperations().minTime(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] s = new string[] {
            "11101",
            "00111",
            "10101",
            "00000",
            "11000"
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OrderOfOperations().minTime(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] s = new string[] {
            "11111111111111111111"
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int __expected = 400;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OrderOfOperations().minTime(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] s = new string[] {
            "1000",
            "1100",
            "1110"
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OrderOfOperations().minTime(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] s = new string[] {
            "111",
            "111",
            "110",
            "100"
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OrderOfOperations().minTime(s);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
