using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public void ManualTest()
    {
        int mov1 = Scanner.In.@int();
        Console.WriteLine("mov1:{0}",mov1);
        int mov2 = Scanner.In.@int();
        Console.WriteLine("mov2:{0}",mov2);
        int d = Scanner.In.@int();
        Console.WriteLine("d:{0}",d);
        string __result  = new FoxAndFencingEasy().WhoCanWin(mov1, mov2, d);; ;
        Console.WriteLine("__result:{0}",__result);
 
    }

    [TestMethod]
    public void Example0()
    {
        int mov1 = 1;
        Console.WriteLine("mov1:{0}",mov1);
        int mov2 = 58;
        Console.WriteLine("mov2:{0}",mov2);
        int d = 1;
        Console.WriteLine("d:{0}",d);
        string __expected = "Ciel";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new FoxAndFencingEasy().WhoCanWin(mov1, mov2, d);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int mov1 = 100;
        Console.WriteLine("mov1:{0}",mov1);
        int mov2 = 100;
        Console.WriteLine("mov2:{0}",mov2);
        int d = 100000000;
        Console.WriteLine("d:{0}",d);
        string __expected = "Draw";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new FoxAndFencingEasy().WhoCanWin(mov1, mov2, d);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int mov1 = 100;
        Console.WriteLine("mov1:{0}",mov1);
        int mov2 = 150;
        Console.WriteLine("mov2:{0}",mov2);
        int d = 100000000;
        Console.WriteLine("d:{0}",d);
        string __expected = "Draw";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new FoxAndFencingEasy().WhoCanWin(mov1, mov2, d);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int mov1 = 100;
        Console.WriteLine("mov1:{0}",mov1);
        int mov2 = 250;
        Console.WriteLine("mov2:{0}",mov2);
        int d = 100000000;
        Console.WriteLine("d:{0}",d);
        string __expected = "Liss";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new FoxAndFencingEasy().WhoCanWin(mov1, mov2, d);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
