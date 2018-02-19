using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class ChocolateDividingEasyTest
{
    [TestMethod]
    public void Example0()
    {
        string[] chocolate = new string[] {
            "9768",
            "6767",
            "5313"
        };
        Console.WriteLine(string.Format("chocolate:{0}",string.Join(" ",chocolate)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ChocolateDividingEasy().findBest(chocolate);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string[] chocolate = new string[] {
            "36753562",
            "91270936",
            "06261879",
            "20237592",
            "28973612",
            "93194784"
        };
        Console.WriteLine(string.Format("chocolate:{0}",string.Join(" ",chocolate)));
        int __expected = 15;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ChocolateDividingEasy().findBest(chocolate);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string[] chocolate = new string[] {
            "012",
            "345",
            "678"
        };
        Console.WriteLine(string.Format("chocolate:{0}",string.Join(" ",chocolate)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ChocolateDividingEasy().findBest(chocolate);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
