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
        int __result = new Robofactory().reveal(parser.Items[0], parser.Items[1]);
        Console.WriteLine("__result:{0}", __result);
	}
    public void Challenge(int[] query, string[] answer)
    {
        Console.WriteLine(string.Format("query:{0}", string.Join(" ",query)));
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ",answer)));
        int __expected = new Robofactory().reveal(query, answer);
        
        int __result = new Robofactory().Naive_Test(query, answer);

        Assert.AreEqual(__expected, __result);
        }
    public void ManualTest(int[] query, string[] answer)
    {
        Console.WriteLine(string.Format("query:{0}", string.Join(" ",query)));
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ",answer)));
        int __result = new Robofactory().reveal(query, answer);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] query = new int[] {
            3,
            2,
            2
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        string[] answer = new string[] {
            "Odd",
            "Odd",
            "Even"
        };
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ", answer)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Robofactory().reveal(query, answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] query = new int[] {
            1,
            3,
            5,
            10
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        string[] answer = new string[] {
            "Odd",
            "Odd",
            "Odd",
            "Even"
        };
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ", answer)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Robofactory().reveal(query, answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] query = new int[] {
            2,
            3,
            5,
            10
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        string[] answer = new string[] {
            "Even",
            "Odd",
            "Odd",
            "Even"
        };
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ", answer)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Robofactory().reveal(query, answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] query = new int[] {
            2,
            4,
            6,
            10
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        string[] answer = new string[] {
            "Even",
            "Even",
            "Even",
            "Even"
        };
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ", answer)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Robofactory().reveal(query, answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] query = new int[] {
            107
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        string[] answer = new string[] {
            "Odd"
        };
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ", answer)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Robofactory().reveal(query, answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] query = new int[] {
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        string[] answer = new string[] {
            "Odd",
            "Odd",
            "Even"
        };
        Console.WriteLine(string.Format("answer:{0}", string.Join(" ", answer)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new Robofactory().reveal(query, answer);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
