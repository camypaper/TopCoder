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
        int __result = new StoryFromTCO().minimumChanges(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] places, int[] cutoff)
    {
        Console.WriteLine(string.Format("places:{0}", string.Join(" ",places)));
        Console.WriteLine(string.Format("cutoff:{0}", string.Join(" ",cutoff)));
        int __expected = new StoryFromTCO().minimumChanges(places, cutoff);
        
        int __result = new StoryFromTCO().Naive_Test(places, cutoff);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] places, int[] cutoff)
    {
        Console.WriteLine(string.Format("places:{0}", string.Join(" ",places)));
        Console.WriteLine(string.Format("cutoff:{0}", string.Join(" ",cutoff)));
        int __result = new StoryFromTCO().minimumChanges(places, cutoff);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] places = new int[] {
            20,
            100,
            500,
            50
        };
        Console.WriteLine(string.Format("places:{0}", string.Join(" ", places)));
        int[] cutoff = new int[] {
            7500,
            2250,
            150,
            24
        };
        Console.WriteLine(string.Format("cutoff:{0}", string.Join(" ", cutoff)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new StoryFromTCO().minimumChanges(places, cutoff);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] places = new int[] {
            5,
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("places:{0}", string.Join(" ", places)));
        int[] cutoff = new int[] {
            5,
            4,
            3,
            2,
            1
        };
        Console.WriteLine(string.Format("cutoff:{0}", string.Join(" ", cutoff)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new StoryFromTCO().minimumChanges(places, cutoff);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] places = new int[] {
            1,
            5,
            5,
            5
        };
        Console.WriteLine(string.Format("places:{0}", string.Join(" ", places)));
        int[] cutoff = new int[] {
            8,
            6,
            4,
            2
        };
        Console.WriteLine(string.Format("cutoff:{0}", string.Join(" ", cutoff)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new StoryFromTCO().minimumChanges(places, cutoff);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] places = new int[] {
            3,
            1,
            5
        };
        Console.WriteLine(string.Format("places:{0}", string.Join(" ", places)));
        int[] cutoff = new int[] {
            6,
            4,
            2
        };
        Console.WriteLine(string.Format("cutoff:{0}", string.Join(" ", cutoff)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new StoryFromTCO().minimumChanges(places, cutoff);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] places = new int[] {
            14,
            11,
            42,
            9,
            19
        };
        Console.WriteLine(string.Format("places:{0}", string.Join(" ", places)));
        int[] cutoff = new int[] {
            11,
            16,
            37,
            41,
            47
        };
        Console.WriteLine(string.Format("cutoff:{0}", string.Join(" ", cutoff)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new StoryFromTCO().minimumChanges(places, cutoff);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] places = new int[] {
            4,
            1,
            3,
            3,
            2,
            4,
            5,
            5,
            4,
            4
        };
        Console.WriteLine(string.Format("places:{0}", string.Join(" ", places)));
        int[] cutoff = new int[] {
            3,
            3,
            5,
            2,
            4,
            4,
            5,
            4,
            3,
            5
        };
        Console.WriteLine(string.Format("cutoff:{0}", string.Join(" ", cutoff)));
        int __expected = 6;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new StoryFromTCO().minimumChanges(places, cutoff);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] places = new int[] {
            213,
            177,
            237,
            444,
            497,
            315,
            294,
            104,
            522,
            635,
            13,
            26,
            22,
            276,
            88,
            249,
            374,
            17,
            42,
            245,
            80,
            553,
            121,
            625,
            62,
            105,
            53,
            132,
            178,
            250,
            18,
            210,
            492,
            181,
            2,
            99,
            29,
            21,
            62,
            218,
            188,
            584,
            702,
            63,
            41,
            79,
            28,
            452,
            2
        };
        Console.WriteLine(string.Format("places:{0}", string.Join(" ", places)));
        int[] cutoff = new int[] {
            33,
            40,
            41,
            48,
            74,
            84,
            117,
            125,
            126,
            164,
            197,
            197,
            201,
            218,
            222,
            231,
            244,
            277,
            290,
            309,
            321,
            321,
            360,
            376,
            440,
            442,
            465,
            477,
            491,
            513,
            639,
            645,
            647,
            675,
            706,
            710,
            726,
            736,
            736,
            765,
            801,
            838,
            845,
            854,
            863,
            865,
            887,
            902,
            908
        };
        Console.WriteLine(string.Format("cutoff:{0}", string.Join(" ", cutoff)));
        int __expected = 23;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new StoryFromTCO().minimumChanges(places, cutoff);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
