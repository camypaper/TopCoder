using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int[] __result = new OddEvenTreeHard().getTree(parser.Items[0]);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
	}
    public void Challenge(string[] x)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        int[] __expected = new OddEvenTreeHard().getTree(x);
        
        int[] __result = new OddEvenTreeHard().Naive_Test(x);

            CollectionAssert.AreEquivalent(__expected, __result);
         }
    public void ManualTest(string[] x)
    {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        int[] __result = new OddEvenTreeHard().getTree(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        string[] x = new string[] {
            "EOE",
            "OEO",
            "EOE"
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] __expected = new int[] {
            0,
            1,
            2,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new OddEvenTreeHard().getTree(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        string[] x = new string[] {
            "????",
            "????",
            "????",
            "????"
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] __expected = new int[] {
            0,
            1,
            0,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new OddEvenTreeHard().getTree(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        string[] x = new string[] {
            "????",
            "????",
            "??O?",
            "????"
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] __expected = new int[] {
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new OddEvenTreeHard().getTree(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        string[] x = new string[] {
            "??O?",
            "????",
            "E???",
            "????"
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] __expected = new int[] {
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new OddEvenTreeHard().getTree(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        string[] x = new string[] {
            "?O??",
            "??O?",
            "???O",
            "????"
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] __expected = new int[] {
            0,
            1,
            0,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new OddEvenTreeHard().getTree(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example5()
    {
        string[] x = new string[] {
            "?E??",
            "??E?",
            "???E",
            "????"
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] __expected = new int[] {
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new OddEvenTreeHard().getTree(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example6()
    {
        string[] x = new string[] {
            "?????????????",
            "??????????OE?",
            "?????????????",
            "?????????????",
            "?????????????",
            "?????????????",
            "?????????????",
            "???????E?????",
            "???????E?????",
            "?????????????",
            "???????????O?",
            "???????????E?",
            "????????????E"
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int[] __expected = new int[] {
            0,
            1,
            0,
            3,
            0,
            5,
            0,
            7,
            0,
            8,
            0,
            11,
            0,
            12,
            2,
            1,
            4,
            1,
            6,
            1,
            9,
            1,
            10,
            1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new OddEvenTreeHard().getTree(x);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
