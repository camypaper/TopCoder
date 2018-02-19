using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class ElectronicPetEasyTest
{
    [TestMethod]
    public void Example0()
    {
        int st1 = 3;
        Console.WriteLine("st1:{0}",st1);
        int p1 = 3;
        Console.WriteLine("p1:{0}",p1);
        int t1 = 3;
        Console.WriteLine("t1:{0}",t1);
        int st2 = 5;
        Console.WriteLine("st2:{0}",st2);
        int p2 = 2;
        Console.WriteLine("p2:{0}",p2);
        int t2 = 3;
        Console.WriteLine("t2:{0}",t2);
        string __expected = "Difficult";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new ElectronicPetEasy().isDifficult(st1, p1, t1, st2, p2, t2);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        int st1 = 3;
        Console.WriteLine("st1:{0}",st1);
        int p1 = 3;
        Console.WriteLine("p1:{0}",p1);
        int t1 = 3;
        Console.WriteLine("t1:{0}",t1);
        int st2 = 5;
        Console.WriteLine("st2:{0}",st2);
        int p2 = 2;
        Console.WriteLine("p2:{0}",p2);
        int t2 = 2;
        Console.WriteLine("t2:{0}",t2);
        string __expected = "Easy";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new ElectronicPetEasy().isDifficult(st1, p1, t1, st2, p2, t2);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        int st1 = 1;
        Console.WriteLine("st1:{0}",st1);
        int p1 = 4;
        Console.WriteLine("p1:{0}",p1);
        int t1 = 7;
        Console.WriteLine("t1:{0}",t1);
        int st2 = 1;
        Console.WriteLine("st2:{0}",st2);
        int p2 = 4;
        Console.WriteLine("p2:{0}",p2);
        int t2 = 7;
        Console.WriteLine("t2:{0}",t2);
        string __expected = "Difficult";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new ElectronicPetEasy().isDifficult(st1, p1, t1, st2, p2, t2);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        int st1 = 1;
        Console.WriteLine("st1:{0}",st1);
        int p1 = 1000;
        Console.WriteLine("p1:{0}",p1);
        int t1 = 1000;
        Console.WriteLine("t1:{0}",t1);
        int st2 = 2;
        Console.WriteLine("st2:{0}",st2);
        int p2 = 1000;
        Console.WriteLine("p2:{0}",p2);
        int t2 = 1000;
        Console.WriteLine("t2:{0}",t2);
        string __expected = "Easy";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new ElectronicPetEasy().isDifficult(st1, p1, t1, st2, p2, t2);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example4()
    {
        int st1 = 1;
        Console.WriteLine("st1:{0}",st1);
        int p1 = 1;
        Console.WriteLine("p1:{0}",p1);
        int t1 = 1;
        Console.WriteLine("t1:{0}",t1);
        int st2 = 2;
        Console.WriteLine("st2:{0}",st2);
        int p2 = 2;
        Console.WriteLine("p2:{0}",p2);
        int t2 = 2;
        Console.WriteLine("t2:{0}",t2);
        string __expected = "Easy";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new ElectronicPetEasy().isDifficult(st1, p1, t1, st2, p2, t2);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
