using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Problem03
    {
        public int FindPriority(IList<string> list)
        {
            int n = list.Count;
            int priority = 0;

            for (int i = 0; i < n; i++)
            {
                int l = list[i].Length;
                int hl = l / 2;

                HashSet<char> presents = new HashSet<char>();
                for (int j = 0; j < hl; j++)
                {
                    presents.Add(list[i][j]);
                }

                char intersect = ' ';
                for (int j = 0; j < hl; j++)
                {
                    if (presents.Contains(list[i][hl + j]))
                    {
                        intersect = list[i][hl + j];
                        break;
                    }
                }

                priority += GetScore(intersect);
            }

            return priority;
        }
        public int FindPriorityGroup(IList<string> list)
        {
            if (list.Count % 3 != 0)
            {
                return -1;
            }

            int n = list.Count;
            int priority = 0;

            for (int i = 0; i < n; i+=3)
            {
                HashSet<char> presents1 = new HashSet<char>();
                for (int j = 0; j < list[i].Length; j++)
                {
                    presents1.Add(list[i][j]);
                }

                HashSet<char> presents2 = new HashSet<char>();
                for (int j = 0; j < list[i+1].Length; j++)
                {
                    presents2.Add(list[i + 1][j]);
                }

                char intersect = ' ';
                for (int j = 0; j < list[i+2].Length; j++)
                {
                    char c = list[i+2][j];
                    if (presents1.Contains(c)&&presents2.Contains(c))
                    {
                        intersect = c;
                        break;
                    }
                }

                priority += GetScore(intersect);
            }

            return priority;
        }
        private int GetScore(char c)
        {
            if (c == ' ')
            {
                return 0;
            }
            if (c >= 'a' && c <= 'z')
            {
                return c - 'a' + 1;
            }
            else
            {
                return c - 'A' + 27;
            }
        }

    }
}
