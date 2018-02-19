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
        int __result = new MovingCandies().minMoved(parser.Items[0]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(string[] t)
    {
        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
        int __expected = new MovingCandies().minMoved(t);
        
        int __result = new MovingCandies().Naive_Test(t);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(string[] t)
    {
        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
        int __result = new MovingCandies().minMoved(t);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] t = new string[] {
            "#...###",
            "#...#.#",
            "##..#.#",
            ".#....#"
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MovingCandies().minMoved(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] t = new string[] {
            "#...###",
            "#...#.#",
            "##..###",
            ".#....#"
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MovingCandies().minMoved(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] t = new string[] {
            ".#..",
            "##..",
            "..#.",
            "..#.",
            "..##",
            "..##"
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MovingCandies().minMoved(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] t = new string[] {
            ".....",
            ".###.",
            "####.",
            "....."
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MovingCandies().minMoved(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] t = new string[] {
            ".#...#.###.#",
            "#.#.##......",
            ".#.#......#.",
            "..#.......#.",
            "##.........."
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 9;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MovingCandies().minMoved(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] t = new string[] {
            "###.#########..#####",
            ".#######.###########"
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MovingCandies().minMoved(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        string[] t = new string[] {
            "..",
            ".."
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new MovingCandies().minMoved(t);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
