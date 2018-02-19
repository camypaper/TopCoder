using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int n = Scanner.In.@int();
        Console.WriteLine("n:{0}",n);
        int m = Scanner.In.@int();
        Console.WriteLine("m:{0}",m);
        string __result  = new FoxAndClassroom().ableTo(n, m);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int n = 2;
        Console.WriteLine("n:{0}",n);
        int m = 3;
        Console.WriteLine("m:{0}",m);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new FoxAndClassroom().ableTo(n, m);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int n = 2;
        Console.WriteLine("n:{0}",n);
        int m = 2;
        Console.WriteLine("m:{0}",m);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new FoxAndClassroom().ableTo(n, m);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int n = 4;
        Console.WriteLine("n:{0}",n);
        int m = 6;
        Console.WriteLine("m:{0}",m);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new FoxAndClassroom().ableTo(n, m);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int n = 3;
        Console.WriteLine("n:{0}",n);
        int m = 6;
        Console.WriteLine("m:{0}",m);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new FoxAndClassroom().ableTo(n, m);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int n = 5;
        Console.WriteLine("n:{0}",n);
        int m = 7;
        Console.WriteLine("m:{0}",m);
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new FoxAndClassroom().ableTo(n, m);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        int n = 10;
        Console.WriteLine("n:{0}",n);
        int m = 10;
        Console.WriteLine("m:{0}",m);
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new FoxAndClassroom().ableTo(n, m);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
