namespace AdventOfCode2022
{
    public class Problem08
    {
        public int VisibleTrees(IList<IList<int>> trees)
        {
            int m = trees.Count;
            int n = trees[0].Count;
            Stack<int> mono = new Stack<int>();
            HashSet<(int, int)> treeHash = new HashSet<(int, int)>();

            for (int i = 0; i < m; i++)
            {
                mono.Push(trees[i][0]);
                treeHash.Add((i, 0));
                for (int j = 1; j < n; j++)
                {
                    if (mono.Peek() < trees[i][j])
                    {
                        mono.Push(trees[i][j]);
                        treeHash.Add((i, j));
                    }
                }

                mono.Clear();
                mono.Push(trees[i][n - 1]);
                treeHash.Add((i, n - 1));
                for(int j = n-2; j>=0; j--)
                {
                    if (mono.Peek() < trees[i][j])
                    {
                        mono.Push(trees[i][j]);
                        treeHash.Add((i, j));
                    }
                }

                mono.Clear();
            }

            for (int j = 0; j < n; j++)
            {
                mono.Push(trees[0][j]);
                treeHash.Add((0, j));
                for (int i = 1; i < m; i++)
                {
                    if (mono.Peek() < trees[i][j])
                    {
                        mono.Push(trees[i][j]);
                        treeHash.Add((i, j));
                    }
                }

                mono.Clear();
                mono.Push(trees[m-1][j]);
                treeHash.Add((m - 1, j));
                for(int i = m-2; i>=0; i--)
                {
                    if (mono.Peek() < trees[i][j])
                    {
                        mono.Push(trees[i][j]);
                        treeHash.Add((i, j));
                    }
                }

                mono.Clear();
            }

            return treeHash.Count;
        }

        public int ScenicScore(IList<IList<int>> trees)
        {
            int m = trees.Count;
            int n = trees[0].Count;
            int max = 0; 
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    max = Math.Max(max, GetScore(i, j, trees));
                }
            }
            return max;
        }

        private int GetScore(int r, int c, IList<IList<int>> trees)
        {
            int m = trees.Count;
            int n = trees[0].Count;
            int left = 0;
            int right = 0;
            int up = 0;
            int down = 0;

            // left
            for (int j = c+1; j < n; j++)
            {
                left++;
                if (trees[r][c] <= trees[r][j])
                {
                    break;
                }
            }

            // right
            for(int j = c-1; j>=0; j--)
            {
                right++;
                if (trees[r][c] <= trees[r][j])
                {
                    break;
                }
            }

            // up
            for (int i = r+1; i < m; i++)
            {
                up++;
                if (trees[r][c] <= trees[i][c])
                {
                    break;
                }
            }

            //down
            for(int i = r-1; i>=0; i--)
            {
                down++;
                if (trees[r][c] <= trees[i][c])
                {
                    break;
                }
            }

            return left*right*up*down;
        }
    }
}
