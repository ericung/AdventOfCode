namespace AdventOfCode2022
{
    public static class Problem06
    {
        public static int FindFirstMarker(string buffer)
        {
            int index = 0;
            Queue<char> queue = new Queue<char>();
            Dictionary<char, int> map = new Dictionary<char, int>();

            for(index = 0; index < buffer.Length; index++)
            {
                // initial case
                if (queue.Count < 4)
                {
                    queue.Enqueue(buffer[index]);
                    if (!map.ContainsKey(buffer[index]))
                    {
                        map.Add(buffer[index], 0);
                    }
                    map[buffer[index]]++;
                }
                else
                {
                    char remove = queue.Dequeue();
                    map[remove]--;
                    if (map[remove] <= 0)
                    {
                        map.Remove(remove);
                    }

                    queue.Enqueue(buffer[index]);
                    if (!map.ContainsKey(buffer[index]))
                    {
                        map.Add(buffer[index], 0);
                    }
                    map[buffer[index]]++;
                }

                if (map.Count == 4)
                {
                    return index + 1;
                }

            }

            return index + 1;
        }
        public static int FindFirstMarkerWithMessage(string message)
        {
            int index = 0;
            Queue<char> queue = new Queue<char>();
            Dictionary<char, int> map = new Dictionary<char, int>();

            for(index = 0; index < message.Length; index++)
            {
                // initial case
                if (queue.Count < 14)
                {
                    queue.Enqueue(message[index]);
                    if (!map.ContainsKey(message[index]))
                    {
                        map.Add(message[index], 0);
                    }
                    map[message[index]]++;
                }
                else
                {
                    char remove = queue.Dequeue();
                    map[remove]--;
                    if (map[remove] <= 0)
                    {
                        map.Remove(remove);
                    }

                    queue.Enqueue(message[index]);
                    if (!map.ContainsKey(message[index]))
                    {
                        map.Add(message[index], 0);
                    }
                    map[message[index]]++;
                }

                if (map.Count == 14)
                {
                    return index + 1;
                }

            }

            return index + 1;
        }
    }
}
