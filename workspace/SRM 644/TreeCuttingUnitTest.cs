using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class TreeCuttingTest
{
    [TestMethod]
    public void Example0()
    {
        int[] par = new int[] {
            0,
            1,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("par:{0}",string.Join(" ",par)));
        int[] num = new int[] {
            2,
            -1,
            -1,
            4,
            -1,
            -1
        };
        Console.WriteLine(string.Format("num:{0}",string.Join(" ",num)));
        string __expected = "POSSIBLE";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new TreeCutting().can(par, num);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int[] par = new int[] {
            0,
            1,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("par:{0}",string.Join(" ",par)));
        int[] num = new int[] {
            3,
            -1,
            -1,
            3,
            -1,
            -1
        };
        Console.WriteLine(string.Format("num:{0}",string.Join(" ",num)));
        string __expected = "IMPOSSIBLE";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new TreeCutting().can(par, num);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int[] par = new int[] {
            0,
            1,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("par:{0}",string.Join(" ",par)));
        int[] num = new int[] {
            2,
            -1,
            -1,
            3,
            -1,
            -1
        };
        Console.WriteLine(string.Format("num:{0}",string.Join(" ",num)));
        string __expected = "IMPOSSIBLE";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new TreeCutting().can(par, num);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int[] par = new int[] {
            0,
            1,
            2,
            2,
            1,
            5,
            2,
            6,
            6
        };
        Console.WriteLine(string.Format("par:{0}",string.Join(" ",par)));
        int[] num = new int[] {
            -1,
            -1,
            2,
            -1,
            1,
            3,
            -1,
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("num:{0}",string.Join(" ",num)));
        string __expected = "POSSIBLE";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new TreeCutting().can(par, num);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int[] par = new int[] {
            0,
            1,
            2,
            2,
            1,
            5,
            2,
            6,
            6
        };
        Console.WriteLine(string.Format("par:{0}",string.Join(" ",par)));
        int[] num = new int[] {
            -1,
            -1,
            2,
            -1,
            1,
            -1,
            3,
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("num:{0}",string.Join(" ",num)));
        string __expected = "IMPOSSIBLE";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new TreeCutting().can(par, num);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example5()
    {
        int[] par = new int[] {
            0,
            0,
            0,
            0,
            1,
            1,
            2,
            3,
            3,
            3,
            4,
            4,
            4,
            5,
            9,
            9,
            14,
            14,
            14,
            16,
            20
        };
        Console.WriteLine(string.Format("par:{0}",string.Join(" ",par)));
        int[] num = new int[] {
            -1,
            3,
            -1,
            -1,
            -1,
            -1,
            -1,
            1,
            1,
            -1,
            -1,
            -1,
            3,
            1,
            -1,
            1,
            8,
            -1,
            -1,
            4,
            -1,
            -1
        };
        Console.WriteLine(string.Format("num:{0}",string.Join(" ",num)));
        string __expected = "POSSIBLE";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new TreeCutting().can(par, num);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example6()
    {
        int[] par = new int[] {
            0,
            0,
            0,
            0,
            1,
            1,
            2,
            3,
            3,
            3,
            4,
            4,
            4,
            5,
            9,
            9,
            14,
            14,
            14,
            16,
            20
        };
        Console.WriteLine(string.Format("par:{0}",string.Join(" ",par)));
        int[] num = new int[] {
            -1,
            2,
            -1,
            -1,
            -1,
            -1,
            -1,
            1,
            1,
            -1,
            -1,
            -1,
            3,
            1,
            -1,
            1,
            9,
            -1,
            -1,
            4,
            -1,
            -1
        };
        Console.WriteLine(string.Format("num:{0}",string.Join(" ",num)));
        string __expected = "IMPOSSIBLE";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new TreeCutting().can(par, num);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example7()
    {
        int[] par = new int[] {
            0,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("par:{0}",string.Join(" ",par)));
        int[] num = new int[] {
            -1,
            -1,
            5,
            -1,
            -1
        };
        Console.WriteLine(string.Format("num:{0}",string.Join(" ",num)));
        string __expected = "POSSIBLE";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new TreeCutting().can(par, num);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
