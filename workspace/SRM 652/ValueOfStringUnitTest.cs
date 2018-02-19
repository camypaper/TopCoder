using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string s = Scanner.In.@string();
        Console.WriteLine("s:{0}",s);
        int __result  = new ValueOfString().findValue(s);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string s = "babca";
        Console.WriteLine("s:{0}",s);
        int __expected = 35;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ValueOfString().findValue(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string s = "zz";
        Console.WriteLine("s:{0}",s);
        int __expected = 104;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ValueOfString().findValue(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string s = "y";
        Console.WriteLine("s:{0}",s);
        int __expected = 25;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ValueOfString().findValue(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string s = "aaabbc";
        Console.WriteLine("s:{0}",s);
        int __expected = 47;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ValueOfString().findValue(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string s = "topcoder";
        Console.WriteLine("s:{0}",s);
        int __expected = 558;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ValueOfString().findValue(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        string s = "thequickbrownfoxjumpsoverthelazydog";
        Console.WriteLine("s:{0}",s);
        int __expected = 11187;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ValueOfString().findValue(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example6()
    {
        string s = "zyxwvutsrqponmlkjihgfedcba";
        Console.WriteLine("s:{0}",s);
        int __expected = 6201;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ValueOfString().findValue(s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
