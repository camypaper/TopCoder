using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0); Tests.Add(Example1); Tests.Add(Example2); Tests.Add(Example3); Tests.Add(Example4); Tests.Add(Example5);
    }
    public void ManualTestFromInput(string myinput)
    {
        var parser = new Parser(myinput);
        parser.Parse();
        var a = new List<int>();
        var b = new List<int>();
        foreach (var x in parser.Items[0])
            a.Add((int)x);
        foreach (var x in parser.Items[1])
            b.Add((int)x);

        int __result = new CatsOnTheLineDiv1().getNumber(a.ToArray(), b.ToArray(), (int)parser.Items[2]);
        Console.WriteLine("__result:{0}", __result);
    }
    public void Challenge(int[] position, int[] count, int time)
    {
        Console.WriteLine(string.Format("position:{0}", string.Join(" ", position)));
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        Console.WriteLine("time:{0}", time);
        int __expected = new CatsOnTheLineDiv1().getNumber(position, count, time);

        int __result = new CatsOnTheLineDiv1().Naive_Test(position, count, time);

        Assert.AreEqual(__expected, __result);
    }
    public void ManualTest(int[] position, int[] count, int time)
    {
        Console.WriteLine(string.Format("position:{0}", string.Join(" ", position)));
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        Console.WriteLine("time:{0}", time);
        int __result = new CatsOnTheLineDiv1().getNumber(position, count, time);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] position = new int[] {
            0
        };
        Console.WriteLine(string.Format("position:{0}", string.Join(" ", position)));
        int[] count = new int[] {
            7
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        int time = 3;
        Console.WriteLine("time:{0}", time);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatsOnTheLineDiv1().getNumber(position, count, time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] position = new int[] {
            0
        };
        Console.WriteLine(string.Format("position:{0}", string.Join(" ", position)));
        int[] count = new int[] {
            6
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        int time = 2;
        Console.WriteLine("time:{0}", time);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatsOnTheLineDiv1().getNumber(position, count, time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] position = new int[] {
            4,
            7,
            47
        };
        Console.WriteLine(string.Format("position:{0}", string.Join(" ", position)));
        int[] count = new int[] {
            4,
            7,
            4
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        int time = 1;
        Console.WriteLine("time:{0}", time);
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatsOnTheLineDiv1().getNumber(position, count, time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] position = new int[] {
            3,
            0,
            7,
            10
        };
        Console.WriteLine(string.Format("position:{0}", string.Join(" ", position)));
        int[] count = new int[] {
            3,
            7,
            4,
            5
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        int time = 2;
        Console.WriteLine("time:{0}", time);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatsOnTheLineDiv1().getNumber(position, count, time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] position = new int[] {
            -5,
            0,
            7
        };
        Console.WriteLine(string.Format("position:{0}", string.Join(" ", position)));
        int[] count = new int[] {
            47,
            85,
            10
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        int time = 6;
        Console.WriteLine("time:{0}", time);
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatsOnTheLineDiv1().getNumber(position, count, time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] position = new int[] {
            -8,
            12,
            -15,
            -20,
            17,
            -5,
            7,
            10
        };
        Console.WriteLine(string.Format("position:{0}", string.Join(" ", position)));
        int[] count = new int[] {
            20,
            10,
            7,
            9,
            2,
            8,
            11,
            10
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        int time = 2;
        Console.WriteLine("time:{0}", time);
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CatsOnTheLineDiv1().getNumber(position, count, time);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
