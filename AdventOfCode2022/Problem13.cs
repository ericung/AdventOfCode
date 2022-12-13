using System.Text;

namespace AdventOfCode2022
{
    public class Problem13
    {
        public int RightOrder(IList<IList<string>> list)
        {
            int sum = 0;
            int index = 1;

            foreach (var pair in list)
            {
                string left = pair[0];
                string right = pair[1];

                List<Node> leftData = ConvertToNode(left,0).Item2;
                List<Node> rightData = ConvertToNode(right,0).Item2;

                if (CompareInOrder(leftData, rightData) == 0)
                {
                    sum += index;
                }

                index++;
            }

            return sum;
        }

        public int SortOrder(IList<IList<string>> list)
        {
            int multiple = 1;
            List<string> sortedList = new List<string>() { "[[2]]", "[[6]]" };

            foreach(var pair in list)
            {
                sortedList.Add(pair[0]);
                sortedList.Add(pair[1]);
            }

            sortedList.Sort((a, b) => CompareInOrder(ConvertToNode(a,0).Item2, ConvertToNode(b,0).Item2) == 0 ? -1 : 1);
            int index = 1;

            foreach (string s in sortedList)
            {
                if (s == "[[2]]")
                {
                    multiple *= index;
                }

                if (s == "[[6]]")
                {
                    multiple *= index;
                }
                index++;
            }

            return multiple;
        }

        private int CompareInOrder(List<Node> leftData, List<Node> rightData)
        {
            int i = 0;

            if (leftData.Count == 0 && rightData.Count > 0)
            {
                return 0;
            }
            else if (leftData.Count > 0 && rightData.Count == 0)
            {
                return 2;
            }

            while (i < leftData.Count)
            {
                if (i == rightData.Count)
                {
                    return 2;
                }
                
                if (leftData[i].type == typeof(int)
                    && rightData[i].type == typeof(int))
                {
                    if (leftData[i].value < rightData[i].value)
                    {
                        return 0;
                    }
                    else if (leftData[i].value > rightData[i].value)
                    {
                        return 2;
                    }
                }
                else if (leftData[i].type == typeof(int)
                    && rightData[i].type == typeof(List<Node>))
                {
                    var child = new List<Node>() { new Node(leftData[i].value) };
                    var res = CompareInOrder(child, rightData[i].children);
                    if (res != 1)
                    {
                        return res;
                    }
                }
                else if (leftData[i].type == typeof(List<Node>)
                    && rightData[i].type == typeof(int))
                {
                    var child = new List<Node>() { new Node(rightData[i].value) };
                    var res = CompareInOrder(leftData[i].children, child);
                    if (res != 1)
                    {
                        return res;
                    }
                }
                else if (leftData[i].type == typeof(List<Node>)
                    && rightData[i].type == typeof(List<Node>))
                {
                    var res = CompareInOrder(leftData[i].children, rightData[i].children);
                    if (res != 1)
                    {
                        return res;
                    }
                }

                i++; 
            }

            if (leftData.Count == rightData.Count)
            {
                return 1;
            }

            return 0;
        }

        private (int, List<Node>) ConvertToNode(string str, int pos)
        {
            List<Node> list = new List<Node>();
            int i = pos;

            while (i < str.Length)
            {
                if (str[i] == '[')
                {
                    (i, var subList) = ConvertToNode(str, i + 1);
                    Node node = new Node(subList);
                    list.Add(node);
                }
                else if (str[i] == ']')
                {
                    return (i+1, new List<Node>(list));
                }
                else if (str[i] != ',')
                {
                    StringBuilder num = new StringBuilder();
                    while (i < str.Length && str[i] != ',' && str[i] != '[' && str[i] != ']')
                    {
                        num.Append(str[i++]);
                    }
                    list.Add(new Node(Convert.ToInt32(num.ToString())));
                }
                else
                {
                    i++;
                }
            }

            return (i, list);
        }
    }

    public class Node
    {
        public Type type;
        public int value;
        public List<Node> children;

        public Node(int val)
        {
            value = val;
            type = typeof(int);
        }

        public Node(List<Node> list)
        {
            children = new List<Node>(list);
            type = typeof(List<Node>);
        }
    }
}
