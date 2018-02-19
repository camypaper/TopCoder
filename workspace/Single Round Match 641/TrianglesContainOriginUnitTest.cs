using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class TrianglesContainOriginTest
{
    [TestMethod]
    public void Example0()
    {
        int[] x = new int[] {
            -1,
            -1,
            1
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            1,
            -1,
            0
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        long __expected = 1L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new TrianglesContainOrigin().count(x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] x = new int[] {
            -1,
            -1,
            1,
            2
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            1,
            -1,
            2,
            -1
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        long __expected = 2L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new TrianglesContainOrigin().count(x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] x = new int[] {
            -1,
            -2,
            3,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            -2,
            -1,
            1,
            2,
            3,
            3
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        long __expected = 8L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new TrianglesContainOrigin().count(x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] x = new int[] {
            1,
            5,
            10,
            5,
            -5,
            7,
            -9,
            -6,
            -3,
            0,
            8,
            8,
            1,
            -4,
            7,
            -3,
            10,
            9,
            -6
        };
        Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));
        int[] y = new int[] {
            5,
            -6,
            -3,
            4,
            -2,
            -8,
            -7,
            2,
            7,
            4,
            2,
            0,
            -4,
            -8,
            7,
            5,
            -5,
            -2,
            -9
        };
        Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));
        long __expected = 256L;
        Console.WriteLine("__expected:{0}",__expected);
        long __result = new TrianglesContainOrigin().count(x, y);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
