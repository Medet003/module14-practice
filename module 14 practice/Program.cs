using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWorkModule14
{
    class Program
    {
        static void Main()
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            Dictionary<string, int> wordFrequency = CountWordFrequency(text);

            DisplayStatistics(wordFrequency);
        }

        static Dictionary<string, int> CountWordFrequency(string text)
        {
            string[] words = text.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordFrequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }

            return wordFrequency;
        }

        static void DisplayStatistics(Dictionary<string, int> wordFrequency)
        {
            Console.WriteLine("Статистика по тексту:");
            Console.WriteLine("---------------------");
            Console.WriteLine("| Слово         | Частота  |");
            Console.WriteLine("---------------------");

            foreach (var kvp in wordFrequency.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"| {kvp.Key,-13} | {kvp.Value,-9} |");
            }

            Console.WriteLine("---------------------");
        }
    }

}
