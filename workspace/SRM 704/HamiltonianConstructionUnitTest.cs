using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        string[] __result = new HamiltonianConstruction().construct(parser.Items[0]);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
	}
    public void Challenge(int k)
    {
        Console.WriteLine("k:{0}", k);
        string[] __expected = new HamiltonianConstruction().construct(k);
        
        string[] __result = new HamiltonianConstruction().Naive_Test(k);

            CollectionAssert.AreEquivalent(__expected, __result);
         }
    public void ManualTest(int k)
    {
        Console.WriteLine("k:{0}", k);
        string[] __result = new HamiltonianConstruction().construct(k);
        //Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int k = 1;
        Console.WriteLine("k:{0}", k);
        string[] __expected = new string[] {
            "NY",
            "NN"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new HamiltonianConstruction().construct(k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int k = 3;
        Console.WriteLine("k:{0}", k);
        string[] __expected = new string[] {
            "NYYNY",
            "YNYYY",
            "YYNYY",
            "YNYNY",
            "YYYYN"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new HamiltonianConstruction().construct(k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int k = 720;
        Console.WriteLine("k:{0}", k);
        string[] __expected = new string[] {
            "NYYYYYYY",
            "YNYYYYYY",
            "YYNYYYYY",
            "YYYNYYYY",
            "YYYYNYYY",
            "YYYYYNYY",
            "YYYYYYNY",
            "YYYYYYYN"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new HamiltonianConstruction().construct(k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int k = 288;
        Console.WriteLine("k:{0}", k);
        string[] __expected = new string[] {
            "NYYYYNYY",
            "YNYYYYYY",
            "YYNYYYNY",
            "YYYNYYYY",
            "YNYYNYYY",
            "YYYYYNYN",
            "YYNYYYNY",
            "YYYYYNNN"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new HamiltonianConstruction().construct(k);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
