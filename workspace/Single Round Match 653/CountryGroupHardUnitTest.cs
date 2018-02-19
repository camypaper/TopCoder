using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int[] a = Scanner.In.int_array();
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        string __result  = new CountryGroupHard().solve(a);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int[] a = new int[] {
            0,
            2,
            3,
            0,
            0
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        string __expected = "Sufficient";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CountryGroupHard().solve(a);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] a = new int[] {
            0,
            2,
            0
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        string __expected = "Insufficient";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CountryGroupHard().solve(a);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] a = new int[] {
            0,
            3,
            0,
            0,
            3,
            0
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        string __expected = "Sufficient";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CountryGroupHard().solve(a);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] a = new int[] {
            0,
            0,
            3,
            3,
            0,
            0
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        string __expected = "Insufficient";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CountryGroupHard().solve(a);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] a = new int[] {
            2,
            2,
            0,
            2,
            2
        };
        Console.WriteLine(string.Format("a:{0}",string.Join(" ",a)));
        string __expected = "Sufficient";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new CountryGroupHard().solve(a);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
