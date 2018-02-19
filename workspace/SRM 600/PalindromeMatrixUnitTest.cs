using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, 5, 6, };
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
            case 6: Example6(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        string[] A = Scanner.In.string_array();
        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
        int rowCount = Scanner.In.@int();
        Console.WriteLine("rowCount:{0}", rowCount);
        int columnCount = Scanner.In.@int();
        Console.WriteLine("columnCount:{0}", columnCount);
        int __result = new PalindromeMatrix().minChange(A, rowCount, columnCount);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string[] A, int rowCount, int columnCount)
    {
                        Console.WriteLine(string.Format("A:{0}", string.Join(" ",A)));
                        Console.WriteLine("rowCount:{0}", rowCount);
                        Console.WriteLine("columnCount:{0}", columnCount);
                int __result = new PalindromeMatrix().minChange(A, rowCount, columnCount);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] A = new string[] {
            "0000",
            "1000",
            "1100",
            "1110"
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int rowCount = 2;
        Console.WriteLine("rowCount:{0}", rowCount);
        int columnCount = 2;
        Console.WriteLine("columnCount:{0}", columnCount);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromeMatrix().minChange(A, rowCount, columnCount);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] A = new string[] {
            "0000",
            "1000",
            "1100",
            "1110"
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int rowCount = 3;
        Console.WriteLine("rowCount:{0}", rowCount);
        int columnCount = 2;
        Console.WriteLine("columnCount:{0}", columnCount);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromeMatrix().minChange(A, rowCount, columnCount);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] A = new string[] {
            "01",
            "10"
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int rowCount = 1;
        Console.WriteLine("rowCount:{0}", rowCount);
        int columnCount = 1;
        Console.WriteLine("columnCount:{0}", columnCount);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromeMatrix().minChange(A, rowCount, columnCount);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] A = new string[] {
            "1110",
            "0001"
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int rowCount = 0;
        Console.WriteLine("rowCount:{0}", rowCount);
        int columnCount = 0;
        Console.WriteLine("columnCount:{0}", columnCount);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromeMatrix().minChange(A, rowCount, columnCount);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] A = new string[] {
            "01010101",
            "01010101",
            "01010101",
            "01010101",
            "01010101",
            "01010101",
            "01010101",
            "01010101"
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int rowCount = 2;
        Console.WriteLine("rowCount:{0}", rowCount);
        int columnCount = 3;
        Console.WriteLine("columnCount:{0}", columnCount);
        int __expected = 8;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromeMatrix().minChange(A, rowCount, columnCount);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] A = new string[] {
            "000000000000",
            "011101110111",
            "010001010101",
            "010001010101",
            "011101010101",
            "010101010101",
            "010101010101",
            "011101110111",
            "000000000000",
            "000000000000"
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int rowCount = 5;
        Console.WriteLine("rowCount:{0}", rowCount);
        int columnCount = 9;
        Console.WriteLine("columnCount:{0}", columnCount);
        int __expected = 14;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromeMatrix().minChange(A, rowCount, columnCount);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        string[] A = new string[] {
            "11111101001110",
            "11000111111111",
            "00010101111001",
            "10110000111111",
            "10000011010010",
            "10001101101101",
            "00101010000001",
            "10111010100100",
            "11010011110111",
            "11100010110110",
            "00100101010100",
            "01001011001000",
            "01010001111010",
            "10100000010011"
        };
        Console.WriteLine(string.Format("A:{0}", string.Join(" ", A)));
        int rowCount = 6;
        Console.WriteLine("rowCount:{0}", rowCount);
        int columnCount = 8;
        Console.WriteLine("columnCount:{0}", columnCount);
        int __expected = 31;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PalindromeMatrix().minChange(A, rowCount, columnCount);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
