using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);    }
    public void ManualTest(int sortedness, int[] seq)
    {
        Console.WriteLine("sortedness:{0}", sortedness);
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ",seq)));
        int __result = new SortishDiv2().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int sortedness = 5;
        Console.WriteLine("sortedness:{0}", sortedness);
        int[] seq = new int[] {
            4,
            0,
            0,
            2,
            0
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SortishDiv2().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int sortedness = 4;
        Console.WriteLine("sortedness:{0}", sortedness);
        int[] seq = new int[] {
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SortishDiv2().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int sortedness = 2;
        Console.WriteLine("sortedness:{0}", sortedness);
        int[] seq = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SortishDiv2().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int sortedness = 2;
        Console.WriteLine("sortedness:{0}", sortedness);
        int[] seq = new int[] {
            1,
            2,
            0,
            5,
            0,
            0
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SortishDiv2().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
