using System.Text;

namespace AdventOfCode2022
{
    public class Problem10
    {
        private HashSet<int> cycles = new HashSet<int>() { 20, 60, 100, 140, 180, 220 };
        private HashSet<int> render = new HashSet<int>() { 40, 80, 120, 160, 200, 240 };

        public int SignalStrength(List<string[]> list)
        {
            int signalStrength = 0;
            int cycle = 1;
            int x = 1;

            for (int i = 0; i < list.Count; i++)
            {
                var line = list[i];
                if (cycles.Contains(cycle))
                {
                    signalStrength += cycle*x;
                }
                
                if (list[i][0] == "addx")
                {
                    cycle++;

                    if (cycles.Contains(cycle))
                    {
                        signalStrength += cycle*x;
                    }

                    x += Convert.ToInt32(list[i][1]);
                }

                cycle++;
            }

            while (cycle < 221)
            {
                if (cycles.Contains(cycle))
                {
                    signalStrength += cycle*x;
                }
                cycle++;
            }


            return signalStrength;
        }

        public string Render(List<string[]> list)
        {
            char[][] screen = new char[6][];
            int cycle = 0;
            int sprite = 1;
            int pos = 0;
            int v = 0;

            for (int i = 0; i < 6; i++)
            {
                screen[i] = new char[40];
            }

            for (int i = 0; i < list.Count; i++)
            {
                var line = list[i];

                if (render.Contains(cycle))
                {
                    v++;
                    pos = 0;
                }

                if (v < 6 && pos >= 0 && pos < 40 && pos >= sprite - 1 && pos <= sprite + 1)
                {
                    screen[v][pos] = '#';
                }
                pos++;

                if (list[i][0] == "addx")
                {
                    cycle++;

                    if (render.Contains(cycle))
                    {
                        v++;
                        pos = 0;
                    }

                    if (v < 6 && pos >= 0 && pos < 40 && pos >= sprite - 1 && pos <= sprite + 1)
                    {
                        screen[v][pos] = '#';
                    }
                    pos++;

                    sprite += Convert.ToInt32(list[i][1]);
                }

                cycle++;
            }

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 6; i++)
            {
                StringBuilder l = new StringBuilder();
                for(int j = 0; j < 40; j++)
                {
                    if (screen[i][j] == '#')
                    {
                        l.Append('#');
                    }
                    else
                    {
                        l.Append('.');
                    }    
                }
                sb.Append(l);

                if (i != 5)
                {
                    sb.Append("\r\n");
                }
            }

            return sb.ToString();
        }
    }
}
