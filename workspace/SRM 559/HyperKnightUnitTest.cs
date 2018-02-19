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
    public void ManualTest(int a, int b, int numRows, int numColumns, int k)
    {
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine("numRows:{0}", numRows);
        Console.WriteLine("numColumns:{0}", numColumns);
        Console.WriteLine("k:{0}", k);
        long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int a = 2;
        Console.WriteLine("a:{0}", a);
        int b = 1;
        Console.WriteLine("b:{0}", b);
        int numRows = 8;
        Console.WriteLine("numRows:{0}", numRows);
        int numColumns = 8;
        Console.WriteLine("numColumns:{0}", numColumns);
        int k = 4;
        Console.WriteLine("k:{0}", k);
        long __expected = 20L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int a = 3;
        Console.WriteLine("a:{0}", a);
        int b = 2;
        Console.WriteLine("b:{0}", b);
        int numRows = 8;
        Console.WriteLine("numRows:{0}", numRows);
        int numColumns = 8;
        Console.WriteLine("numColumns:{0}", numColumns);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        long __expected = 16L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int a = 1;
        Console.WriteLine("a:{0}", a);
        int b = 3;
        Console.WriteLine("b:{0}", b);
        int numRows = 7;
        Console.WriteLine("numRows:{0}", numRows);
        int numColumns = 11;
        Console.WriteLine("numColumns:{0}", numColumns);
        int k = 0;
        Console.WriteLine("k:{0}", k);
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int a = 3;
        Console.WriteLine("a:{0}", a);
        int b = 2;
        Console.WriteLine("b:{0}", b);
        int numRows = 10;
        Console.WriteLine("numRows:{0}", numRows);
        int numColumns = 20;
        Console.WriteLine("numColumns:{0}", numColumns);
        int k = 8;
        Console.WriteLine("k:{0}", k);
        long __expected = 56L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int a = 1;
        Console.WriteLine("a:{0}", a);
        int b = 4;
        Console.WriteLine("b:{0}", b);
        int numRows = 100;
        Console.WriteLine("numRows:{0}", numRows);
        int numColumns = 10;
        Console.WriteLine("numColumns:{0}", numColumns);
        int k = 6;
        Console.WriteLine("k:{0}", k);
        long __expected = 564L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int a = 2;
        Console.WriteLine("a:{0}", a);
        int b = 3;
        Console.WriteLine("b:{0}", b);
        int numRows = 1000000000;
        Console.WriteLine("numRows:{0}", numRows);
        int numColumns = 1000000000;
        Console.WriteLine("numColumns:{0}", numColumns);
        int k = 8;
        Console.WriteLine("k:{0}", k);
        long __expected = 999999988000000036L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
