namespace AdventOfCode2022
{
    public class Problem12
    {
        private int[,] directions = new int[4,2] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };

        public int Traverse(char[,] map, int startR, int startC, int endR, int endC)
        {
            int m = map.GetLength(0);
            int n = map.GetLength(1);
            int steps = 0;
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((startR, startC));
            HashSet<(int,int)> visited = new HashSet<(int, int)> ();
            visited.Add((startR, startC));

            while (queue.Count > 0)
            {
                int count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    (int r, int c) = queue.Dequeue();

                    if (r == endR && c == endC)
                    {
                        return steps;
                    }

                    for (int d = 0; d < directions.GetLength(0); d++)
                    {
                        int newR = r + directions[d, 0];
                        int newC = c + directions[d, 1];

                        if ((newR >= 0 && newR < m && newC >= 0 && newC < n) && !visited.Contains((newR, newC)))
                        {
                            if (map[newR, newC] - map[r, c] <= 1)
                            {
                                visited.Add((newR, newC));
                                queue.Enqueue((newR, newC));
                            }
                        }
                    }
                }

                steps++;
            }
            
            return 0;
        }

        public int TraverseMultiple(char[,] map, int endR, int endC)
        {
            int m = map.GetLength(0);
            int n = map.GetLength(1);
            int steps = 0;
            Queue<(int, int)> queue = new Queue<(int, int)>();
            HashSet<(int,int)> visited = new HashSet<(int, int)> ();

            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (map[i,j] == 'a')
                    {
                        queue.Enqueue((i, j));
                        visited.Add((i, j));
                    }
                }
            }

            while (queue.Count > 0)
            {
                int count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    (int r, int c) = queue.Dequeue();

                    if (r == endR && c == endC)
                    {
                        return steps;
                    }

                    for (int d = 0; d < directions.GetLength(0); d++)
                    {
                        int newR = r + directions[d, 0];
                        int newC = c + directions[d, 1];

                        if ((newR >= 0 && newR < m && newC >= 0 && newC < n) && !visited.Contains((newR, newC)))
                        {
                            if (map[newR, newC] - map[r, c] <= 1)
                            {
                                visited.Add((newR, newC));
                                queue.Enqueue((newR, newC));
                            }
                        }
                    }
                }

                steps++;
            }
            
            return 0;
        }
    }
}
