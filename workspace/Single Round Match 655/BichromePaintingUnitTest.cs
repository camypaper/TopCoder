using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string[] board = Scanner.In.string_array();
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int k = Scanner.In.@int();
        Console.WriteLine("k:{0}",k);
        string __result  = new BichromePainting().isThatPossible(board, k);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            "BBBW",
            "BWWW",
            "BWWW",
            "WWWW"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int k = 3;
        Console.WriteLine("k:{0}",k);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromePainting().isThatPossible(board, k);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "BW",
            "WB"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int k = 2;
        Console.WriteLine("k:{0}",k);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromePainting().isThatPossible(board, k);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            "BWBWBB",
            "WBWBBB",
            "BWBWBB",
            "WBWBBB",
            "BBBBBB",
            "BBBBBB"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int k = 2;
        Console.WriteLine("k:{0}",k);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromePainting().isThatPossible(board, k);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            "BWBWBB",
            "WBWBWB",
            "BWBWBB",
            "WBWBWB",
            "BWBWBB",
            "BBBBBB"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int k = 2;
        Console.WriteLine("k:{0}",k);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromePainting().isThatPossible(board, k);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            "BWBWBB",
            "WBWBWB",
            "BWBWBB",
            "WBWBWB",
            "BWBWBB",
            "BBBBBB"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int k = 1;
        Console.WriteLine("k:{0}",k);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromePainting().isThatPossible(board, k);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        string[] board = new string[] {
            "BB",
            "BB"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int k = 2;
        Console.WriteLine("k:{0}",k);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromePainting().isThatPossible(board, k);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
