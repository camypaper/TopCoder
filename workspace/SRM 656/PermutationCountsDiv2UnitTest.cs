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
        int __result = new PermutationCountsDiv2().countPermutations(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int N, int[] pos)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ",pos)));
        int __expected = new PermutationCountsDiv2().countPermutations(N, pos);
        
        int __result = new PermutationCountsDiv2().Naive_Test(N, pos);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int N, int[] pos)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ",pos)));
        int __result = new PermutationCountsDiv2().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int[] pos = new int[] {
            3
        };
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ", pos)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PermutationCountsDiv2().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int N = 13;
        Console.WriteLine("N:{0}", N);
        int[] pos = new int[] {
            12,
            11,
            10,
            9,
            8,
            7,
            6,
            5,
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ", pos)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PermutationCountsDiv2().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int N = 13;
        Console.WriteLine("N:{0}", N);
        int[] pos = new int[] {
        };
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ", pos)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PermutationCountsDiv2().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int N = 9;
        Console.WriteLine("N:{0}", N);
        int[] pos = new int[] {
            2,
            4,
            5
        };
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ", pos)));
        int __expected = 1421;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PermutationCountsDiv2().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int N = 80;
        Console.WriteLine("N:{0}", N);
        int[] pos = new int[] {
            31,
            41,
            59,
            26,
            53,
            58,
            9,
            79,
            32,
            3,
            8,
            46
        };
        Console.WriteLine(string.Format("pos:{0}", string.Join(" ", pos)));
        int __expected = 82650786;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new PermutationCountsDiv2().countPermutations(N, pos);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
