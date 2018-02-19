using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int[] a = Scanner.In.int_array();
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int K = Scanner.In.@int();
        Console.WriteLine("K:{0}",K);
        int __result  = new Autogame().wayscnt(a, K);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int K = 5;
        Console.WriteLine("K:{0}",K);
        int __expected = 8;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Autogame().wayscnt(a, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int K = 1;
        Console.WriteLine("K:{0}",K);
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Autogame().wayscnt(a, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int K = 42;
        Console.WriteLine("K:{0}",K);
        int __expected = 4;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Autogame().wayscnt(a, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            2,
            3,
            4,
            3
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int K = 3;
        Console.WriteLine("K:{0}",K);
        int __expected = 9;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Autogame().wayscnt(a, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] a = new int[] {
            4,
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        int K = 3;
        Console.WriteLine("K:{0}",K);
        int __expected = 18;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Autogame().wayscnt(a, K);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
