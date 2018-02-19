using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string[] board = Scanner.In.string_array();
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __result  = new CutTheNumbers().maximumSum(board);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string[] board = new string[] {
            "123",
            "312"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 435;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CutTheNumbers().maximumSum(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string[] board = new string[] {
            "99",
            "11"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 182;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CutTheNumbers().maximumSum(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string[] board = new string[] {
            "001",
            "010",
            "111",
            "100"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 1131;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CutTheNumbers().maximumSum(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string[] board = new string[] {
            "8"
        };
        Console.WriteLine(string.Format("board:{0}",string.Join(" ",board)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new CutTheNumbers().maximumSum(board);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
