namespace AdventOfCode2022
{
    public class Problem09
    {
        int[,] row = new int[,] { { -2, 0 }, { 2, 0 }, { 0, -2 }, { 0, 2 } };
        int[,] moveRow = new int[,] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
        int[,] diag = new int[,] { { -2, -1 }, {-2, 1 }, { 2, -1 }, { 2, 1 }, { -1, -2 }, { 1, -2 }, { -1, 2 }, { 1, 2 },
                                    { -2, -2 }, { -2, 2}, { 2, -2 }, {2, 2 } };
        int[,] moveDiag = new[,] { { -1, 0 }, { -1, 0 }, { 1, 0 }, { 1, 0 }, { 0, -1 }, { 0, -1 }, { 0, 1 }, { 0, 1 },
                                    { -1, -1 }, { -1, 1 }, { 1, -1 }, { 1, 1 } };
        public int LocationsCovered(List<(char, int)> list)
        {
            HashSet<(int, int)> positions = new HashSet<(int, int)>();
            positions.Add((0, 99));
            int[] x = new int[2];
            int[] y = new int[2];
            for (int i = 0; i < 2; i++)
            {
                y[i] = 99;
            }
            
            foreach (var item in list)
            {
                for (int i = 0; i < 1; i++)
                {
                    (x[i], y[i], x[i + 1], y[i + 1]) = Move(item.Item1, item.Item2, x[i], y[i], x[i + 1], y[i + 1], i + 1, 1, positions);
                }
            }

            return positions.Count;
        }

        public int LocationsCovered2(List<(char, int)> list)
        {
            HashSet<(int, int)> positions = new HashSet<(int, int)>();
            positions.Add((0, 99));
            int[] x = new int[10];
            int[] y = new int[10];
            for (int i = 0; i < 10; i++)
            {
                y[i] = 99;
            }
            
            foreach (var item in list)
            {
                Move2(x, y, item.Item1, item.Item2, positions);
            }

            return positions.Count;
        }

        private (int,int, int, int) Move(char d, int length, int headX, int headY, int tailX, int tailY, int curIndex, int tailIndex, HashSet<(int, int)> positions)
        {
            int hx = headX;
            int hy = headY;
            int tx = tailX;
            int ty = tailY;
            
            for (int i = 0; i < length; i++)
            {
                switch (d)
                {
                    case 'R':
                        hx++;
                        break;
                    case 'L':
                        hx--;
                        break;
                    case 'U':
                        hy--;
                        break;
                    case 'D':
                        hy++;
                        break;
                }

                (tx, ty) = GetTail(hx, hy, tx, ty);
                if (curIndex == tailIndex)
                {
                    positions.Add((tx, ty));
                }
            }

            return (hx, hy, tx, ty);
        }
        private void Move2(int[] x, int[] y, char d, int length, HashSet<(int, int)> positions)
        {
            int n = x.Length; 

            for (int i = 0; i < length; i++)
            {
                switch (d)
                {
                    case 'R':
                        x[0]++;
                        break;
                    case 'L':
                        x[0]--;
                        break;
                    case 'U':
                        y[0]--;
                        break;
                    case 'D':
                        y[0]++;
                        break;
                }

                for (int j = 0; j < n - 1; j++)
                {
                    (x[j+1], y[j+1]) = GetTail(x[j], y[j], x[j+1], y[j+1]);
                    if (j+1 == n-1)
                    {
                        positions.Add((x[j+1], y[j+1]));
                    }
                }
            }
        }
        private (int, int) GetTail(int hx, int hy, int tx, int ty)
        {
            for (int i = 0; i < row.GetLength(0); i++)
            {
                int potX = hx + row[i, 0];
                int potY = hy + row[i, 1];

                if (potX == tx && potY == ty)
                {
                    return (hx + moveRow[i, 0], hy + moveRow[i, 1]);
                }
            }

            for (int i = 0; i < diag.GetLength(0); i++)
            {
                int potX = hx + diag[i, 0];
                int potY = hy + diag[i, 1];

                if (potX == tx && potY == ty)
                {
                    return (hx + moveDiag[i, 0], hy + moveDiag[i, 1]);
                }
            }

            return (tx, ty);
        }
    }
}
