using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class DifferentStringsTest
{
    [TestMethod]
    public void Example0()
    {
        string A = "koder";
        Console.WriteLine("A:{0}",A);
        string B = "topcoder";
        Console.WriteLine("B:{0}",B);
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new DifferentStrings().minimize(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string A = "hello";
        Console.WriteLine("A:{0}",A);
        string B = "xello";
        Console.WriteLine("B:{0}",B);
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new DifferentStrings().minimize(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string A = "abc";
        Console.WriteLine("A:{0}",A);
        string B = "topabcoder";
        Console.WriteLine("B:{0}",B);
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new DifferentStrings().minimize(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string A = "adaabc";
        Console.WriteLine("A:{0}",A);
        string B = "aababbc";
        Console.WriteLine("B:{0}",B);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new DifferentStrings().minimize(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string A = "giorgi";
        Console.WriteLine("A:{0}",A);
        string B = "igroig";
        Console.WriteLine("B:{0}",B);
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new DifferentStrings().minimize(A, B);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
