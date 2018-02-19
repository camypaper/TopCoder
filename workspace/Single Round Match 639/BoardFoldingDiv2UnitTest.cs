using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class BoardFoldingDiv2Test
{
    [TestMethod]
    public void Example0()
    {
        string[] paper = new string[] {
            "10",
            "11"
        };
        Console.WriteLine(string.Format("paper:{0}",string.Join(" ",paper)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BoardFoldingDiv2().howMany(paper);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string[] paper = new string[] {
            "1111111",
            "1111111"
        };
        Console.WriteLine(string.Format("paper:{0}",string.Join(" ",paper)));
        int __expected = 84;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BoardFoldingDiv2().howMany(paper);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string[] paper = new string[] {
            "0110",
            "1001",
            "1001",
            "0110"
        };
        Console.WriteLine(string.Format("paper:{0}",string.Join(" ",paper)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BoardFoldingDiv2().howMany(paper);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string[] paper = new string[] {
            "0",
            "0",
            "0",
            "1",
            "0",
            "0"
        };
        Console.WriteLine(string.Format("paper:{0}",string.Join(" ",paper)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BoardFoldingDiv2().howMany(paper);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string[] paper = new string[] {
            "000",
            "010",
            "000"
        };
        Console.WriteLine(string.Format("paper:{0}",string.Join(" ",paper)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BoardFoldingDiv2().howMany(paper);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
