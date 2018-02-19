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
        int[] __result = new ModEquation().count(parser.Items[0], parser.Items[1], parser.Items[2]);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
	}
    public void Challenge(int n, int K, int[] query)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("K:{0}", K);
        Console.WriteLine(string.Format("query:{0}", string.Join(" ",query)));
        int[] __expected = new ModEquation().count(n, K, query);
        
        int[] __result = new ModEquation().Naive_Test(n, K, query);

            CollectionAssert.AreEquivalent(__expected, __result);
         }
    public void ManualTest(int n, int K, int[] query)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("K:{0}", K);
        Console.WriteLine(string.Format("query:{0}", string.Join(" ",query)));
        int[] __result = new ModEquation().count(n, K, query);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int[] query = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        int[] __expected = new int[] {
            3,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ModEquation().count(n, K, query);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int K = 4;
        Console.WriteLine("K:{0}", K);
        int[] query = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        int[] __expected = new int[] {
            8,
            2,
            4,
            2
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ModEquation().count(n, K, query);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int n = 6;
        Console.WriteLine("n:{0}", n);
        int K = 6;
        Console.WriteLine("K:{0}", K);
        int[] query = new int[] {
            4
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        int[] __expected = new int[] {
            2016
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ModEquation().count(n, K, query);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int n = 1;
        Console.WriteLine("n:{0}", n);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int[] query = new int[] {
            0,
            0,
            0,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        int[] __expected = new int[] {
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new ModEquation().count(n, K, query);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
