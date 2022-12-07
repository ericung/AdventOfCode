using System.Text;

namespace AdventOfCode2022
{
    public class Problem05
    {
        public static string MoveCrates(IList<Stack<char>> crates, IList<IList<int>> moves)
        {
            List<char> list = new List<char>();

            foreach(var move in moves)
            {
                int m = move[0];
                for(int i = 0; i < m; i++)
                {
                    var to = move[2] - 1;
                    var from = move[1] - 1;
                    crates[to].Push(crates[from].Pop());
                }
            }

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < crates.Count; i++)
            {
                sb.Append(crates[i].Peek());
            }

            return sb.ToString();
        }

        public static string MoveCrates9001(IList<Stack<char>> crates, IList<IList<int>> moves)
        {
            List<char> list = new List<char>();

            foreach(var move in moves)
            {
                int m = move[0];
                Stack<char> order = new Stack<char>();
                var to = move[2] - 1;
                var from = move[1] - 1;

                for(int i = 0; i < m; i++)
                {
                    order.Push(crates[from].Pop());
                }

                for (int i = order.Count-1; i >= 0; i--)
                {
                    crates[to].Push(order.Pop());
                }
            }

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < crates.Count; i++)
            {
                sb.Append(crates[i].Peek());
            }

            return sb.ToString();
        }
    }
}
