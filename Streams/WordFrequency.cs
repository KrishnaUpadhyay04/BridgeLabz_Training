using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class WordFrequency
{
    public void Execute()
    {
        string file = "words.txt";

        try
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            Dictionary<string, int> wordCount =
                new Dictionary<string, int>();

            using StreamReader reader =
                new StreamReader(file);

            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] words = Regex.Split(
                    line.ToLower(),
                    @"\W+"
                );

                foreach (string word in words)
                {
                    if (string.IsNullOrWhiteSpace(word))
                        continue;

                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word]++;
                    }
                    else
                    {
                        wordCount[word] = 1;
                    }
                }
            }

            Console.WriteLine("\nTop 5 Most Frequent Words:");

            var topFive = wordCount
                .OrderByDescending(x => x.Value)
                .Take(5);

            foreach (var item in topFive)
            {
                Console.WriteLine(
                    $"{item.Key} : {item.Value}"
                );
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}