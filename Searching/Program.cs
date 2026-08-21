using System.Text;
using Searching;

string[] words = ["Bridge", "Labz", " ", "Searching"];
Console.WriteLine($"Reversed: {ReverseTheString.Reverse("hello")}");
Console.WriteLine($"Without duplicates: {RemoveDuplicates.RemoveDuplicate("programming")}");
Console.WriteLine($"Concatenated: {Concatenate.ConcatenateStrings(words)}");

List<string> performanceWords = Enumerable.Repeat("search ", 10_000).ToList();
(long builderTime, long stringTime) = Performance.Compare(performanceWords);
Console.WriteLine($"StringBuilder: {builderTime} ms, string: {stringTime} ms");

int[] numbers = [4, 7, -2, 9, -5];
Console.WriteLine($"First negative index: {LinearSearch.FirstNegativeNumber(numbers)}");
string[] sentences = ["C# is fast", "Binary search is efficient", "StringBuilder is useful"];
Console.WriteLine($"Sentence containing 'binary': {LinearSearch.FindSentenceContainingWord(sentences, "binary")}");

int[] rotated = [6, 7, 8, 1, 2, 3, 4];
int minimumIndex = Binary.FindMinimumIndexInRotatedSorted(rotated);
Console.WriteLine($"Rotation point: {minimumIndex} (value {rotated[minimumIndex]})");
int[] peakNumbers = [1, 3, 7, 6, 4, 2];
int peakIndex = Binary.FindPeakIndex(peakNumbers);
Console.WriteLine($"Peak: index {peakIndex} (value {peakNumbers[peakIndex]})");
int[][] matrix = [[1, 4, 7], [10, 13, 16], [20, 23, 30]];
(int row, int column) = Binary.SearchIn2DMatrix(matrix, 13);
Console.WriteLine($"Matrix target: ({row}, {column})");
(int first, int last) = Binary.FindFirstAndLastOccurrence([1, 2, 2, 2, 4, 5], 2);
Console.WriteLine($"First and last occurrence: {first}, {last}");

int[] challengeNumbers = [3, 4, -1, 1];
Console.WriteLine($"First missing positive: {SearchChallenge.FirstMissingPositive(challengeNumbers)}");
Console.WriteLine($"Target index: {SearchChallenge.FindTargetIndex([1, 3, 5, 7, 9], 7)}");

string sampleFile = Path.Combine(Path.GetTempPath(), "searching-exercises.txt");
try
{
	File.WriteAllText(sampleFile, "Binary search\nStreamReader makes reading efficient.\n", Encoding.UTF8);
	Console.WriteLine($"File lines: {StreamReaderExercises.ReadLines(sampleFile).Count}");
	Console.WriteLine($"Word occurrences: {StreamReaderExercises.CountWord(sampleFile, "search")}");
	Console.WriteLine($"As characters: {StreamReaderExercises.ReadBytesAsCharacters(sampleFile).Trim()}");

	using MemoryStream inputBytes = new(Encoding.UTF8.GetBytes("User input"));
	using StreamReader input = new(inputBytes, Encoding.UTF8);
	string outputFile = Path.Combine(Path.GetTempPath(), "searching-input.txt");
	StreamReaderExercises.WriteInputToFile(input, outputFile);
	Console.WriteLine($"Input written: {File.ReadAllText(outputFile).Trim()}");
	File.Delete(outputFile);
}
finally
{
	File.Delete(sampleFile);
}
