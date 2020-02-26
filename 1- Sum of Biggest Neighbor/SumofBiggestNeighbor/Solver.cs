using System;
using System.Collections.Generic;
using System.Linq;

namespace SumofBiggestNeighbor
{
    public class Solver : ISolver
    {
        /// <summary>
        /// Gets an array of integer and calculates the sum of biggest neighbors
        /// </summary>
        /// <param name="input">The array of values</param>
        /// <returns>Sum of biggest neighbors</returns>
        public int Challenge(int[] input)
        {
            if (input.Length < 2)
                throw new ArgumentException("Input should at least have 2 elements.", nameof(input));

            var frequencies = CreateFrequencyDictionary(input);
            var m = frequencies.Max(d => d.Value);
            var filteredList = FilterInfrequentItems(input, frequencies, m);
            var sum = SumofMaxNeighbors(filteredList);
            return sum;
        }

        private int SumofMaxNeighbors(List<int> filteredList)
        {
            var max = int.MinValue;
            for (int i = 0; i < filteredList.Count-1; i++)
            {
                var sum = filteredList[i] + filteredList[i + 1];
                if (sum > max)
                    max = sum;
            }
            return max;
        }

        private List<int> FilterInfrequentItems(int[] input, Dictionary<int, int> frequencies, int m)
        {
            var filteredList = new List<int>();
            foreach (var item in input)
            {
                if (frequencies[item] >= m - 1)
                    filteredList.Add(item);
            }
            return filteredList;
        }

        private Dictionary<int, int> CreateFrequencyDictionary(int[] input)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in input)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict.Add(item, 1);
            }
            return dict;
        }
    }
}
