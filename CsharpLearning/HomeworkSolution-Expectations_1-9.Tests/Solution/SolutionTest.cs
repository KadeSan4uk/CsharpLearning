using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HomeworkSolution_Expectations_1_9.Tests.Solution;

public class SolutionTest
{
	#region Exercise 9

	[Fact]
	public void Check_Task_9_0()
	{
		// Arrange.
		var sourceArray = CreateSourceArray();


		// Act.
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.StringWithOut0_9(
				sourceArray.ToArray());


		// Assert.
		Assert.Equal(1, result.Count);

		foreach (var str in result)
		{
			Assert.Contains("op", str);
		}
	}

	[Fact]
	public void Check_Task_9_1()
	{
		// Arrange.
		List<string> sourceArray = CreateSourceArray();
		var searchString = "op";
		var expectedCount = sourceArray.Count(el => el.Contains(searchString));
		sourceArray.Add(searchString + "0");


		// Act.
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.StringWithOut0_9(
				sourceArray.ToArray());


		// Assert.
		Assert.Equal(expectedCount, result.Count);

		foreach (var str in result)
		{
			Assert.Contains(searchString, str);
		}
	}

	[Fact]
	public void Check_Task_9_2()
	{
		// Arrange.
		List<string> sourceArray = CreateSourceArray();
		var searchString = "pvp";
		var expectedCount = sourceArray.Count(el => el.Contains(searchString));
		sourceArray.Add("0000" + searchString + "0");


		// Act.
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.StringWithOut0_9(
				sourceArray.ToArray());


		// Assert.
		Assert.Equal(expectedCount, result.Count);

		foreach (var str in result)
		{
			Assert.Contains(searchString, str);
		}
	}

	private static List<string> CreateSourceArray()
	{
		return new List<string>
		{
			"abba",
			"oppa",
			"common",
			"zombie",
			"calambur",
			"pvp",
			"papasdd",
			"hhhjkljfg",
			"sdsd 912376 asd",
			"llll",
			"aaaa",
			"3123dsadvvv",
			"ddsadads",
			"qwertyuiop[",
			"asdfghjkl",
			"asjkhdzxmc,n",
		};
	}

	#endregion

	#region Exercise 8

	[Fact]
	public void Check_8_0()
	{
		// Arrange.
		int[] sourceArray = CreateIntegersArray(randomElementsCount: 10);

		var getExpectedResult = Exercise8ReferenceSolution(sourceArray);

		// Act.
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.OverFlowInArray8(sourceArray);

		// Assert.
		Assert.Equal(getExpectedResult, result);
	}

	private bool Exercise8ReferenceSolution(params int[] sourceArray)
	{
		try
		{
			int number = 0;

			foreach (var val in sourceArray)
			{
				checked
				{
					number += val;
				}
			}
		}
		catch (OverflowException e)
		{
			return true;
		}

		return false;
	}

	private int[] CreateIntegersArray(int randomElementsCount)
	{
		Random random = new Random();

		List<int> result = new List<int>();

		for (int i = 0; i < randomElementsCount; i++)
		{
			result.Add(random.Next(int.MinValue, int.MaxValue));
		}

		return result.ToArray();
	}

	#endregion

	#region Exercise 7

