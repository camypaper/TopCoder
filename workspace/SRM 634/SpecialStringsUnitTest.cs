using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string current = Scanner.In.@string();
        Console.WriteLine("current:{0}",current);
        string __result  = new SpecialStrings().findNext(current);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string current = "01";
        Console.WriteLine("current:{0}",current);
        string __expected = "";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new SpecialStrings().findNext(current);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string current = "00101";
        Console.WriteLine("current:{0}",current);
        string __expected = "00111";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new SpecialStrings().findNext(current);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string current = "0010111";
        Console.WriteLine("current:{0}",current);
        string __expected = "0011011";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new SpecialStrings().findNext(current);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string current = "000010001001011";
        Console.WriteLine("current:{0}",current);
        string __expected = "000010001001101";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new SpecialStrings().findNext(current);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string current = "01101111011110111";
        Console.WriteLine("current:{0}",current);
        string __expected = "01101111011111111";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new SpecialStrings().findNext(current);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
