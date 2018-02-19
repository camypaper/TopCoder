using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string name = Scanner.In.@string();
        Console.WriteLine("name:{0}",name);
        string __result  = new KingXNewBaby().isValid(name);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string name = "dengklek";
        Console.WriteLine("name:{0}",name);
        string __expected = "YES";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new KingXNewBaby().isValid(name);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string name = "gofushar";
        Console.WriteLine("name:{0}",name);
        string __expected = "NO";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new KingXNewBaby().isValid(name);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string name = "dolphinigle";
        Console.WriteLine("name:{0}",name);
        string __expected = "NO";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new KingXNewBaby().isValid(name);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string name = "mystictc";
        Console.WriteLine("name:{0}",name);
        string __expected = "NO";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new KingXNewBaby().isValid(name);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string name = "rngringo";
        Console.WriteLine("name:{0}",name);
        string __expected = "NO";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new KingXNewBaby().isValid(name);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        string name = "misof";
        Console.WriteLine("name:{0}",name);
        string __expected = "NO";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new KingXNewBaby().isValid(name);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example6()
    {
        string name = "metelsky";
        Console.WriteLine("name:{0}",name);
        string __expected = "YES";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new KingXNewBaby().isValid(name);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
