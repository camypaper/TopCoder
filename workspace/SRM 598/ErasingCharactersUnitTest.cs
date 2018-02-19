using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string s = Scanner.In.@string();
        Console.WriteLine("s:{0}",s);
        string __result  = new ErasingCharacters().simulate(s);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string s = "cieeilll";
        Console.WriteLine("s:{0}",s);
        string __expected = "cl";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new ErasingCharacters().simulate(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string s = "topcoder";
        Console.WriteLine("s:{0}",s);
        string __expected = "topcoder";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new ErasingCharacters().simulate(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string s = "abcdefghijklmnopqrstuvwxyyxwvutsrqponmlkjihgfedcba";
        Console.WriteLine("s:{0}",s);
        string __expected = "";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new ErasingCharacters().simulate(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string s = "bacaabaccbaaccabbcabbacabcbba";
        Console.WriteLine("s:{0}",s);
        string __expected = "bacbaca";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new ErasingCharacters().simulate(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string s = "eel";
        Console.WriteLine("s:{0}",s);
        string __expected = "l";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new ErasingCharacters().simulate(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
