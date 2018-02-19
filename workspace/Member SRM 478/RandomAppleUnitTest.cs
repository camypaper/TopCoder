using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);    }
    public void ManualTest(string[] hundred, string[] ten, string[] one)
    {
        Console.WriteLine(string.Format("hundred:{0}", string.Join(" ",hundred)));
        Console.WriteLine(string.Format("ten:{0}", string.Join(" ",ten)));
        Console.WriteLine(string.Format("one:{0}", string.Join(" ",one)));
        double[] __result = new RandomApple().theProbability(hundred, ten, one);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        string[] hundred = new string[] {
            "00"
        };
        Console.WriteLine(string.Format("hundred:{0}", string.Join(" ", hundred)));
        string[] ten = new string[] {
            "00"
        };
        Console.WriteLine(string.Format("ten:{0}", string.Join(" ", ten)));
        string[] one = new string[] {
            "58"
        };
        Console.WriteLine(string.Format("one:{0}", string.Join(" ", one)));
        double[] __expected = new double[] {
            0.38461538461538464,
            0.6153846153846154
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        double[] __result = new RandomApple().theProbability(hundred, ten, one);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
        Assert.AreEqual(__expected, __result );
}

    [TestMethod]
    public void Example1()
    {
        string[] hundred = new string[] {
            "00",
            "00"
        };
        Console.WriteLine(string.Format("hundred:{0}", string.Join(" ", hundred)));
        string[] ten = new string[] {
            "00",
            "00"
        };
        Console.WriteLine(string.Format("ten:{0}", string.Join(" ", ten)));
        string[] one = new string[] {
            "21",
            "11"
        };
        Console.WriteLine(string.Format("one:{0}", string.Join(" ", one)));
        double[] __expected = new double[] {
            0.5888888888888889,
            0.4111111111111111
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        double[] __result = new RandomApple().theProbability(hundred, ten, one);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
        Assert.AreEqual(__expected, __result );
}

    [TestMethod]
    public void Example2()
    {
        string[] hundred = new string[] {
            "0000",
            "0000",
            "0000"
        };
        Console.WriteLine(string.Format("hundred:{0}", string.Join(" ", hundred)));
        string[] ten = new string[] {
            "2284",
            "0966",
            "9334"
        };
        Console.WriteLine(string.Format("ten:{0}", string.Join(" ", ten)));
        string[] one = new string[] {
            "1090",
            "3942",
            "4336"
        };
        Console.WriteLine(string.Format("one:{0}", string.Join(" ", one)));
        double[] __expected = new double[] {
            0.19685958571981937,
            0.24397246802233483,
            0.31496640865458775,
            0.24420153760325805
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        double[] __result = new RandomApple().theProbability(hundred, ten, one);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
        Assert.AreEqual(__expected, __result );
}

    [TestMethod]
    public void Example3()
    {
        string[] hundred = new string[] {
            "01010110",
            "00011000",
            "00001000",
            "10001010",
            "10111110"
        };
        Console.WriteLine(string.Format("hundred:{0}", string.Join(" ", hundred)));
        string[] ten = new string[] {
            "22218214",
            "32244284",
            "68402430",
            "18140323",
            "29043145"
        };
        Console.WriteLine(string.Format("ten:{0}", string.Join(" ", ten)));
        string[] one = new string[] {
            "87688689",
            "36101317",
            "69474068",
            "29337374",
            "87255881"
        };
        Console.WriteLine(string.Format("one:{0}", string.Join(" ", one)));
        double[] __expected = new double[] {
            0.11930766223754977,
            0.14033271060661345,
            0.0652282589028571,
            0.14448118133046356,
            0.1981894622733832,
            0.10743462836879789,
            0.16411823601857622,
            0.06090786026175882
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        double[] __result = new RandomApple().theProbability(hundred, ten, one);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
        Assert.AreEqual(__expected, __result );
}

    [TestMethod]
    public void Example4()
    {
        string[] hundred = new string[] {
            "10"
        };
        Console.WriteLine(string.Format("hundred:{0}", string.Join(" ", hundred)));
        string[] ten = new string[] {
            "00"
        };
        Console.WriteLine(string.Format("ten:{0}", string.Join(" ", ten)));
        string[] one = new string[] {
            "00"
        };
        Console.WriteLine(string.Format("one:{0}", string.Join(" ", one)));
        double[] __expected = new double[] {
            1.0,
            0.0
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        double[] __result = new RandomApple().theProbability(hundred, ten, one);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
        Assert.AreEqual(__expected, __result );
}

}
