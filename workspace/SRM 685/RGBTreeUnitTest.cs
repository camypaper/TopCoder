using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);    }
    public void ManualTest(string[] G)
    {
        Console.WriteLine(string.Format("G:{0}", string.Join(" ",G)));
        string __result = new RGBTree().exist(G);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] G = new string[] {
            ".RGB",
            "R...",
            "G...",
            "B..."
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        string __expected = "Exist";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RGBTree().exist(G);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] G = new string[] {
            ".RRB",
            "R...",
            "R...",
            "B..."
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        string __expected = "Does not exist";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RGBTree().exist(G);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] G = new string[] {
            ".R..BG..G..RG",
            "R...GG..BR.G.",
            "...G.GG.RR.BB",
            "..G.RR.B..GRB",
            "BG.R.G.BRRR.G",
            "GGGRG.R....RR",
            "..G..R.BGRR..",
            "...BB.B.RB.G.",
            "GBR.R.GR.B.R.",
            ".RR.R.RBB.BRB",
            "...GR.R..B...",
            "RGBR.R.GRR...",
            "G.BBGR...B..."
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        string __expected = "Exist";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RGBTree().exist(G);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] G = new string[] {
            ".............",
            ".......BB.R..",
            ".......RR....",
            ".....G.G....R",
            "........BB...",
            "...G.........",
            "........B...R",
            ".BRG.......G.",
            ".BR.B.B...GB.",
            "....B......GR",
            ".R......G....",
            ".......GBG..B",
            "...R..R..R.B."
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        string __expected = "Does not exist";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RGBTree().exist(G);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] G = new string[] {
            "..B.BB...RB..",
            "......R..B.G.",
            "B.......BB...",
            ".......R...G.",
            "B....GRB..R..",
            "B...G.RG.R...",
            ".R..RR..B.RB.",
            "...RBG...G...",
            "..B...B......",
            "RBB..R.G....R",
            "B...R.R......",
            ".G.G..B.....R",
            ".........R.R."
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        string __expected = "Exist";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RGBTree().exist(G);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] G = new string[] {
            "....",
            "....",
            "....",
            "...."
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        string __expected = "Does not exist";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new RGBTree().exist(G);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
