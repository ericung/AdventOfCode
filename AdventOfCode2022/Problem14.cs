using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Problem14
    {
        int MAX = -1;
        HashSet<(int, int)> map;

        public int NumberOfSandUnits(IList<string> paths)
        {
            HashSet<(int, int)> sand = new HashSet<(int, int)>();
            map = CreateMap(paths);
            MAX = MAX + 10;

            // recursion will have limits
            Drop(500, 0, sand);

            return sand.Count;
        }
        public int NumberOfSandUnits2(IList<string> paths)
        {
            HashSet<(int, int)> sand = new HashSet<(int, int)>();
            map = CreateMap(paths);
            DrawFloor();
            MAX = MAX + 2;

            // Use iteration because recursion will break
            while (Drop2(500, 0, sand))
            {

            }

            return sand.Count;
        }

        private void DrawFloor()
        {
            for(int i = -1000; i <= 1000; i++)
            {
                map.Add((i, MAX + 2));
            }
        }
        private bool Drop2(int x, int y, HashSet<(int,int)> sand)
        {
            (x, y) = Move(x, y, map);

            if (!map.Contains((x,y)))
            {
                sand.Add((x, y));
                map.Add((x, y));
                return true;
            }

            return false;
        }
        private void Drop(int x, int y, HashSet<(int,int)> sand)
        {
            (x, y) = Move(x, y, map);

            if (y < MAX)
            {
                sand.Add((x, y));
                map.Add((x, y));
                Drop(500, 0, sand);
            }
        }

        private (int, int) Move(int x, int y, HashSet<(int,int)> map)
        {
            if (!map.Contains((x,y + 1))&&(y < MAX))
            {
                return Move(x, y + 1, map);
            }
            else if (!map.Contains((x-1, y+1))&&(y< MAX))
            {
                return Move(x - 1, y + 1, map);
            }
            else if (!map.Contains((x+1, y+1))&&(y < MAX))
            {
                return Move(x + 1, y + 1, map);
            }

            return (x, y);
        }

        private HashSet<(int,int)> CreateMap(IList<string> paths)
        {
            HashSet<(int, int)> map = new HashSet<(int, int)>();

            foreach(string path in paths)
            {
                var points = path.Split(" -> ");
                var start = points[0].Split(",");
                var x = Convert.ToInt32(start[0]);
                var y = Convert.ToInt32(start[1]);

                for (int i = 1; i < points.Length; i++)
                {
                    var coordinates = points[i].Split(",");
                    var px = Convert.ToInt32(coordinates[0]);
                    var py = Convert.ToInt32(coordinates[1]);

                    var xdir = x - px;
                    var ydir = y - py;
                    
                    if (xdir < 0)
                    {
                        for (int cx = x; cx <= px; cx++)
                        {
                            map.Add((cx, y));
                        }
                    }
                    else if (xdir > 0)
                    {
                        for (int cx = x; cx >= px; cx--)
                        {
                            map.Add((cx, y));
                        }
                    }
                    else if (ydir < 0)
                    {
                        for (int cy = y; cy <= py; cy++)
                        {
                            map.Add((x, cy));
                        }
                    }
                    else if (ydir > 0)
                    {
                        for (int cy = y; cy >= py; cy--)
                        {
                            map.Add((x, cy));
                        }
                    }

                    x = px;
                    y = py;

                    MAX = Math.Max(MAX, y);
                }
            }

            return map;
        }
    }
}
