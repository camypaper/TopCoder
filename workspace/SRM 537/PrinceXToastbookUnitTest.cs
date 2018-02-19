using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int[] prerequisite = Scanner.In.int_array();
        Console.WriteLine(string.Format("prerequisite:{0}",string.Join(" ",prerequisite)));
        double __result  = new PrinceXToastbook().eat(prerequisite);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int[] prerequisite = new int[] {
            -1,
            0
        };
        Console.WriteLine(string.Format("prerequisite:{0}",string.Join(" ",prerequisite)));
        double __expected = 1.5;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new PrinceXToastbook().eat(prerequisite);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example1()
    {
        int[] prerequisite = new int[] {
            -1,
            0,
            1
        };
        Console.WriteLine(string.Format("prerequisite:{0}",string.Join(" ",prerequisite)));
        double __expected = 1.6666666666666667;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new PrinceXToastbook().eat(prerequisite);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example2()
    {
        int[] prerequisite = new int[] {
            1,
            -1,
            1
        };
        Console.WriteLine(string.Format("prerequisite:{0}",string.Join(" ",prerequisite)));
        double __expected = 2.0;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new PrinceXToastbook().eat(prerequisite);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example3()
    {
        int[] prerequisite = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("prerequisite:{0}",string.Join(" ",prerequisite)));
        double __expected = 0.0;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new PrinceXToastbook().eat(prerequisite);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

    [TestMethod]
    public void Example4()
    {
        int[] prerequisite = new int[] {
            -1,
            -1
        };
        Console.WriteLine(string.Format("prerequisite:{0}",string.Join(" ",prerequisite)));
        double __expected = 2.0;
        Console.WriteLine("__expected:{0}",__expected);
        double __result = new PrinceXToastbook().eat(prerequisite);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result,1e-9);
    }

}
