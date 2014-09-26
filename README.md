TopCoder
========
These are my setting files for TopCoder.
# used plugins
+ [greed](https://github.com/shivawu/topcoder-greed)

# workspace
- TopCoder.csproj (Project file for the VS Express for Desktop)
- config.tmpl (template for the config file which contains path to the source code, problem description, and unittest.)
- greed.conf (setting for the greed.)
- on_generated.py (action after the file generated.)
- source_cs.tmpl (template for C# source code file.)
- unittest.tmpl (template for unittest source code file.)
- Scanner.cs (Helper class to read input.)
- Printer.cs (Helper class to write output.)

# How does it work?
On opening the problem in the Arena, greed creates 'Problem.cs', 'Description.html' and 'UnitTest.cs'.
If '${ProblemName}.cs' exists, 'on_generated.py' overwrites 'Problem.cs' by '${Problem.Name}.cs'.
When you build your program, Visual Studio copied  'Problem.cs', 'Description.html', and 'UnitTest.cs' to '${Problem.Name}.cs','${Problem.Name}.html', and '${Problem.Name}UnitTest.cs'.

# License
MIT License
