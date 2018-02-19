using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class PeacefulLineTest
{
    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        string __expected = "possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PeacefulLine().makeLine(x);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            1,
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        string __expected = "impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PeacefulLine().makeLine(x);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            1,
            1,
            2,
            2,
            3,
            3,
            4,
            4
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        string __expected = "possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PeacefulLine().makeLine(x);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            3,
            3,
            3,
            3,
            13,
            13,
            13,
            13
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        string __expected = "possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PeacefulLine().makeLine(x);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] x = new int[] {
            3,
            7,
            7,
            7,
            3,
            7,
            7,
            7,
            3
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        string __expected = "impossible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PeacefulLine().makeLine(x);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        int[] x = new int[] {
            25,
            12,
            3,
            25,
            25,
            12,
            12,
            12,
            12,
            3,
            25
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        string __expected = "possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PeacefulLine().makeLine(x);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example6()
    {
        int[] x = new int[] {
            3,
            3,
            3,
            3,
            13,
            13,
            13,
            13,
            3
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        string __expected = "possible";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new PeacefulLine().makeLine(x);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
