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
        int __result = new RockPaperScissorsMagicEasy().count(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] card, int score)
    {
        Console.WriteLine(string.Format("card:{0}", string.Join(" ",card)));
        Console.WriteLine("score:{0}", score);
        int __expected = new RockPaperScissorsMagicEasy().count(card, score);
        
        int __result = new RockPaperScissorsMagicEasy().Naive_Test(card, score);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] card, int score)
    {
        Console.WriteLine(string.Format("card:{0}", string.Join(" ",card)));
        Console.WriteLine("score:{0}", score);
        int __result = new RockPaperScissorsMagicEasy().count(card, score);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] card = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("card:{0}", string.Join(" ", card)));
        int score = 2;
        Console.WriteLine("score:{0}", score);
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RockPaperScissorsMagicEasy().count(card, score);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] card = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("card:{0}", string.Join(" ", card)));
        int score = 0;
        Console.WriteLine("score:{0}", score);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RockPaperScissorsMagicEasy().count(card, score);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] card = new int[] {
            2,
            2,
            1,
            0,
            0
        };
        Console.WriteLine(string.Format("card:{0}", string.Join(" ", card)));
        int score = 10;
        Console.WriteLine("score:{0}", score);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RockPaperScissorsMagicEasy().count(card, score);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] card = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("card:{0}", string.Join(" ", card)));
        int score = 7;
        Console.WriteLine("score:{0}", score);
        int __expected = 286226628;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RockPaperScissorsMagicEasy().count(card, score);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] card = new int[] {
            0,
            1,
            2,
            0,
            1,
            2,
            2,
            1,
            0
        };
        Console.WriteLine(string.Format("card:{0}", string.Join(" ", card)));
        int score = 8;
        Console.WriteLine("score:{0}", score);
        int __expected = 18;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new RockPaperScissorsMagicEasy().count(card, score);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
