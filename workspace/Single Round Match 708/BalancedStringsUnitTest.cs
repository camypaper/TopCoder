using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        string[] __result = new BalancedStrings().findAny(parser.Items[0]);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
	}
    public void Challenge(int N)
    {
        Console.WriteLine("N:{0}", N);
        string[] __expected = new BalancedStrings().findAny(N);
        
        string[] __result = new BalancedStrings().Naive_Test(N);

            CollectionAssert.AreEquivalent(__expected, __result);
         }
    public void ManualTest(int N)
    {
        Console.WriteLine("N:{0}", N);
        string[] __result = new BalancedStrings().findAny(N);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        string[] __expected = new string[] {
            "eertree",
            "topcoder",
            "arena"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new BalancedStrings().findAny(N);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        string[] __expected = new string[] {
            "hello",
            "little",
            "polar",
            "bear"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new BalancedStrings().findAny(N);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        string[] __expected = new string[] {
            "abbbbbbbbbbbbczaaaaaao",
            "c",
            "zz",
            "c",
            "xxxyyyzvvv"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new BalancedStrings().findAny(N);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int N = 1;
        Console.WriteLine("N:{0}", N);
        string[] __expected = new string[] {
            "kkkkkkkkkkkkkkkkkkk"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new BalancedStrings().findAny(N);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        int N = 10;
        Console.WriteLine("N:{0}", N);
        string[] __expected = new string[] {
            "asdflkjhsdfsfffkdhjfdlshlfds",
            "pudelek",
            "xo",
            "xo",
            "mnbvmnmbbr",
            "plox",
            "qqwwrrttyyy",
            "you",
            "are",
            "awesome"
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        string[] __result = new BalancedStrings().findAny(N);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
