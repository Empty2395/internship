using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ACER\Desktop\стажировка\фалй\10m.txt";

            FileAnalyzer analyzer = new FileAnalyzer(filePath);

            Console.WriteLine("1.Максимальне число в файлi: " + analyzer.MaxNumber());
            Console.WriteLine("2.Мiнiмальне число в файлi: " + analyzer.MinNumber());
            Console.WriteLine("3.Медiану: " + analyzer.Median());
            Console.WriteLine("4.Середнє арифметичне значення: " + analyzer.Average());

            var longestIncreasingSequence = analyzer.LongestIncreasingSequence();
            Console.WriteLine("5.Найбiльша послiдовнiсть чисел, яка збiльшується: " + string.Join(", ", longestIncreasingSequence));

            var longestDecreasingSequence = analyzer.LongestDecreasingSequence();
            Console.WriteLine("6.Найбiльша послiдовнiсть чисел, яка зменшується: " + string.Join(", ", longestDecreasingSequence));
            Console.ReadLine();
        }
    }
}
