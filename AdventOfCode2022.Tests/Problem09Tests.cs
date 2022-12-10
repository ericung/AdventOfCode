namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem09Tests
    {
        [TestMethod]
        public void LocationsCoveredTest1()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem09test1.txt");
            List<(char, int)> list = new List<(char, int)>();

            foreach (string s in strings)
            {
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    var tuple = ('0', 0);
                    foreach (string l in line)
                    {
                        tuple = (line[0][0], Convert.ToInt32(line[1]));
                    }
                    list.Add(tuple);
                }
                else
                {
                    break;
                }
            }

            Problem09 problem09 = new Problem09();
            #endregion

            #region Act
            var positions = problem09.LocationsCovered(list);
            #endregion

            #region Assert
            Assert.AreEqual(13, positions);
            #endregion
        }

        [TestMethod]
        public void LocationsCoveredInput()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem09input.txt");
            List<(char, int)> list = new List<(char, int)>();

            foreach (string s in strings)
            {
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    var tuple = ('0', 0);
                    foreach (string l in line)
                    {
                        tuple = (line[0][0], Convert.ToInt32(line[1]));
                    }
                    list.Add(tuple);
                }
                else
                {
                    break;
                }
            }

            Problem09 problem09 = new Problem09();
            #endregion

            #region Act
            var positions = problem09.LocationsCovered(list);
            #endregion

            #region Assert
            Assert.AreEqual(6026, positions);
            #endregion
        }

        [TestMethod]
        public void LocationsCovered2Test1()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem09test1.txt");
            List<(char, int)> list = new List<(char, int)>();

            foreach (string s in strings)
            {
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    var tuple = ('0', 0);
                    foreach (string l in line)
                    {
                        tuple = (line[0][0], Convert.ToInt32(line[1]));
                    }
                    list.Add(tuple);
                }
                else
                {
                    break;
                }
            }

            Problem09 problem09 = new Problem09();
            #endregion

            #region Act
            var positions = problem09.LocationsCovered2(list);
            #endregion

            #region Assert
            Assert.AreEqual(1, positions);
            #endregion
        }

        [TestMethod]
        public void LocationsCovered2Test2()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem09test2.txt");
            List<(char, int)> list = new List<(char, int)>();

            foreach (string s in strings)
            {
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    var tuple = ('0', 0);
                    foreach (string l in line)
                    {
                        tuple = (line[0][0], Convert.ToInt32(line[1]));
                    }
                    list.Add(tuple);
                }
                else
                {
                    break;
                }
            }

            Problem09 problem09 = new Problem09();
            #endregion

            #region Act
            var positions = problem09.LocationsCovered2(list);
            #endregion

            #region Assert
            Assert.AreEqual(36, positions);
            #endregion
        }

        [TestMethod]
        public void LocationsCovered2Input()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem09input.txt");
            List<(char, int)> list = new List<(char, int)>();

            foreach (string s in strings)
            {
                if (s != string.Empty)
                {
                    string[] line = s.Split(' ');
                    var tuple = ('0', 0);
                    foreach (string l in line)
                    {
                        tuple = (line[0][0], Convert.ToInt32(line[1]));
                    }
                    list.Add(tuple);
                }
                else
                {
                    break;
                }
            }

            Problem09 problem09 = new Problem09();
            #endregion

            #region Act
            var positions = problem09.LocationsCovered2(list);
            #endregion

            #region Assert
            Assert.AreEqual(2273, positions);
            #endregion
        }
    }
}
