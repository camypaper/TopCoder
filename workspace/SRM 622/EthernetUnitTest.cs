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
	public void ManualTest(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int __result = new Ethernet().connect(parser.Items[0], parser.Items[1], parser.Items[2]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] parent, int[] dist, int maxDist)
    {
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ",parent)));
        Console.WriteLine(string.Format("dist:{0}", string.Join(" ",dist)));
        Console.WriteLine("maxDist:{0}", maxDist);
        int __expected = new Ethernet().connect(parent, dist, maxDist);
        
        int __result = new Ethernet().Naive_Test(parent, dist, maxDist);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] parent, int[] dist, int maxDist)
    {
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ",parent)));
        Console.WriteLine(string.Format("dist:{0}", string.Join(" ",dist)));
        Console.WriteLine("maxDist:{0}", maxDist);
        int __result = new Ethernet().connect(parent, dist, maxDist);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] parent = new int[] {
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ", parent)));
        int[] dist = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("dist:{0}", string.Join(" ", dist)));
        int maxDist = 2;
        Console.WriteLine("maxDist:{0}", maxDist);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Ethernet().connect(parent, dist, maxDist);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] parent = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ", parent)));
        int[] dist = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7
        };
        Console.WriteLine(string.Format("dist:{0}", string.Join(" ", dist)));
        int maxDist = 8;
        Console.WriteLine("maxDist:{0}", maxDist);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Ethernet().connect(parent, dist, maxDist);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] parent = new int[] {
            0,
            1,
            2,
            3,
            4,
            5
        };
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ", parent)));
        int[] dist = new int[] {
            1,
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("dist:{0}", string.Join(" ", dist)));
        int maxDist = 6;
        Console.WriteLine("maxDist:{0}", maxDist);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Ethernet().connect(parent, dist, maxDist);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] parent = new int[] {
            0,
            0,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ", parent)));
        int[] dist = new int[] {
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("dist:{0}", string.Join(" ", dist)));
        int maxDist = 2;
        Console.WriteLine("maxDist:{0}", maxDist);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Ethernet().connect(parent, dist, maxDist);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] parent = new int[] {
            0,
            1,
            0,
            3,
            0,
            5,
            0,
            6,
            0,
            6,
            0,
            6,
            4,
            6,
            9,
            4,
            5,
            5,
            2,
            5,
            2
        };
        Console.WriteLine(string.Format("parent:{0}", string.Join(" ", parent)));
        int[] dist = new int[] {
            93,
            42,
            104,
            105,
            59,
            73,
            161,
            130,
            30,
            81,
            62,
            93,
            131,
            133,
            139,
            5,
            13,
            34,
            25,
            111,
            4
        };
        Console.WriteLine(string.Format("dist:{0}", string.Join(" ", dist)));
        int maxDist = 162;
        Console.WriteLine("maxDist:{0}", maxDist);
        int __expected = 11;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Ethernet().connect(parent, dist, maxDist);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
