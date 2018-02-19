using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class TheKingsArmyDiv1Test
{
    [TestMethod]
    public void Example0()
    {
        string[] state = new string[] {
            "HSH",
            "SHS"
        };
        Console.WriteLine(string.Format("state:{0}",string.Join(" ",state)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TheKingsArmyDiv1().getNumber(state);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string[] state = new string[] {
            "HH",
            "HH"
        };
        Console.WriteLine(string.Format("state:{0}",string.Join(" ",state)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TheKingsArmyDiv1().getNumber(state);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string[] state = new string[] {
            "HHHHH",
            "HSHSH"
        };
        Console.WriteLine(string.Format("state:{0}",string.Join(" ",state)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TheKingsArmyDiv1().getNumber(state);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string[] state = new string[] {
            "S",
            "S"
        };
        Console.WriteLine(string.Format("state:{0}",string.Join(" ",state)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TheKingsArmyDiv1().getNumber(state);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string[] state = new string[] {
            "HSHHSHSHSHHHSHSHSH",
            "SSSSHSSHSHSHHSSSSH"
        };
        Console.WriteLine(string.Format("state:{0}",string.Join(" ",state)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TheKingsArmyDiv1().getNumber(state);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        string[] state = new string[] {
            "HS",
            "HS"
        };
        Console.WriteLine(string.Format("state:{0}",string.Join(" ",state)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new TheKingsArmyDiv1().getNumber(state);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
