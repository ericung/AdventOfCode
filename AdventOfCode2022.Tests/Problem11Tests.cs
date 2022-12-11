namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem11Tests
    {
        [TestMethod]
        public void FindMostActiveTest1()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem11test1.txt");
            List<IList<IList<string>>> list = new List<IList<IList<string>>>();

            for(int i = 0; i < strings.Length; i++)
            {
                var s = strings[i];
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    List<IList<string>> monkey = new List<IList<string>>();
                    if (line[0] == "Monkey")
                    {
                        List<string> id = new List<string> { line[1].Replace(":", "") };

                        var itemsReplace = strings[++i].Replace(",", "");
                        string[] itemsStr = itemsReplace.Trim().Split(' ');
                        List<string> items = new List<string>();
                        for (int j = 2; j < itemsStr.Length; j++)
                        {
                            items.Add(itemsStr[j]);
                        }

                        var operationStr = strings[++i].Trim().Split(' ');
                        List<string> operation = new List<string>();
                        for (int j = 3; j < operationStr.Length; j++)
                        {
                            operation.Add(operationStr[j]);
                        }

                        var testStr = strings[++i].Trim().Split(' ');
                        List<string> test = new List<string>();
                        for(int j = 1; j < testStr.Length; j++)
                        {
                            test.Add(testStr[j]);
                        }

                        string trueStr = strings[++i].Trim().Split(' ')[5];
                        string falseStr = strings[++i].Trim().Split(' ')[5];
                        List<string> condition = new List<string> { trueStr, falseStr };

                        monkey.Add(id); // 0
                        monkey.Add(items); // 1
                        monkey.Add(operation); // 2
                        monkey.Add(test); // 3
                        monkey.Add(condition); // 4
                    }
                    list.Add(monkey);
                }
            }

            Problem11 problem11 = new Problem11();
            #endregion

            #region Act
            var mostActive = problem11.FindMostActive(list);
            #endregion

            #region Assert
            Assert.AreEqual(10605, mostActive);
            #endregion
        }

        [TestMethod]
        public void FindMostActiveInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem11input.txt");
            List<IList<IList<string>>> list = new List<IList<IList<string>>>();

            for(int i = 0; i < strings.Length; i++)
            {
                var s = strings[i];
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    List<IList<string>> monkey = new List<IList<string>>();
                    if (line[0] == "Monkey")
                    {
                        List<string> id = new List<string> { line[1].Replace(":", "") };

                        var itemsReplace = strings[++i].Replace(",", "");
                        string[] itemsStr = itemsReplace.Trim().Split(' ');
                        List<string> items = new List<string>();
                        for (int j = 2; j < itemsStr.Length; j++)
                        {
                            items.Add(itemsStr[j]);
                        }

                        var operationStr = strings[++i].Trim().Split(' ');
                        List<string> operation = new List<string>();
                        for (int j = 3; j < operationStr.Length; j++)
                        {
                            operation.Add(operationStr[j]);
                        }

                        var testStr = strings[++i].Trim().Split(' ');
                        List<string> test = new List<string>();
                        for(int j = 1; j < testStr.Length; j++)
                        {
                            test.Add(testStr[j]);
                        }

                        string trueStr = strings[++i].Trim().Split(' ')[5];
                        string falseStr = strings[++i].Trim().Split(' ')[5];
                        List<string> condition = new List<string> { trueStr, falseStr };

                        monkey.Add(id); // 0
                        monkey.Add(items); // 1
                        monkey.Add(operation); // 2
                        monkey.Add(test); // 3
                        monkey.Add(condition); // 4
                    }
                    list.Add(monkey);
                }
            }

            Problem11 problem11 = new Problem11();
            #endregion

            #region Act
            var mostActive = problem11.FindMostActive(list);
            #endregion

            #region Assert
            Assert.AreEqual(50616, mostActive);
            #endregion
        }

        [TestMethod]
        public void FindMostActiveLongTest1()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem11test1.txt");
            List<IList<IList<string>>> list = new List<IList<IList<string>>>();

            for(int i = 0; i < strings.Length; i++)
            {
                var s = strings[i];
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    List<IList<string>> monkey = new List<IList<string>>();
                    if (line[0] == "Monkey")
                    {
                        List<string> id = new List<string> { line[1].Replace(":", "") };

                        var itemsReplace = strings[++i].Replace(",", "");
                        string[] itemsStr = itemsReplace.Trim().Split(' ');
                        List<string> items = new List<string>();
                        for (int j = 2; j < itemsStr.Length; j++)
                        {
                            items.Add(itemsStr[j]);
                        }

                        var operationStr = strings[++i].Trim().Split(' ');
                        List<string> operation = new List<string>();
                        for (int j = 3; j < operationStr.Length; j++)
                        {
                            operation.Add(operationStr[j]);
                        }

                        var testStr = strings[++i].Trim().Split(' ');
                        List<string> test = new List<string>();
                        for(int j = 1; j < testStr.Length; j++)
                        {
                            test.Add(testStr[j]);
                        }

                        string trueStr = strings[++i].Trim().Split(' ')[5];
                        string falseStr = strings[++i].Trim().Split(' ')[5];
                        List<string> condition = new List<string> { trueStr, falseStr };

                        monkey.Add(id); // 0
                        monkey.Add(items); // 1
                        monkey.Add(operation); // 2
                        monkey.Add(test); // 3
                        monkey.Add(condition); // 4
                    }
                    list.Add(monkey);
                }
            }

            Problem11 problem11 = new Problem11();
            #endregion

            #region Act
            var mostActive = problem11.FindMostActiveLong(list);
            #endregion

            #region Assert
            Assert.AreEqual(2713310158, mostActive);
            #endregion
        }

        [TestMethod]
        public void FindMostActiveLongInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem11input.txt");
            List<IList<IList<string>>> list = new List<IList<IList<string>>>();

            for(int i = 0; i < strings.Length; i++)
            {
                var s = strings[i];
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    List<IList<string>> monkey = new List<IList<string>>();
                    if (line[0] == "Monkey")
                    {
                        List<string> id = new List<string> { line[1].Replace(":", "") };

                        var itemsReplace = strings[++i].Replace(",", "");
                        string[] itemsStr = itemsReplace.Trim().Split(' ');
                        List<string> items = new List<string>();
                        for (int j = 2; j < itemsStr.Length; j++)
                        {
                            items.Add(itemsStr[j]);
                        }

                        var operationStr = strings[++i].Trim().Split(' ');
                        List<string> operation = new List<string>();
                        for (int j = 3; j < operationStr.Length; j++)
                        {
                            operation.Add(operationStr[j]);
                        }

                        var testStr = strings[++i].Trim().Split(' ');
                        List<string> test = new List<string>();
                        for(int j = 1; j < testStr.Length; j++)
                        {
                            test.Add(testStr[j]);
                        }

                        string trueStr = strings[++i].Trim().Split(' ')[5];
                        string falseStr = strings[++i].Trim().Split(' ')[5];
                        List<string> condition = new List<string> { trueStr, falseStr };

                        monkey.Add(id); // 0
                        monkey.Add(items); // 1
                        monkey.Add(operation); // 2
                        monkey.Add(test); // 3
                        monkey.Add(condition); // 4
                    }
                    list.Add(monkey);
                }
            }

            Problem11 problem11 = new Problem11();
            #endregion

            #region Act
            var mostActive = problem11.FindMostActiveLong(list);
            #endregion

            #region Assert
            Assert.AreEqual(11309046332, mostActive);
            #endregion
        }
    }
}
