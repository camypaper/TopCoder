using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string[] board = Scanner.In.string_array();
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __result  = new FoxAndGo2().maxKill(board);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            "...",
            ".o.",
            "..."
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new FoxAndGo2().maxKill(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "o.",
            "oo"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new FoxAndGo2().maxKill(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            ".o.o.",
            "o.o.o",
            ".o.o.",
            "o.o.o",
            ".o.o."
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new FoxAndGo2().maxKill(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            ".o.o.",
            "o.o.o",
            ".o.o.",
            "o.o.o",
            "....."
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 10;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new FoxAndGo2().maxKill(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            ".o.o.o.o.o.",
            "o.ooo.ooo.o",
            ".o.......o.",
            "oo.......oo",
            ".o...o...o.",
            "o...o.o...o",
            ".o...o...o.",
            "oo.......oo",
            ".o.......o.",
            "o.ooo.ooo.o",
            ".o.o.o.o.o."
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new FoxAndGo2().maxKill(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        string[] board = new string[] {
            "...ooo.....",
            "...o.o.....",
            ".ooo.ooo...",
            ".o.....o...",
            ".ooo.ooo...",
            "...o.o.....",
            "...ooo.....",
            "....o......",
            "....o...ooo",
            "....ooooo.o",
            "........ooo"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 38;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new FoxAndGo2().maxKill(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example6()
    {
        string[] board = new string[] {
            "ooooooooooo",
            "o.........o",
            "o...ooo...o",
            "o...o.o...o",
            "o...ooo...o",
            "o....o....o",
            "o....oooooo",
            "o..........",
            "o.......ooo",
            "o.......o.o",
            "ooooooooooo"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new FoxAndGo2().maxKill(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example7()
    {
        string[] board = new string[] {
            "oo.o.ooo.o..o..",
            "...ooo.o..oo.oo",
            "o..o.o.ooo.o..o",
            "oo.......oo.ooo",
            "..oo.o.o.o.ooo.",
            "..oo..oo..o.ooo",
            "oo.o.oo..o.oooo",
            ".oo.o..ooo.o.oo",
            "o..o.o.o.o.oo..",
            ".oo.oo...o....o",
            "o.o.oo....oo..o",
            ".o.o..o.oo..ooo",
            "o.o.o..o..o....",
            "ooo.oooooooo..o",
            "o..oo.o..o.ooo."
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 60;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new FoxAndGo2().maxKill(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
