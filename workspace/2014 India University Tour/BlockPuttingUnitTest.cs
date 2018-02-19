using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class BlockPuttingTest
{
    [TestMethod]
    public void Example0()
    {
        string s = "..X...X";
        Console.WriteLine("s:{0}",s);
        int __expected = 3;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BlockPutting().getmax(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string s = ".....";
        Console.WriteLine("s:{0}",s);
        int __expected = 5;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BlockPutting().getmax(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string s = "XXXXXX";
        Console.WriteLine("s:{0}",s);
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BlockPutting().getmax(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string s = "..XX..XX..XX..XX..XX..XX..XX..XX..XX..XX...";
        Console.WriteLine("s:{0}",s);
        int __expected = 3;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BlockPutting().getmax(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string s = ".........X.X........X..XXXXXX........X...";
        Console.WriteLine("s:{0}",s);
        int __expected = 9;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BlockPutting().getmax(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
