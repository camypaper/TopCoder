using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class PathGameTest
{
    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            "#..",
            "..."
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __expected = "Snuke";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PathGame().judge(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "#",
            "."
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __expected = "Sothe";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PathGame().judge(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            ".....",
            "..#.."
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __expected = "Sothe";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PathGame().judge(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            ".#...",
            "....."
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __expected = "Snuke";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PathGame().judge(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            ".....#..#........##.......",
            "..........#..........#...."
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __expected = "Snuke";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PathGame().judge(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
