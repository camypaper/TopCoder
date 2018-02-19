using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string[] board = Scanner.In.string_array();
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __result  = new BichromeBoard().ableToDraw(board);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            "W?W",
            "??B",
            "???"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromeBoard().ableToDraw(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "W??W"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromeBoard().ableToDraw(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            "??"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromeBoard().ableToDraw(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            "W???",
            "??B?",
            "W???",
            "???W"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromeBoard().ableToDraw(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string[] board = new string[] {
            "W???",
            "??B?",
            "W???",
            "?B?W"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromeBoard().ableToDraw(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        string[] board = new string[] {
            "B"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new BichromeBoard().ableToDraw(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
