// www.codewars.com/r/5CvyhA
using static System.Console;

using CodeWars;




//for (long i = 0; i <= 20; i++)
//    Console.WriteLine($"!{i}: {Kata.Factorial(i)}");

//CreatePhoneNumber(int[10])
ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nFormat an American phone number");
ForegroundColor = ConsoleColor.Gray;
WriteLine("8675309: {0}", Kata.CreatePhoneNumber(new int[] { 8, 6, 7, 5, 3, 0, 9 }));
WriteLine("2128675309: {0}", Kata.CreatePhoneNumber(new int[] { 2, 1, 2, 8, 6, 7, 5, 3, 0, 9 }));
WriteLine("12128675309: {0}", Kata.CreatePhoneNumber(new int[] { 1, 2, 1, 2, 8, 6, 7, 5, 3, 0, 9 }));

//MultiplesOf3Or5
ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nSum the multiples of 3 or 5 for n");
ForegroundColor = ConsoleColor.Gray;
WriteLine($"10: {Kata.Solution(10)}");
WriteLine($"-10: {Kata.Solution(0)}");
WriteLine($"0: {Kata.Solution(0)}");

//Maskify
ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nMask all but last four characters with #");
ForegroundColor = ConsoleColor.Gray;
WriteLine($"4556364607935616: {Kata.Maskify("4556364607935616")}");
WriteLine($"ABC: {Kata.Maskify("4556364607935616")}");
WriteLine($"\"\": {Kata.Maskify("")}");
WriteLine($"String.Empty: {Kata.Maskify(String.Empty)}");

//Gears
ForegroundColor= ConsoleColor.Yellow;
WriteLine("\nCalculates gear ratios using number of teeth (negative indicates CCW)");
ForegroundColor = ConsoleColor.Gray;
WriteLine($"Final cog speed for 100, 75: {Kata.Cogs.CogRpm(new int[] { 100, 75 })} RPM");
WriteLine($"Final cog speed  for 100, 75, 50: {Kata.Cogs.CogRpm(new int[] { 100, 75, 50 })} RPM");
WriteLine($"Final cog speed for 100, 75, 50, 75: {Kata.Cogs.CogRpm(new int[] { 100, 75, 50, 75 })} RPM");
WriteLine($"Final cog speed for 100, 75, 50, 75, 100: {Kata.Cogs.CogRpm(new int[] { 100, 75, 50, 75, 100 })} RPM");

// 4 Kyuuu: NextBiggerNumber
ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nNextBiggerNumber(459853) -> Expected: 483559");
ForegroundColor = ConsoleColor.Gray;
Write($"   Result: {Kata.NextBiggerNumber(459853)}");

ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nNextBiggerNumber(8888888888888888888) -> Expected: -1");
ForegroundColor = ConsoleColor.Gray; 
Write($"   Result: {Kata.NextBiggerNumber(8888888888888888888)}");


ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nNextBiggerNumber(1999999999999999999) -> Expected: 9199999999999999999");
ForegroundColor = ConsoleColor.Gray;
WriteLine($"   Result: {Kata.NextBiggerNumber(1999999999999999999)}");