	[Fact]
	public void Check_7_0()
	{
		// Arrange
		var referenceString = "Sum(9,9)";
		var expectedResult = 18;

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.LightCalculator7(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}
	
	[Fact]
	public void Check_7_1()
	{
		// Arrange
		var referenceString = "Sum(9,9000000000)";
		var expectedResult = 18;

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.LightCalculator7(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}
	
	[Fact]
	public void Check_7_2()
	{
		// Arrange
		var referenceString = "Sum(9,0,900,1)";
		var expectedResult = 0;

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.LightCalculator7(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}
	
	[Fact]
	public void Check_7_3()
	{
		// Arrange
		var referenceString = "Sum()";
		var expectedResult = 0;

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.LightCalculator7(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}
	
	[Fact]
	public void Check_7_4()
	{
		// Arrange
		var referenceString = "Sub(9,9)";
		var expectedResult = 0;

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.LightCalculator7(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}
	
	[Fact]
	public void Check_7_5()
	{
		// Arrange
		var referenceString = "Div(9,9)";
		var expectedResult = 1;

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.LightCalculator7(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	[Fact]
	public void Check_7_6()
	{
		// Arrange
		var referenceString = "Div(9,0)";
		var expectedResult = 0;

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.LightCalculator7(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	[Fact]
	public void Check_7_7()
	{
		// Arrange
		var referenceString = "Mult(9,9)";
		var expectedResult = 9 * 9;

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.LightCalculator7(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}
	
	[Fact]
	public void Check_7_8()
	{
		// Arrange
		var referenceString = "Mult(9000000,9000000)";
		var val1 = 9000000;
		var expectedResult = 9000000 * val1;

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.LightCalculator7(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}
	
	[Fact]
	public void Check_7_9()
	{
		// Arrange
		var referenceString = "Mult(9000000,9000000)";
		var val1 = 9000000;
		var expectedResult = 9000000 * val1;

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.LightCalculator7(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	#endregion

	#region Exercise 6

	[Fact]
	public void Check_6_0()
	{
		// Arrange
		var referenceString = "0,1234567    8    9";
		var expectedResult = "0,1,2,3,4,5,6,7,8,9";

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.StringContainsNumbers6(
				referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	[Fact]
	public void Check_6_1()
	{
		// Arrange
		var referenceString = "123      ";
		var expectedResult = "1,2,3";

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.StringContainsNumbers6(
				referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	#endregion

	#region Exercise 5

	[Fact]
	public void Check_5_0()
	{
		// Arrange
		var source = "1234567890";
		var search = "45";
		var expectedResult = source.Contains(search);

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.StringContains5(source, search);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	#endregion

	#region Exercise 4

	[Fact]
	public void Check_4_0()
	{
		// Arrange
		var referenceString = "asdfghjkl";
		var expectedResult = "a";

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.VowelsCharacters4(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	[Fact]
	public void Check_4_1()
	{
		// Arrange
		var referenceString = "Alexander";
		var expectedResult = "Aeae";

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.VowelsCharacters4(referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	#endregion

	#region Exercise 3

	[Fact]
	public void Check_3_0()
	{
		// Arrange
		var referenceString = "0123";
		var expectedString = "122333";

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution
				.HowIndexSuchOutput3(referenceString);

		// Assert
		Assert.Equal(expectedString, result);
	}

	#endregion

	#region Exercise 2

	[Fact]
	public void Check_2_0()
	{
		// Arrange
		var refString = "1234567890";
		var expectedResult = new string(new string(refString.Reverse().ToArray())
			.Where((ch, index) => index % 2 != 0).ToArray());

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.EverySecondCharReverse2(refString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	[Fact]
	public void Check_2_1()
	{
		// Arrange
		var refString = "kljasdkjajkhdjkshdjkha  sah 19 12=312";
		var expectedResult = new string(new string(refString.Reverse().ToArray())
			.Where((ch, index) => index % 2 != 0).ToArray());

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.EverySecondCharReverse2(refString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	[Fact]
	public void Check_2_2()
	{
		// Arrange
		var refString = "1io3k1j h3 719n3 71289h 9128h 892h1h12hxj192z";
		var expectedResult = new string(new string(refString.Reverse().ToArray())
			.Where((ch, index) => index % 2 != 0).ToArray());

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.EverySecondCharReverse2(refString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	#endregion

	#region Exercise 1

	[Fact]
	public void Check_1_0()
	{
		// Arrange
		var referenceString = "1234567890";
		var expectedResult = "24680";

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.EverySecondCharOutput1(
				referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	[Fact]
	public void Check_1_1()
	{
		// Arrange
		var referenceString = "asdfghjkl;'";
		var expectedResult = "sfhk;";

		// Act
		var result =
			HomeworkSolution_Expectations_1_9.Solution.Solution.EverySecondCharOutput1(
				referenceString);

		// Assert
		Assert.Equal(expectedResult, result);
	}

	#endregion
}