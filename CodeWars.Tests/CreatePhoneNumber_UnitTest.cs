﻿namespace CodeWars.Tests;

[TestFixture]
public partial class Tests
{
    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
    [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
    [TestCase(new int[] { 5, 5, 5, 6, 7, 8, 9 }, ExpectedResult = "Phone number must be 10 digits.")]
    public static string CreatePhoneNumber_Test(int[] numbers)
    {
        return Kata.CreatePhoneNumber(numbers);
    }
}