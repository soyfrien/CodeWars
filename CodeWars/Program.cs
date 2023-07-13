// See https://aka.ms/new-console-template for more information
using CodeWars;
using static System.Console;

//CreatePhoneNumber(int[10])
Console.ForegroundColor = ConsoleColor.Yellow;
WriteLine("Format an American phone number");
Console.ForegroundColor = ConsoleColor.Gray;
WriteLine("8675309: {0}", Kata.CreatePhoneNumber(new int[] { 8, 6, 7, 5, 3, 0, 9 }));
WriteLine("2128675309: {0}", Kata.CreatePhoneNumber(new int[] { 2, 1, 2, 8, 6, 7, 5, 3, 0, 9 }));
WriteLine("12128675309: {0}", Kata.CreatePhoneNumber(new int[] { 1, 2, 1, 2, 8, 6, 7, 5, 3, 0, 9 }));

//MultiplesOf3Or5
Console.ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nSum the multiples of 3 or 5 for n");
Console.ForegroundColor = ConsoleColor.Gray;
WriteLine($"10: {Kata.Solution(10)}");
WriteLine($"-10: {Kata.Solution(0)}");
WriteLine($"0: {Kata.Solution(0)}");

//Maskify
Console.ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nMask all but last four characters with #");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine($"4556364607935616: {Kata.Maskify("4556364607935616")}");
Console.WriteLine($"ABC: {Kata.Maskify("4556364607935616")}");
Console.WriteLine($"\"\": {Kata.Maskify("")}");
Console.WriteLine($"String.Empty: {Kata.Maskify(String.Empty)}");

//Gears
Console.ForegroundColor= ConsoleColor.Yellow;
Console.WriteLine("\nCalculates gear ratios using number of teeth (negative indicates CCW)");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine($"Final cog speed for 100, 75: {Kata.Cogs.CogRpm(new int[] { 100, 75 })} RPM");
Console.WriteLine($"Final cog speed  for 100, 75, 50: {Kata.Cogs.CogRpm(new int[] { 100, 75, 50 })} RPM");
Console.WriteLine($"Final cog speed for 100, 75, 50, 75: {Kata.Cogs.CogRpm(new int[] { 100, 75, 50, 75 })} RPM");
Console.WriteLine($"Final cog speed for 100, 75, 50, 75, 100: {Kata.Cogs.CogRpm(new int[] { 100, 75, 50, 75, 100 })} RPM");