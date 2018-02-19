using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class CucumberMarketTest
{
    [TestMethod]
    public void Example0()
    {
        int[] price = new int[] {
            1000,
            1,
            10,
            100
        };
        Console.WriteLine(string.Format("price:{0}",string.Join(" ",price)));
        int budget = 1110;
        Console.WriteLine("budget:{0}",budget);
        int k = 3;
        Console.WriteLine("k:{0}",k);
        string __expected = "YES";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CucumberMarket().check(price, budget, k);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] price = new int[] {
            1000,
            1,
            10,
            100
        };
        Console.WriteLine(string.Format("price:{0}",string.Join(" ",price)));
        int budget = 1109;
        Console.WriteLine("budget:{0}",budget);
        int k = 3;
        Console.WriteLine("k:{0}",k);
        string __expected = "NO";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CucumberMarket().check(price, budget, k);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] price = new int[] {
            33,
            4
        };
        Console.WriteLine(string.Format("price:{0}",string.Join(" ",price)));
        int budget = 33;
        Console.WriteLine("budget:{0}",budget);
        int k = 1;
        Console.WriteLine("k:{0}",k);
        string __expected = "YES";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CucumberMarket().check(price, budget, k);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] price = new int[] {
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("price:{0}",string.Join(" ",price)));
        int budget = 2;
        Console.WriteLine("budget:{0}",budget);
        int k = 4;
        Console.WriteLine("k:{0}",k);
        string __expected = "NO";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CucumberMarket().check(price, budget, k);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] price = new int[] {
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000
        };
        Console.WriteLine(string.Format("price:{0}",string.Join(" ",price)));
        int budget = 10000;
        Console.WriteLine("budget:{0}",budget);
        int k = 9;
        Console.WriteLine("k:{0}",k);
        string __expected = "YES";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CucumberMarket().check(price, budget, k);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
