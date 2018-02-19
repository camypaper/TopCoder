using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string s = Scanner.In.@string();
        Console.WriteLine("s:{0}",s);
        string t = Scanner.In.@string();
        Console.WriteLine("t:{0}",t);
        string __result  = new DecipherabilityEasy().check(s, t);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string s = "sunuke";
        Console.WriteLine("s:{0}",s);
        string t = "snuke";
        Console.WriteLine("t:{0}",t);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new DecipherabilityEasy().check(s, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string s = "snuke";
        Console.WriteLine("s:{0}",s);
        string t = "skue";
        Console.WriteLine("t:{0}",t);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new DecipherabilityEasy().check(s, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string s = "snuke";
        Console.WriteLine("s:{0}",s);
        string t = "snuke";
        Console.WriteLine("t:{0}",t);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new DecipherabilityEasy().check(s, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string s = "snukent";
        Console.WriteLine("s:{0}",s);
        string t = "snuke";
        Console.WriteLine("t:{0}",t);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new DecipherabilityEasy().check(s, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string s = "aaaaa";
        Console.WriteLine("s:{0}",s);
        string t = "aaaa";
        Console.WriteLine("t:{0}",t);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new DecipherabilityEasy().check(s, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        string s = "aaaaa";
        Console.WriteLine("s:{0}",s);
        string t = "aaa";
        Console.WriteLine("t:{0}",t);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new DecipherabilityEasy().check(s, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example6()
    {
        string s = "topcoder";
        Console.WriteLine("s:{0}",s);
        string t = "tpcoder";
        Console.WriteLine("t:{0}",t);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new DecipherabilityEasy().check(s, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example7()
    {
        string s = "singleroundmatch";
        Console.WriteLine("s:{0}",s);
        string t = "singeroundmatc";
        Console.WriteLine("t:{0}",t);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new DecipherabilityEasy().check(s, t);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
