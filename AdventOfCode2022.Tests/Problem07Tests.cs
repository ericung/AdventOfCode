namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem07Tests
    {
        [TestMethod]
        public void FindSumTest1Success()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem07test1.txt");
            List<string[]> list = new List<string[]>();

            foreach(string s in strings)
            {
                list.Add(s.Split(' '));
            }
            Problem07 problem = new Problem07();
            #endregion

            #region Act
            long sum = problem.FindSum(list);
            #endregion

            #region Assert
            Assert.AreEqual(95437, sum);
            #endregion
        }

        [TestMethod]
        public void FindSumInputSuccess()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem07input.txt");
            List<string[]> list = new List<string[]>();

            foreach(string s in strings)
            {
                list.Add(s.Split(' '));
            }
            Problem07 problem = new Problem07();
            #endregion

            #region Act
            long sum = problem.FindSum(list);
            #endregion

            #region Assert
            Assert.AreEqual(1297683, sum);
            #endregion
        }

        [TestMethod]
        public void FindDirectoryTest1Success()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem07test1.txt");
            List<string[]> list = new List<string[]>();

            foreach(string s in strings)
            {
                list.Add(s.Split(' '));
            }
            Problem07 problem = new Problem07();
            #endregion

            #region Act
            long sum = problem.FindDirectory(list);
            #endregion

            #region Assert
            Assert.AreEqual(24933642, sum);
            #endregion
        }

        [TestMethod]
        public void FindDirectoryInputSuccess()
        {
            #region Arrange
            string[] strings = Helper.GetText("problem07input.txt");
            List<string[]> list = new List<string[]>();

            foreach(string s in strings)
            {
                list.Add(s.Split(' '));
            }
            Problem07 problem = new Problem07();
            #endregion

            #region Act
            long sum = problem.FindDirectory(list);
            #endregion

            #region Assert
            Assert.AreEqual(5756764, sum);
            #endregion
        }

    }
}
