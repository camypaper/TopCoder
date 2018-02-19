using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int[] p = Scanner.In.int_array();
        Console.WriteLine(string.Format("p:{0}",string.Join(" ",p)));
        string s = Scanner.In.@string();
        Console.WriteLine("s:{0}",s);
        double __result  = new SquareScores().calcexpectation(p, s);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int[] p = new int[] {
            1,
            99
        };
        Console.WriteLine(string.Format("p:{0}",string.Join(" ",p)));
        string s = "aaaba";
        Console.WriteLine("s:{0}",s);
        double __expected = 8.0;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new SquareScores().calcexpectation(p, s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example1()
    {
        int[] p = new int[] {
            10,
            20,
            70
        };
        Console.WriteLine(string.Format("p:{0}",string.Join(" ",p)));
        string s = "aa?bbbb";
        Console.WriteLine("s:{0}",s);
        double __expected = 15.0;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new SquareScores().calcexpectation(p, s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example2()
    {
        int[] p = new int[] {
            10,
            20,
            30,
            40
        };
        Console.WriteLine(string.Format("p:{0}",string.Join(" ",p)));
        string s = "a??c?dc?b";
        Console.WriteLine("s:{0}",s);
        double __expected = 11.117;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new SquareScores().calcexpectation(p, s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example3()
    {
        int[] p = new int[] {
            25,
            25,
            21,
            2,
            2,
            25
        };
        Console.WriteLine(string.Format("p:{0}",string.Join(" ",p)));
        string s = "a??b???????ff??e";
        Console.WriteLine("s:{0}",s);
        double __expected = 21.68512690712425;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new SquareScores().calcexpectation(p, s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example4()
    {
        int[] p = new int[] {
            4,
            4,
            4,
            3,
            4,
            4,
            4,
            4,
            4,
            4,
            3,
            4,
            4,
            4,
            3,
            4,
            4,
            4,
            4,
            4,
            4,
            4,
            3,
            4,
            4,
            4
        };
        Console.WriteLine(string.Format("p:{0}",string.Join(" ",p)));
        string s = "??????????????????????????????";
        Console.WriteLine("s:{0}",s);
        double __expected = 31.16931963781721;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new SquareScores().calcexpectation(p, s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example5()
    {
        int[] p = new int[] {
            4,
            3,
            4,
            3,
            8,
            2,
            4,
            3,
            4,
            4,
            3,
            2,
            4,
            4,
            3,
            4,
            2,
            4,
            7,
            6,
            4,
            4,
            3,
            4,
            4,
            3
        };
        Console.WriteLine(string.Format("p:{0}",string.Join(" ",p)));
        string s = "makigotapresentfromniko";
        Console.WriteLine("s:{0}",s);
        double __expected = 23.0;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new SquareScores().calcexpectation(p, s);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

}
