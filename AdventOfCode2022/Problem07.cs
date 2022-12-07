using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Problem07
    {
        public long FindSum(List<string[]> terminal)
        {
            Dictionary<string, List<string[]>> directory = ConvertToDirectory(terminal);

            Dictionary<string, long> pathSize = MapValues("/", directory, new Dictionary<string, long>());

            long sum = 0;

            foreach (KeyValuePair<string, long> pair in pathSize)
            {
                if (pair.Value <= 100000)
                {
                    sum += pair.Value;
                }
            }

            return sum;
        }

        public long FindDirectory(List<string[]> terminal)
        {
            Dictionary<string, List<string[]>> directory = ConvertToDirectory(terminal);

            Dictionary<string, long> pathSize = MapValues("/", directory, new Dictionary<string, long>());

            long dirSize = long.MaxValue;
            long usedSpace = 70000000 - pathSize["/"];

            foreach (KeyValuePair<string, long> pair in pathSize)
            {
                if ((pair.Key != "/") &&(usedSpace + pair.Value >= 30000000))
                {
                    dirSize = Math.Min(pair.Value, dirSize);
                }
            }

            return dirSize;
        }

        private Dictionary<string, List<string[]>> ConvertToDirectory(List<string[]> terminal)
        {
            Dictionary<string, List<string[]>> directory = new Dictionary<string, List<string[]>>();
            string curPath = "/";
            for (int i = 0; i < terminal.Count; i++)
            {
                var line = terminal[i];
                if (line[0] == "$")
                {
                    switch(line[1])
                    {
                        case "cd": 
                            switch (line[2])
                            {
                                case "..":
                                    {
                                        var split = curPath.Split('/');
                                        StringBuilder sb = new StringBuilder();
                                        for (int j = 0; j < split.Length-1; j++)
                                        {
                                            sb.Append(split[j]);
                                            if (j < split.Length - 2)
                                            {
                                                sb.Append("/");
                                            }
                                        }
                                        curPath = sb.ToString();
                                        break;
                                    }
                                case "/":
                                    curPath = "/";
                                    break;
                                default:
                                    {
                                        if (curPath == "/")
                                        {
                                            curPath += line[2];
                                        }
                                        else
                                        {
                                            curPath += "/" + line[2];
                                        }
                                        break;
                                    }
                            }
                            break;
                        case "ls":
                            {
                                for(i = i+1; i < terminal.Count && terminal[i][0] != "$"; i++)
                                {
                                    if (!directory.ContainsKey(curPath))
                                    {
                                        directory.Add(curPath, new List<string[]>()); 
                                    }
                                    if (terminal[i][0] == "dir")
                                    {
                                        directory[curPath].Add(new string[] { "dir", (curPath == "/" ? "" : curPath) + "/" + terminal[i][1] });
                                    }
                                    else
                                    {
                                        directory[curPath].Add(terminal[i]);
                                    }
                                }
                                if (i < terminal.Count && terminal[i][0] == "$")
                                {
                                    i--;
                                }
                                break;
                            }
                    }
                }
            }

            return directory;
        }

        private Dictionary<string,long> MapValues(string curPath, Dictionary<string, List<string[]>> directory, Dictionary<string, long> pathSize)
        {
            long sum = 0;

            foreach (var item in directory[curPath])
            {
                if (item.Length != 1)
                {
                    if (item[0] == "dir")
                    {
                        sum += MapValues(item[1], directory, pathSize)[item[1]];
                    }
                    else
                    {
                        sum += Convert.ToInt32(item[0]);
                    }
                }
            }

            pathSize.Add(curPath, sum);
            return pathSize;
        }
    }
}
