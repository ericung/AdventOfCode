using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Problem02
    {
        public int GameScore(IList<IList<char>> list)
        {
            int n = list.Count;
            Dictionary<char, char>[] map = new Dictionary<char, char>[3];
            map[0] = new Dictionary<char, char>()
            {
                {'X', 'A' },
                {'Y', 'B' },
                {'Z', 'C' }
            };
            map[1] = new Dictionary<char, char>()
            {
                {'X', 'B' },
                {'Y', 'C' },
                {'Z', 'A' }
            };
            map[2] = new Dictionary<char, char>()
            {
                {'X', 'C' },
                {'Y', 'A' },
                {'Z', 'B' }
            };

            int[][] dp = new int[n][];

            for (int i = 0; i < n; i++)
            {
                dp[i] = new int[3];
            }

            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                {
                    dp[i][0] = dp[i - 1][0] + GetScore(list[i][0], map[0][list[i][1]]);
                    dp[i][1] = dp[i - 1][1] + GetScore(list[i][0], map[1][list[i][1]]);
                    dp[i][2] = dp[i - 1][2] + GetScore(list[i][0], map[2][list[i][1]]);
                }
                else
                {
                    dp[i][0] = GetScore(list[i][0], map[0][list[i][1]]);
                    dp[i][1] = GetScore(list[i][0], map[1][list[i][1]]);
                    dp[i][2] = GetScore(list[i][0], map[2][list[i][1]]);
                }
            }

            return dp[n-1][0];
        }

        public int GameScore2(IList<IList<char>> list)
        {
            int n = list.Count;

            int score = 0;

            for (int i = 0; i < n; i++)
            {
                score += GetScore2(list[i][0], list[i][1]);
            }

            return score;
        }

        private int GetScore2(char opponent, char rule)
        {
            if (rule == 'Y')
            {
                return Score(opponent) + 3;
            }

            int score = 0;
            if (rule == 'X' && opponent == 'B')
            {
                return Score('A');
            }
            else if (rule == 'X' && opponent == 'A')
            {
                return Score('C');
            }
            else if (rule == 'X' && opponent == 'C')
            {
                return Score('B');
            }
            
            if (rule == 'Z' && opponent == 'B')
            {
                return Score('C') + 6;
            }
            else if (rule == 'Z' && opponent == 'A')
            {
                return Score('B') + 6;
            }
            else if (rule == 'Z' && opponent == 'C')
            {
                return Score('A') + 6;
            }

            return score;
        }

        private int GetScore(char opponent, char player)
        {
            if ((opponent == 'A' && player == 'A')||
                (opponent == 'B' && player == 'B')||
                (opponent == 'C' && player == 'C'))
            {
                return Score(opponent) + 3;
            }

            int score = Score(player);

            if ((player == 'A' && opponent == 'C')||
                (player == 'C' && opponent == 'B')||
                (player == 'B' && opponent == 'A'))
            {
                score += 6;
            }

            return score;
        }

        private int Score(char c)
        {
            switch(c)
            {
                case 'A':
                    return 1;
                case 'B':
                    return 2;
                case 'C':
                    return 3;
            }

            return 0;
        }
    }
}
