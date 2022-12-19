using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Problem16
    {
        int TIME;
        public int MaxFlow(IList<string> input)
        {
            TIME = 30;
            var valves = ParseInput(input);
            InitializeLength(valves);
            var nonZeroes = GetNonZeroes(valves);

            Dictionary<long, int> cache = new Dictionary<long, int>();

            MaxFlowCacheBackTrack("AA",0, 0, 0, nonZeroes, valves, cache);

            int max = 0;

            foreach(var val in cache)
            {
                max = Math.Max(max, val.Value);
            }

            return max;
        }

        public int MaxFlowElephant(IList<string> input)
        {
            TIME = 26;
            var valves = ParseInput(input);
            InitializeLength(valves);
            var nonZeroes = GetNonZeroes(valves);

            Dictionary<long, int> cache = new Dictionary<long, int>();
            MaxFlowCacheBackTrack("AA", 0, 0, 0, nonZeroes, valves, cache);

            int max = 0;
            foreach(var human in cache)
            {
                foreach(var elephant in cache)
                {
                    if ((human.Key&elephant.Key)==0)
                    {
                        max = Math.Max(max, human.Value+elephant.Value);
                    }
                }
            }

            return max;
        }
        private void MaxFlowCacheBackTrack(string valve, long state, int val, int minute, List<string> nonZeroes, Dictionary<string, Valve> valves, Dictionary<long,int> cache)
        {
            cache[state] = Math.Max(cache.GetValueOrDefault(state, 0), val); 

            foreach(var destination in nonZeroes)
            {
                int newMinute = valves[valve].Lengths[destination] + minute + 1;
                if ((valves[destination].Mask&state) != 0 || newMinute > TIME)
                {
                    continue;
                }
                MaxFlowCacheBackTrack(destination, 
                    state | valves[destination].Mask,
                    val + ((TIME - newMinute) * valves[destination].Value),
                    newMinute,
                    nonZeroes,
                    valves,
                    cache);
            }
        }

        // Deprecated
        private int MaxFlowBackTrack(string valve, int val, int minute, List<string> nonZeroes, Dictionary<string, Valve> valves, HashSet<string> opened)
        {
            if (minute > TIME)
            {
                return val;
            }

            int max = val;
            foreach(var destination in nonZeroes)
            {
                var length = valves[valve].Lengths[destination];
                if ((!opened.Contains(destination)) && minute+length+1 <= TIME)
                {
                    opened.Add(destination);
                    max = Math.Max(max, MaxFlowBackTrack(destination, val + ((TIME - (minute + length + 1)) * valves[destination].Value), minute + length + 1, nonZeroes, valves, opened));
                    opened.Remove(destination);
                }
            }

            return max;
        }

        private List<string> GetNonZeroes(Dictionary<string, Valve> valves)
        {
            List<string> nonZeroes = new List<string>();

            foreach(var valve in valves.Values)
            {
                if (valve.Value != 0)
                {
                    nonZeroes.Add(valve.Name);
                }
            }

            return nonZeroes;
        }

        private void InitializeLength(Dictionary<string, Valve> valves)
        {
            List<string> valveNames = valves.Keys.ToList();

            foreach(var from in valveNames)
            {
                foreach(var to in valveNames)
                {
                    valves[from].Lengths.Add(to, GetLength(from, to, valves));
                }
            }
        }

        private int GetLength(string current, string destination, Dictionary<string, Valve> valves)
        {
            if (current == destination)
            {
                return 0;
            }

            Queue<string> queue = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();
            queue.Enqueue(current);
            visited.Add(current);
            int length = 0;

            while (queue.Count > 0)
            {
                int count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    string valve = queue.Dequeue();

                    if (valve == destination)
                    {
                        return length;
                    }

                    foreach (var neighbor in valves[valve].Neighbors)
                    {
                        queue.Enqueue(neighbor.Name);
                        visited.Add(neighbor.Name);
                    }
                }

                length++;
            }

            return -1;

        }

        private Dictionary<string, Valve> ParseInput(IList<string> input)
        {
            Dictionary<string, List<string>> valveStringMap = new Dictionary<string, List<string>>();
            Dictionary<string, Valve> valveMap = new Dictionary<string, Valve>();
            long v = 1;
            int m = 0;
            
            foreach(string s in input)
            {
                var splitS = s.Split(" ");
                string nodeVal = splitS[1];
                int val = Convert.ToInt32(splitS[4].Replace("rate=", "").Replace(";", ""));
                Valve valve = new Valve(nodeVal, val, v << m);

                int children = splitS.Length - 9;
                valveStringMap.Add(nodeVal, new List<string>());
                for (int i = 0; i < children; i++)
                {
                    valveStringMap[nodeVal].Add(splitS[9 + i].Replace(",",""));
                }

                valveMap.Add(nodeVal, valve);
                m++;
            }

            foreach(KeyValuePair<string, List<string>> pair in valveStringMap)
            {
                foreach(var childStr in pair.Value)
                {
                    valveMap[pair.Key].Neighbors.Add(valveMap[childStr]);
                }
            }

            return valveMap;
        }
    }

    public class Valve
    {
        public string Name;
        public int Value;
        public long Mask;
        public List<Valve> Neighbors;
        public Dictionary<string, int> Lengths;

        public Valve(string name, int value, long mask)
        {
            Name = name;
            Value = value;
            Mask = mask;
            Neighbors = new List<Valve>();
            Lengths = new Dictionary<string, int>();
        }
    }
}
