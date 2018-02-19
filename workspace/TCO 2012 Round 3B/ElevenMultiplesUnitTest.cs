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
    public void ManualTest(string[] pieces)
    {
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ",pieces)));
        int __result = new ElevenMultiples().countMultiples(pieces);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] pieces = new string[] {
            "58",
            "2012",
            "123"
        };
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ", pieces)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ElevenMultiples().countMultiples(pieces);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] pieces = new string[] {
            "1",
            "1111",
            "1",
            "11"
        };
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ", pieces)));
        int __expected = 24;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ElevenMultiples().countMultiples(pieces);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] pieces = new string[] {
            "43925486943738659795389387498953274"
        };
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ", pieces)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ElevenMultiples().countMultiples(pieces);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] pieces = new string[] {
            "983",
            "4654",
            "98",
            "3269",
            "861",
            "30981"
        };
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ", pieces)));
        int __expected = 96;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ElevenMultiples().countMultiples(pieces);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] pieces = new string[] {
            "193",
            "8819",
            "40676",
            "97625892",
            "5719",
            "45515667",
            "32598836",
            "70559374",
            "38756",
            "724",
            "93391",
            "942068",
            "506",
            "901150",
            "874",
            "895567",
            "7560480",
            "7427691",
            "799450",
            "85127"
        };
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ", pieces)));
        int __expected = 537147821;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ElevenMultiples().countMultiples(pieces);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string[] pieces = new string[] {
            "687045939630",
            "997856158148599044",
            "2014910234712225061",
            "9658113323175370226",
            "1584118137",
            "67925153345598920",
            "6960366756",
            "863413844386808834",
            "799302243562410012",
            "44481835751",
            "8004606814733183",
            "19623906615609",
            "23859998326058162",
            "461385591582",
            "9261878982390119",
            "1569373294276",
            "318106951168934",
            "65389049931",
            "12791173342",
            "507877942026",
            "3947173045690",
            "472425746178910",
            "524552931853595",
            "40771812249667850232",
            "563988469071932",
            "28147819070",
            "797007158858587",
            "5716177008624223",
            "387565700495309324",
            "4716621063133318"
        };
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ", pieces)));
        int __expected = 814880650;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new ElevenMultiples().countMultiples(pieces);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
