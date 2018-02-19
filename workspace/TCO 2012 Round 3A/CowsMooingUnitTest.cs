using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
public partial class Tester
{
    public Tester()
    {
        OnInit();
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);        
    }
	public void ManualTestFromInput(string myinput)
	{
        var parser = new Parser(myinput);
        parser.Parse();
        int[] __result = new CowsMooing().getDistribution(parser.Items[0]);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
	}
    public void Challenge(string[] patterns)
    {
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ",patterns)));
        int[] __expected = new CowsMooing().getDistribution(patterns);
        
        int[] __result = new CowsMooing().Naive_Test(patterns);

            CollectionAssert.AreEquivalent(__expected, __result);
         }
    public void ManualTest(string[] patterns)
    {
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ",patterns)));
        int[] __result = new CowsMooing().getDistribution(patterns);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        string[] patterns = new string[] {
            "M"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int[] __expected = new int[] {
            0,
            3235
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CowsMooing().getDistribution(patterns);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        string[] patterns = new string[] {
            "M--M-",
            "-M-M-"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int[] __expected = new int[] {
            1294,
            1294,
            647
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CowsMooing().getDistribution(patterns);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        string[] patterns = new string[] {
            "M--",
            "-M--"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int[] __expected = new int[] {
            6621,
            514,
            6107
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CowsMooing().getDistribution(patterns);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        string[] patterns = new string[] {
            "MM-M---M-MM--",
            "-MM-MMM----M-M-",
            "MM-",
            "M--M-M--"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int[] __expected = new int[] {
            7907,
            7504,
            964,
            9034,
            7847
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CowsMooing().getDistribution(patterns);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        string[] patterns = new string[] {
            "-",
            "-M",
            "-MM",
            "-M--",
            "--M--",
            "M---MM",
            "MM-MM--",
            "M-M--M--",
            "M-M-MM-M-",
            "-MMMM-M-M-",
            "M-M-M-M-MMM",
            "--MMM--M--MM",
            "M--MM--MMM-M-",
            "M-MM----MM----",
            "MM----M-MMMM--M",
            "-MMMMM--M-M--M-M",
            "----M-M----MMMMMM",
            "MM-----M-MMM-MMMMM",
            "--M-MMMMMM-MMM-M--M",
            "M-M--M--M-MMM--MM---",
            "--MMMM--MM-MMM-M----M",
            "-MMM-M-MM-MMM-M-M-----",
            "-M-MMMM-MMMM--M--M--M--",
            "-M--MMM--MM---MMMM---MMM",
            "MMMM-MMMMM-M-MMMM-MM--M-M",
            "MMM-MMM-MM--M----M----MM-M",
            "MM---M-MMMMMMM----MM----MM-",
            "M----MMMMMMM-MM--MMM---M----",
            "-M-MMM-MMMM-MM--M-MMM---M----",
            "M--M-M-MM-MMM--M---MMMMMM-M-MM"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int[] __expected = new int[] {
            0,
            0,
            0,
            9523,
            1842,
            4448,
            752,
            9392,
            9394,
            7124,
            193,
            2222,
            1873,
            1875,
            5758,
            5429,
            1847,
            9481,
            7496,
            108,
            7880,
            4988,
            2656,
            4783,
            4261,
            9987,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CowsMooing().getDistribution(patterns);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example5()
    {
        string[] patterns = new string[] {
            "MMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
            "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM"
        };
        Console.WriteLine(string.Format("patterns:{0}", string.Join(" ", patterns)));
        int[] __expected = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            3235
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CowsMooing().getDistribution(patterns);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
