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
        int[] __result = new TreeDistanceConstruction().construct(parser.Items[0]);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
	}
    public void Challenge(int[] d)
    {
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        int[] __expected = new TreeDistanceConstruction().construct(d);
        
        int[] __result = new TreeDistanceConstruction().Naive_Test(d);

            CollectionAssert.AreEquivalent(__expected, __result);
         }
    public void ManualTest(int[] d)
    {
        Console.WriteLine(string.Format("d:{0}", string.Join(" ",d)));
        int[] __result = new TreeDistanceConstruction().construct(d);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int[] d = new int[] {
            3,
            2,
            2,
            3
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] __expected = new int[] {
            1,
            2,
            1,
            0,
            2,
            3
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TreeDistanceConstruction().construct(d);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int[] d = new int[] {
            1,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] __expected = new int[] {
            0,
            1,
            0,
            2,
            0,
            3
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TreeDistanceConstruction().construct(d);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int[] d = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] __expected = new int[] {
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TreeDistanceConstruction().construct(d);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int[] d = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] __expected = new int[] {
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TreeDistanceConstruction().construct(d);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        int[] d = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("d:{0}", string.Join(" ", d)));
        int[] __expected = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TreeDistanceConstruction().construct(d);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
