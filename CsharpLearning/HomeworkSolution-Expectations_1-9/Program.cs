// See https://aka.ms/new-console-template for more information

using HomeworkSolution_Expectations_1_9.Solution;

internal class Program
{
	public static void Main(string[] args)
	{
		var sourceArray = new string[]
		{
			"abba",
			"oppa",
			"common",
			"zombie",
			"calambur",
			"pvp",
			"0om"
		};

		var result = Solution.StringWithOut0_9(sourceArray);

		foreach (var res in result)
		{
			Console.WriteLine(res);
		}
	}
}