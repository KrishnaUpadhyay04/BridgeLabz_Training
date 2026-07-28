using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("String Practice Programs");
            Console.WriteLine("1. Count Vowels and Consonants");
            Console.WriteLine("2. Reverse a String");
            Console.WriteLine("3. Palindrome String Check");
            Console.WriteLine("4. Remove Duplicates from a String");
            Console.WriteLine("5. Find the Longest Word in a Sentence");
            Console.WriteLine("6. Find Substring Occurrences");
            Console.WriteLine("7. Toggle Case of Characters");
            Console.WriteLine("8. Compare Two Strings");
            Console.WriteLine("9. Find the Most Frequent Character");
            Console.WriteLine("10. Remove a Specific Character from a String");
            Console.WriteLine("11. Check if Two Strings are Anagrams");
            Console.WriteLine("12. Replace a Word in a Sentence");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Question1.Run(); break;
                case "2": Question2.Run(); break;
                case "3": Question3.Run(); break;
                case "4": Question4.Run(); break;
                case "5": Question5.Run(); break;
                case "6": Question6.Run(); break;
                case "7": Question7.Run(); break;
                case "8": Question8.Run(); break;
                case "9": Question9.Run(); break;
                case "10": Question10.Run(); break;
                case "11": Question11.Run(); break;
                case "12": Question12.Run(); break;
                case "0": return;
                default: Console.WriteLine("Invalid option"); break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    public static int CountVowels(string input)
    {
        int count = 0;
        foreach (char ch in input.ToLower())
        {
            if ("aeiou".Contains(ch)) count++;
        }
        return count;
    }

    public static int CountConsonants(string input)
    {
        int count = 0;
        foreach (char ch in input.ToLower())
        {
            if (char.IsLetter(ch) && !"aeiou".Contains(ch)) count++;
        }
        return count;
    }

    public static string ReverseString(string input)
    {
        char[] chars = input.ToCharArray();
        for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
        {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }
        return new string(chars);
    }

    public static bool IsPalindrome(string input)
    {
        string cleaned = new string(input.Where(ch => char.IsLetterOrDigit(ch)).ToArray()).ToLower();
        return cleaned == ReverseString(cleaned);
    }

    public static string RemoveDuplicates(string input)
    {
        string result = string.Empty;
        foreach (char ch in input)
        {
            if (!result.Contains(ch)) result += ch;
        }
        return result;
    }

    public static string FindLongestWord(string sentence)
    {
        string[] words = sentence.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        string longest = string.Empty;
        foreach (string word in words)
        {
            if (word.Length > longest.Length) longest = word;
        }
        return longest;
    }

    public static int CountSubstringOccurrences(string input, string substring)
    {
        if (string.IsNullOrEmpty(substring)) return 0;
        int count = 0;
        for (int i = 0; i <= input.Length - substring.Length; i++)
        {
            if (input.Substring(i, substring.Length) == substring) count++;
        }
        return count;
    }

    public static string ToggleCase(string input)
    {
        char[] chars = input.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i])) chars[i] = char.ToLower(chars[i]);
            else if (char.IsLower(chars[i])) chars[i] = char.ToUpper(chars[i]);
        }
        return new string(chars);
    }

    public static int CompareStrings(string first, string second)
    {
        int length = Math.Min(first.Length, second.Length);
        for (int i = 0; i < length; i++)
        {
            if (first[i] < second[i]) return -1;
            if (first[i] > second[i]) return 1;
        }
        if (first.Length < second.Length) return -1;
        if (first.Length > second.Length) return 1;
        return 0;
    }

    public static char FindMostFrequentCharacter(string input)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        foreach (char ch in input)
        {
            if (!frequency.ContainsKey(ch)) frequency[ch] = 0;
            frequency[ch]++;
        }

        char mostFrequent = '\0';
        int highestCount = 0;
        foreach (var pair in frequency)
        {
            if (pair.Value > highestCount)
            {
                highestCount = pair.Value;
                mostFrequent = pair.Key;
            }
        }
        return mostFrequent;
    }

    public static string RemoveCharacter(string input, char character)
    {
        string result = string.Empty;
        foreach (char ch in input)
        {
            if (ch != character) result += ch;
        }
        return result;
    }

    public static bool AreAnagrams(string first, string second)
    {
        if (first.Length != second.Length) return false;

        Dictionary<char, int> frequency = new Dictionary<char, int>();
        foreach (char ch in first)
        {
            if (!frequency.ContainsKey(ch)) frequency[ch] = 0;
            frequency[ch]++;
        }

        foreach (char ch in second)
        {
            if (!frequency.ContainsKey(ch)) return false;
            frequency[ch]--;
            if (frequency[ch] < 0) return false;
        }

        return frequency.Values.All(count => count == 0);
    }

    public static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        return sentence.Replace(oldWord, newWord);
    }
}
