namespace AdventOfCode2022
{
    public class Problem02
    {
        public int GameScore(IList<IList<char>> list)
        {
            int n = list.Count;
            Dictionary<char, char> map = new Dictionary<char, char>()
            {
                {'X', 'A' },
                {'Y', 'B' },
                {'Z', 'C' }
            };
            
            int score = 0;

            for (int i = 0; i < n; i++)
            {
                score += GetScore(list[i][0], map[list[i][1]]);
            }

            return score;
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
