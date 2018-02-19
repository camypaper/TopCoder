using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class NamingConventionTest
{
    [TestMethod]
    public void Example0()
    {
        string variableName = "sum_of_two_numbers";
        Console.WriteLine("variableName:{0}",variableName);
        string __expected = "sumOfTwoNumbers";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new NamingConvention().toCamelCase(variableName);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example1()
    {
        string variableName = "variable";
        Console.WriteLine("variableName:{0}",variableName);
        string __expected = "variable";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new NamingConvention().toCamelCase(variableName);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example2()
    {
        string variableName = "t_o_p_c_o_d_e_r";
        Console.WriteLine("variableName:{0}",variableName);
        string __expected = "tOPCODER";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new NamingConvention().toCamelCase(variableName);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

    [TestMethod]
    public void Example3()
    {
        string variableName = "the_variable_name_can_be_very_long_like_this";
        Console.WriteLine("variableName:{0}",variableName);
        string __expected = "theVariableNameCanBeVeryLongLikeThis";
        Console.WriteLine("__expected:{0}",__expected);
        string __result = new NamingConvention().toCamelCase(variableName);
        Console.WriteLine("__result:{0}",__result);
        
        Assert.AreEqual(__expected, __result);
        }

}
