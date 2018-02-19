using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class ChristmasTreeDecorationDiv2Test
{
    [TestMethod]
    public void Example0()
    {
        int[] col = new int[] {
            1,
            2,
            3,
            3
        };
        Console.WriteLine(string.Format("col:{0}",string.Join(" ",col)));
        int[] x = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ChristmasTreeDecorationDiv2().solve(col, x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] col = new int[] {
            1,
            3,
            5
        };
        Console.WriteLine(string.Format("col:{0}",string.Join(" ",col)));
        int[] x = new int[] {
            1,
            3
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            2,
            2
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ChristmasTreeDecorationDiv2().solve(col, x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] col = new int[] {
            1,
            1,
            3,
            3
        };
        Console.WriteLine(string.Format("col:{0}",string.Join(" ",col)));
        int[] x = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            2,
            1,
            4
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ChristmasTreeDecorationDiv2().solve(col, x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] col = new int[] {
            5,
            5,
            5,
            5
        };
        Console.WriteLine(string.Format("col:{0}",string.Join(" ",col)));
        int[] x = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ChristmasTreeDecorationDiv2().solve(col, x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] col = new int[] {
            9,
            1,
            1
        };
        Console.WriteLine(string.Format("col:{0}",string.Join(" ",col)));
        int[] x = new int[] {
            3,
            2
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new ChristmasTreeDecorationDiv2().solve(col, x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
