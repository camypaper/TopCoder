using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string s = Scanner.In.@string();
        Console.WriteLine("s:{0}",s);
        int K = Scanner.In.@int();
        Console.WriteLine("K:{0}",K);
        string __result  = new Decipherability().check(s, K);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string s = "snuke";
        Console.WriteLine("s:{0}",s);
        int K = 2;
        Console.WriteLine("K:{0}",K);
        string __expected = "Certain";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new Decipherability().check(s, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string s = "aba";
        Console.WriteLine("s:{0}",s);
        int K = 1;
        Console.WriteLine("K:{0}",K);
        string __expected = "Certain";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new Decipherability().check(s, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string s = "aba";
        Console.WriteLine("s:{0}",s);
        int K = 2;
        Console.WriteLine("K:{0}",K);
        string __expected = "Uncertain";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new Decipherability().check(s, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string s = "abcdabcd";
        Console.WriteLine("s:{0}",s);
        int K = 3;
        Console.WriteLine("K:{0}",K);
        string __expected = "Certain";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new Decipherability().check(s, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string s = "koukyoukoukokukikou";
        Console.WriteLine("s:{0}",s);
        int K = 2;
        Console.WriteLine("K:{0}",K);
        string __expected = "Uncertain";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new Decipherability().check(s, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        string s = "wolfsothe";
        Console.WriteLine("s:{0}",s);
        int K = 8;
        Console.WriteLine("K:{0}",K);
        string __expected = "Uncertain";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new Decipherability().check(s, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example6()
    {
        string s = "aa";
        Console.WriteLine("s:{0}",s);
        int K = 2;
        Console.WriteLine("K:{0}",K);
        string __expected = "Certain";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new Decipherability().check(s, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
