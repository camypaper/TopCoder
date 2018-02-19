using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int L = Scanner.In.@int();
        Console.WriteLine("L:{0}",L);
        int R = Scanner.In.@int();
        Console.WriteLine("R:{0}",R);
        int __result  = new Similars().maxsim(L, R);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int L = 1;
        Console.WriteLine("L:{0}",L);
        int R = 10;
        Console.WriteLine("R:{0}",R);
        int __expected = 1;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Similars().maxsim(L, R);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int L = 1;
        Console.WriteLine("L:{0}",L);
        int R = 99;
        Console.WriteLine("R:{0}",R);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Similars().maxsim(L, R);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int L = 99;
        Console.WriteLine("L:{0}",L);
        int R = 100;
        Console.WriteLine("R:{0}",R);
        int __expected = 0;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Similars().maxsim(L, R);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int L = 1000;
        Console.WriteLine("L:{0}",L);
        int R = 1010;
        Console.WriteLine("R:{0}",R);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Similars().maxsim(L, R);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int L = 444;
        Console.WriteLine("L:{0}",L);
        int R = 454;
        Console.WriteLine("R:{0}",R);
        int __expected = 2;
        Console.WriteLine("__expected:{0}",__expected);
        int __result = new Similars().maxsim(L, R);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
