using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Problem15
    {
        public int Intersect(IList<string> input, int y)
        {
            (List<Sensor> sensors, Dictionary<(int,int),Beacon> beacons) = ParseInput(input);
            HashSet<(int, int)> visited = new HashSet<(int, int)>();

            foreach(Sensor sensor in sensors)
            {
                int distance = GetDistance(sensor.X, y, sensor.X, sensor.Y);
                int iter = 0;
                while (distance <= sensor.Distance)
                {
                    int x = sensor.X - iter;
                    distance = GetDistance(x, y, sensor.X, sensor.Y);
                    if (distance <= sensor.Distance)
                    {
                        if (!beacons.ContainsKey((x,y)))
                        {
                            visited.Add((x, y));
                        }
                    }

                    x = sensor.X + iter;
                    distance = Math.Min(distance, GetDistance(x, y, sensor.X, sensor.Y));
                    if (distance <= sensor.Distance)
                    {
                        if (!beacons.ContainsKey((x,y)))
                        {
                            visited.Add((x, y));
                        }
                    }

                    iter++;
                }
            }
            var sorted = visited.ToList();
            sorted.Sort((a, b) => a.Item1 - b.Item1);
            return visited.Count;
        }

        public List<(int,int)> IntersectY(Sensor sensor, int y)
        {
            var dy = Math.Abs(y - sensor.Y);
            if (dy > sensor.Distance)
                return new List<(int,int)>();

            var dx = sensor.Distance - dy;
            return new List<(int, int)> { (sensor.X - dx, sensor.X + dx) };
        }

        public long TuningSignal(IList<string> input, int max)
        {
            (List<Sensor> sensors, Dictionary<(int,int),Beacon> beacons) = ParseInput(input);
            HashSet<(int, int)> visited = new HashSet<(int, int)>();

            for(int y = 0; y <= max; y++)
            {
                var range = new List<(int, int)>();
                foreach(Sensor sensor in sensors)
                {
                    range.AddRange(IntersectY(sensor, y));
                }

                var x = CompactRanges(range, max);

                if (x != -1)
                {
                    return (long)x * 4000000 + (long)y;
                }
            }

            return -1;
        }

        private int CompactRanges(List<(int,int)> ranges, int max)
        {
            ranges.Sort((a, b) => a.Item1 == b.Item1 ? a.Item2 - b.Item2 : a.Item1 - b.Item1);
            HashSet<(int, int)> newRanges = new HashSet<(int, int)>();
            int i = 0;

            while (i < ranges.Count)    
            {
                int left = ranges[i].Item1;
                int right;
                if (ranges[i].Item1 < 0)
                {
                    if (ranges[i].Item2 < 0)
                    {
                        i++;
                        continue;
                    }

                    left = 0;
                }

                if (ranges[i].Item1 > max)
                {
                    i++;
                    break;
                }

                right = ranges[i].Item2;
                while (i+1 < ranges.Count && right >= ranges[i+1].Item1)
                {
                    right = Math.Max(ranges[++i].Item2, right);
                    right = Math.Min(right, max);
                }

                newRanges.Add((left, right));
                i++;
            }

            if (newRanges.Count > 1)
            {
                var newRangesList = newRanges.ToList();
                newRangesList.Sort((a,b)=>a.Item1 - b.Item1);
                return newRangesList[0].Item2 + 1;
            }

            if (newRanges.FirstOrDefault().Item1 != 0)
            {
                return newRanges.FirstOrDefault().Item1;
            }

            if (newRanges.FirstOrDefault().Item2 != max)
            {
                return newRanges.FirstOrDefault().Item2;
            }

            return -1;
        }

        private HashSet<(int,int)> GetPositions(Sensor sensor)
        {
            HashSet<(int, int)> positions = new HashSet<(int, int)>();
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((sensor.X, sensor.Y));

            while (queue.Count > 0)
            {
                (int x, int y) = queue.Dequeue();

                if ((GetDistance(x,y+1,sensor.X, sensor.Y) <= sensor.Distance)&&(!positions.Contains((x,y+1))))
                {
                    positions.Add((x,y+1));
                    queue.Enqueue((x,y+1));
                }

                if ((GetDistance(x,y-1,sensor.X, sensor.Y) <= sensor.Distance)&&(!positions.Contains((x,y-1))))
                {
                    positions.Add((x,y-1));
                    queue.Enqueue((x, y - 1));
                }

                if ((GetDistance(x+1,y,sensor.X, sensor.Y) <= sensor.Distance)&&(!positions.Contains((x+1,y))))
                {
                    positions.Add((x+1,y));
                    queue.Enqueue((x + 1, y));
                }
     
                if ((GetDistance(x-1,y,sensor.X, sensor.Y) <= sensor.Distance)&&(!positions.Contains((x-1,y))))
                {
                    positions.Add((x-1,y));
                    queue.Enqueue((x - 1, y));
                }
            }

            return positions;
        }

        private (List<Sensor>, Dictionary<(int,int),Beacon>) ParseInput(IList<string> input)
        {
            List<Sensor> sensorList = new List<Sensor>();
            Dictionary<(int, int), Beacon> beaconMap = new Dictionary<(int, int), Beacon>();

            foreach(string s in input)
            {
                string[] splitS = s.Split(" ");
                int sensorX = Convert.ToInt32(splitS[2].Replace("x=","").Replace(",",""));
                int sensorY = Convert.ToInt32(splitS[3].Replace("y=","").Replace(":",""));
                int beaconX = Convert.ToInt32(splitS[8].Replace("x=","").Replace(",", ""));
                int beaconY = Convert.ToInt32(splitS[9].Replace("y=", ""));
                Sensor newSensor;
                Beacon beacon;

                if (beaconMap.ContainsKey((beaconX,beaconY)))
                {
                    beacon = beaconMap[(beaconX, beaconY)];
                }
                else
                {
                    beacon = new Beacon(beaconY, beaconY, new List<Sensor>());
                    beaconMap.Add((beaconX, beaconY), beacon);
                }

                newSensor = new Sensor(sensorX, sensorY, beacon, GetDistance(sensorX, sensorY, beaconX, beaconY));
                beacon.Sensors.Add(newSensor);
                sensorList.Add(newSensor);
            }

            return (sensorList, beaconMap);
        }

        private int GetDistance(int x1, int y1, int x2, int y2)
        {
            int xDistance = Math.Abs(x1 - x2);
            int yDistance = Math.Abs(y1 - y2);

            return xDistance + yDistance;
        }
    }

    public class Sensor
    {
        public int X;
        public int Y;
        public Beacon Beacon;
        public int Distance;

        public Sensor(int x, int y, Beacon beacon, int distance)
        {
            X = x;
            Y = y;
            Beacon = beacon;
            this.Distance = distance;
        }
    }

    public class Beacon
    {
        public int X;
        public int Y;
        public List<Sensor> Sensors;
        public Beacon(int x, int y, List<Sensor> sensors)
        {
            X = x;
            Y = y;
            Sensors = sensors;
        }
    }
}
