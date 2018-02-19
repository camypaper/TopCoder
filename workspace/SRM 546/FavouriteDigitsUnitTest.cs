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
    public void ManualTest(long N, int digit1, int count1, int digit2, int count2)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("digit1:{0}", digit1);
        Console.WriteLine("count1:{0}", count1);
        Console.WriteLine("digit2:{0}", digit2);
        Console.WriteLine("count2:{0}", count2);
        long __result = new FavouriteDigits().findNext(N, digit1, count1, digit2, count2);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        long N = 47L;
        Console.WriteLine("N:{0}", N);
        int digit1 = 1;
        Console.WriteLine("digit1:{0}", digit1);
        int count1 = 0;
        Console.WriteLine("count1:{0}", count1);
        int digit2 = 2;
        Console.WriteLine("digit2:{0}", digit2);
        int count2 = 0;
        Console.WriteLine("count2:{0}", count2);
        long __expected = 47L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FavouriteDigits().findNext(N, digit1, count1, digit2, count2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        long N = 47L;
        Console.WriteLine("N:{0}", N);
        int digit1 = 5;
        Console.WriteLine("digit1:{0}", digit1);
        int count1 = 0;
        Console.WriteLine("count1:{0}", count1);
        int digit2 = 9;
        Console.WriteLine("digit2:{0}", digit2);
        int count2 = 1;
        Console.WriteLine("count2:{0}", count2);
        long __expected = 49L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FavouriteDigits().findNext(N, digit1, count1, digit2, count2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        long N = 47L;
        Console.WriteLine("N:{0}", N);
        int digit1 = 5;
        Console.WriteLine("digit1:{0}", digit1);
        int count1 = 0;
        Console.WriteLine("count1:{0}", count1);
        int digit2 = 3;
        Console.WriteLine("digit2:{0}", digit2);
        int count2 = 1;
        Console.WriteLine("count2:{0}", count2);
        long __expected = 53L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FavouriteDigits().findNext(N, digit1, count1, digit2, count2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        long N = 47L;
        Console.WriteLine("N:{0}", N);
        int digit1 = 2;
        Console.WriteLine("digit1:{0}", digit1);
        int count1 = 1;
        Console.WriteLine("count1:{0}", count1);
        int digit2 = 0;
        Console.WriteLine("digit2:{0}", digit2);
        int count2 = 2;
        Console.WriteLine("count2:{0}", count2);
        long __expected = 200L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FavouriteDigits().findNext(N, digit1, count1, digit2, count2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        long N = 123456789012345L;
        Console.WriteLine("N:{0}", N);
        int digit1 = 1;
        Console.WriteLine("digit1:{0}", digit1);
        int count1 = 2;
        Console.WriteLine("count1:{0}", count1);
        int digit2 = 2;
        Console.WriteLine("digit2:{0}", digit2);
        int count2 = 4;
        Console.WriteLine("count2:{0}", count2);
        long __expected = 123456789012422L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FavouriteDigits().findNext(N, digit1, count1, digit2, count2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        long N = 92L;
        Console.WriteLine("N:{0}", N);
        int digit1 = 1;
        Console.WriteLine("digit1:{0}", digit1);
        int count1 = 1;
        Console.WriteLine("count1:{0}", count1);
        int digit2 = 0;
        Console.WriteLine("digit2:{0}", digit2);
        int count2 = 0;
        Console.WriteLine("count2:{0}", count2);
        long __expected = 100L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new FavouriteDigits().findNext(N, digit1, count1, digit2, count2);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
