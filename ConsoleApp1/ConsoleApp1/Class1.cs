using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class FileAnalyzer
{
    private List<int> numbers;

    public FileAnalyzer(string filePath)
    {
        numbers = new List<int>();
        LoadNumbers(filePath);
    }

    private void LoadNumbers(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            if (int.TryParse(line, out int number))
            {
                numbers.Add(number);
            }
        }
    }

    public int MaxNumber()
    {
        return numbers.Max();
    }

    public int MinNumber()
    {
        return numbers.Min();
    }

    public double Median()
    {
        var sortedNumbers = numbers.OrderBy(n => n).ToList();
        int count = sortedNumbers.Count;
        if (count % 2 == 0)
        {
            return (sortedNumbers[count / 2 - 1] + sortedNumbers[count / 2]) / 2.0;
        }
        else
        {
            return sortedNumbers[count / 2];
        }
    }

    public double Average()
    {
        return numbers.Average();
    }

    public List<int> LongestIncreasingSequence()
    {
        if (numbers.Count == 0) return new List<int>();

        List<int> longestSequence = new List<int>();
        List<int> currentSequence = new List<int> { numbers[0] };

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                currentSequence.Add(numbers[i]);
            }
            else
            {
                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence = new List<int>(currentSequence);
                }
                currentSequence.Clear();
                currentSequence.Add(numbers[i]);
            }
        }

        if (currentSequence.Count > longestSequence.Count)
        {
            longestSequence = currentSequence;
        }

        return longestSequence;
    }

    public List<int> LongestDecreasingSequence()
    {
        if (numbers.Count == 0) return new List<int>();

        List<int> longestSequence = new List<int>();
        List<int> currentSequence = new List<int> { numbers[0] };

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] < numbers[i - 1])
            {
                currentSequence.Add(numbers[i]);
            }
            else
            {
                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence = new List<int>(currentSequence);
                }
                currentSequence.Clear();
                currentSequence.Add(numbers[i]);
            }
        }

        if (currentSequence.Count > longestSequence.Count)
        {
            longestSequence = currentSequence;
        }

        return longestSequence;
    }
}