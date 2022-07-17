using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> occurencesByNumber = new SortedDictionary<int, int>();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var number in numbers)
            {
                if (occurencesByNumber.ContainsKey(number))
                {
                    int currentOccurances = occurencesByNumber[number];
                    currentOccurances += 1;
                    occurencesByNumber[number] = currentOccurances;
                }
                else
                {
                    occurencesByNumber.Add(number, 1);
                }
            }
            foreach (var occurance in occurencesByNumber)
            {
                Console.WriteLine($"{occurance.Key} -> {occurance.Value}");
            }
        }
    }
}
