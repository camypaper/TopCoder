using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        string[] A = Scanner.In.string_array();
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int __result  = new Revmatching().smallest(A);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        string[] A = new string[] {
            "1"
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Revmatching().smallest(A);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string[] A = new string[] {
            "0"
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Revmatching().smallest(A);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string[] A = new string[] {
            "44",
            "44"
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int __expected = 8;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Revmatching().smallest(A);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string[] A = new string[] {
            "861",
            "870",
            "245"
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Revmatching().smallest(A);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        string[] A = new string[] {
            "01000",
            "30200",
            "11102",
            "10001",
            "11001"
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Revmatching().smallest(A);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        string[] A = new string[] {
            "0111101100",
            "0001101001",
            "1001001000",
            "1000100001",
            "0110011111",
            "0011110100",
            "1000001100",
            "0001100000",
            "1000100001",
            "0101110010"
        };
        Console.WriteLine(string.Format("A:{0}",string.Join(" ",A)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Revmatching().smallest(A);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
