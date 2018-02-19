using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int[] item = Scanner.In.int_array();
        Console.WriteLine(string.Format("item:{0}",string.Join(" ",item)));
        int __result  = new BinPackingEasy().minBins(item);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int[] item = new int[] {
            150,
            150,
            150,
            150,
            150
        };
        Console.WriteLine(string.Format("item:{0}",string.Join(" ",item)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BinPackingEasy().minBins(item);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] item = new int[] {
            130,
            140,
            150,
            160
        };
        Console.WriteLine(string.Format("item:{0}",string.Join(" ",item)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BinPackingEasy().minBins(item);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] item = new int[] {
            101,
            101,
            101,
            101,
            101,
            101,
            101,
            101,
            101
        };
        Console.WriteLine(string.Format("item:{0}",string.Join(" ",item)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BinPackingEasy().minBins(item);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] item = new int[] {
            101,
            200,
            101,
            101,
            101,
            101,
            200,
            101,
            200
        };
        Console.WriteLine(string.Format("item:{0}",string.Join(" ",item)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BinPackingEasy().minBins(item);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] item = new int[] {
            123,
            145,
            167,
            213,
            245,
            267,
            289,
            132,
            154,
            176,
            198
        };
        Console.WriteLine(string.Format("item:{0}",string.Join(" ",item)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new BinPackingEasy().minBins(item);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
