namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem12Tests
    {
        [TestMethod]
        public void TraverseTest1()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem12test1.txt");
            List<IList<char>> list = new List<IList<char>>();
            int startR = -1;
            int startC = -1;
            int endR = -1;
            int endC = -1;

            for (int i = 0; i < strings.Length; i++)
            {
                var s = strings[i];
                if (s != string.Empty)
                {
                    List<char> row = new List<char>();
                    for (int j = 0; j < s.Length; j++)
                    {
                        var c = s[j];
                        if (s[j] == 'S')
                        {
                            startR = i;
                            startC = j;
                            c = 'a';
                        }
                        else if (s[j] == 'E')
                        {
                            endR = i;
                            endC = j;
                            c = 'z';
                        }

                        row.Add(c);
                    }
                    list.Add(row);
                }
            }

            int m = list.Count;
            int n = list[0].Count;

            char[,] map = new char[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    map[i, j] = list[i][j];
                }
            }

            Problem12 problem12 = new Problem12();
            #endregion

            #region Act
            var mostActive = problem12.Traverse(map, startR, startC, endR, endC);
            #endregion

            #region Assert
            Assert.AreEqual(31, mostActive);
            #endregion
        }
        
        [TestMethod]
        public void TraverseInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem12input.txt");
            List<IList<char>> list = new List<IList<char>>();
            int startR = -1;
            int startC = -1;
            int endR = -1;
            int endC = -1;

            for (int i = 0; i < strings.Length; i++)
            {
                var s = strings[i];
                if (s != string.Empty)
                {
                    List<char> row = new List<char>();
                    for (int j = 0; j < s.Length; j++)
                    {
                        var c = s[j];
                        if (s[j] == 'S')
                        {
                            startR = i;
                            startC = j;
                            c = 'a';
                        }
                        else if (s[j] == 'E')
                        {
                            endR = i;
                            endC = j;
                            c = 'z';
                        }

                        row.Add(c);
                    }
                    list.Add(row);
                }
            }

            int m = list.Count;
            int n = list[0].Count;

            char[,] map = new char[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    map[i, j] = list[i][j];
                }
            }

            Problem12 problem12 = new Problem12();
            #endregion

            #region Act
            var mostActive = problem12.Traverse(map, startR, startC, endR, endC);
            #endregion

            #region Assert
            Assert.AreEqual(423, mostActive);
            #endregion
        }

        [TestMethod]
        public void TraverseMultipleTest1()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem12test1.txt");
            List<IList<char>> list = new List<IList<char>>();
            int startR = -1;
            int startC = -1;
            int endR = -1;
            int endC = -1;

            for (int i = 0; i < strings.Length; i++)
            {
                var s = strings[i];
                if (s != string.Empty)
                {
                    List<char> row = new List<char>();
                    for (int j = 0; j < s.Length; j++)
                    {
                        var c = s[j];
                        if (s[j] == 'S')
                        {
                            startR = i;
                            startC = j;
                            c = 'a';
                        }
                        else if (s[j] == 'E')
                        {
                            endR = i;
                            endC = j;
                            c = 'z';
                        }

                        row.Add(c);
                    }
                    list.Add(row);
                }
            }

            int m = list.Count;
            int n = list[0].Count;

            char[,] map = new char[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    map[i, j] = list[i][j];
                }
            }

            Problem12 problem12 = new Problem12();
            #endregion

            #region Act
            var mostActive = problem12.TraverseMultiple(map, endR, endC);
            #endregion

            #region Assert
            Assert.AreEqual(29, mostActive);
            #endregion
        }

        [TestMethod]
        public void TraverseMultipleInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem12input.txt");
            List<IList<char>> list = new List<IList<char>>();
            int startR = -1;
            int startC = -1;
            int endR = -1;
            int endC = -1;

            for (int i = 0; i < strings.Length; i++)
            {
                var s = strings[i];
                if (s != string.Empty)
                {
                    List<char> row = new List<char>();
                    for (int j = 0; j < s.Length; j++)
                    {
                        var c = s[j];
                        if (s[j] == 'S')
                        {
                            startR = i;
                            startC = j;
                            c = 'a';
                        }
                        else if (s[j] == 'E')
                        {
                            endR = i;
                            endC = j;
                            c = 'z';
                        }

                        row.Add(c);
                    }
                    list.Add(row);
                }
            }

            int m = list.Count;
            int n = list[0].Count;

            char[,] map = new char[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    map[i, j] = list[i][j];
                }
            }

            Problem12 problem12 = new Problem12();
            #endregion

            #region Act
            var mostActive = problem12.TraverseMultiple(map, endR, endC);
            #endregion

            #region Assert
            Assert.AreEqual(416, mostActive);
            #endregion
        }
    }
}
