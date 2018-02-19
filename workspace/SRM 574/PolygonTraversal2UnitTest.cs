using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int N = Scanner.In.@int();
        Console.WriteLine("N:{0}",N);
        int[] points = Scanner.In.int_array();
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __result  = new PolygonTraversal2().count(N, points);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int N = 5;
        Console.WriteLine("N:{0}",N);
        int[] points = new int[] {
            1,
            3,
            5
        };
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new PolygonTraversal2().count(N, points);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int N = 6;
        Console.WriteLine("N:{0}",N);
        int[] points = new int[] {
            1,
            4,
            2
        };
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new PolygonTraversal2().count(N, points);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int N = 7;
        Console.WriteLine("N:{0}",N);
        int[] points = new int[] {
            2,
            4,
            7
        };
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new PolygonTraversal2().count(N, points);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int N = 7;
        Console.WriteLine("N:{0}",N);
        int[] points = new int[] {
            1,
            2,
            3,
            4,
            6,
            5
        };
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new PolygonTraversal2().count(N, points);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int N = 11;
        Console.WriteLine("N:{0}",N);
        int[] points = new int[] {
            1,
            5,
            10
        };
        Console.WriteLine(string.Format("points:{0}",string.Join(" ",points)));
        int __expected = 1412;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new PolygonTraversal2().count(N, points);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
