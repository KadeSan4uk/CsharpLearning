namespace HomeworkSolution_Expectations_1_9.Solution;

public static class Solution
{
	// Not competed
	public static bool OverFlowInArray8(params int[] sourceArray)
	{
		int sum = 0;

		try
		{
			foreach (int val in sourceArray)
			{
				checked
				{
					sum += val;
				}
			}
		}
		catch (OverflowException e)
		{
			return true;
		}

		return false;
	}

	public static int LightCalculator7(string input)
	{
//		Console.WriteLine("Enter the 2 numbers in the format:+" +
//						  " \n\tSum(9,9) or Sub(9,9) or Mult(9,9) or Div(9,9)\nWhat means:" +
//						  "  +\t         -            *           /");
		
		string numbers = "1234567890-";
		string letters = "SsUuMmBbLlTtDdIiVvGgOo";
		string notation = "";
		string firstValue = "";
		string lastValue = "";

		for (int i = 0; i < (input.Length); i++)
		{
			if (letters.Contains(input[i]))
			{
				notation += input[i];
			}

			if (input[i] == ',')
			{
				break;
			}

			if (numbers.Contains(input[i]))
			{
				firstValue += input[i];
			}
		}

		for (int i = 0; i < (input.Length); i++)
		{
			if (input[i] == ',')
			{
				lastValue = "";
			}

			if (numbers.Contains(input[i]))
			{
				lastValue += input[i];
			}
		}

		notation = notation.ToLower();
		int result = 0;

		int firstInt = int.Parse(firstValue);
		int lastInt = int.Parse(lastValue);

		if (notation == "sum")
		{
			result = firstInt + lastInt;
			Console.WriteLine($"{result}");
			if (firstInt > 0 && lastInt > 0 && result < 0 ||
				firstInt < 0 && lastInt < 0 && result > 0)
			{
				Console.WriteLine("Exception overflow!");
			}
		}
		else if (notation == "sub")
		{
			result = (lastInt - firstInt);
			if (result == 0)
			{
				Console.WriteLine($"{result}");
			}

			if (firstInt > 0 && lastInt < 0 && result > 0 ||
				firstInt < 0 && lastInt > 0 && result > 0)
			{
				Console.WriteLine("Exception overflow!");
			}
		}
		else if (notation == "mult")
		{
			result = firstInt * lastInt;
		}
		else if (notation == "div")
		{
			result = (firstInt / lastInt);
		}
		else
		{
			Console.WriteLine("Incorrect input format, try again.");
		}

		return result;
	}

	public static string StringContainsNumbers6(string input)
	{
		string numbers = "1234567890";
		string result = "";

		for (int i = 0; i <= input.Length - 1; i++)
		{
			if (numbers.Contains(input[i]))
			{
				result += input[i] + ",";
				if (i == input.Length - 1)
				{
					result = result.Remove(i);
				}
			}
		}

		return result;
	}

	public static bool StringContains5(string source, string search) => 
		source.Contains(search);

	public static string VowelsCharacters4(string input)
	{
		string vowels = "aeiou";
		string result = "";
		foreach (char i in input.ToLower())
		{
			if (vowels.Contains(i))
			{
				result += i;
			}
		}

		return result;
	}

	public static string HowIndexSuchOutput3(string input)
	{
		string result = "";
		for (int i = 0; i < input.Length; i++)
		{
			char currentChar = input[i];
			int repeatCount = i;

			for (int j = 0; j < repeatCount; j++)
			{
				result += currentChar;
			}
		}

		return result;
	}

	public static string EverySecondCharReverse2(string input)
	{
		Console.WriteLine("Enter the word");
		
		int count = 1;
		string result = string.Empty;
		for (int i = input.Length - 1; i >= 0; i--)
		{
			count++;
			if (count % 2 == 0)
			{
				continue;
			}

			result += input[i];
		}

		return result;
	}

	public static string EverySecondCharOutput1(string input)
	{
		string result = string.Empty;
		int count = 1;
		for (int i = 0; i < input.Length; i++)
		{
			count++;
			if (count % 2 == 0)
			{
				continue;
			}

			result += input[i];
		}

		return result;
	}

	// Not completed
	public static List<string> StringWithOut0_9(params string[] inputArray)
	{
		List<string> myArray = new List<string>();
		string input;
		string сontainStr = "";
		int index = 0;

		while (index <= inputArray.Length - 1)
		{
			input = inputArray[index];
			myArray.Add(input);

			if (input.Contains('0'))
			{
				сontainStr = input.Replace("0", "");

				break;
			}

			index++;
		}

		List<string> resultList = new();

		foreach (string str in myArray)
		{
			if (str.IndexOf(сontainStr, StringComparison.OrdinalIgnoreCase) !=
				-1) // Почему не Contains? IndexOf по смыслу чуток не то делает.
			{
				resultList.Add(str);
			}
		}

		return resultList;
	}
}