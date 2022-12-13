namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem13Tests
    {
        [TestMethod]
        public void RightOrderTest1()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem13test1.txt");
            List<IList<string>> list = new List<IList<string>>();

            for (int i = 0; i < strings.Length; i++)
            {
                var left = strings[i];
                if (left != string.Empty)
                {
                    List<string> pair = new List<string>();
                    pair.Add(left);
                    pair.Add(strings[++i]);
                    list.Add(pair);
                }
            }

            Problem13 problem13 = new Problem13();
            #endregion

            #region Act
            var sum = problem13.RightOrder(list);
            #endregion

            #region Assert
            Assert.AreEqual(13, sum);
            #endregion
        }

        [TestMethod]
        public void RightOrderInput()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem13input.txt");
            List<IList<string>> list = new List<IList<string>>();

            for (int i = 0; i < strings.Length; i++)
            {
                var left = strings[i];
                if (left != string.Empty)
                {
                    List<string> pair = new List<string>();
                    pair.Add(left);
                    pair.Add(strings[++i]);
                    list.Add(pair);
                }
            }

            Problem13 problem13 = new Problem13();
            #endregion

            #region Act
            var sum = problem13.RightOrder(list);
            #endregion

            #region Assert
            Assert.AreEqual(5350, sum);
            #endregion
        }

        [TestMethod]
        public void SortOrderTest1()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem13test1.txt");
            List<IList<string>> list = new List<IList<string>>();

            for (int i = 0; i < strings.Length; i++)
            {
                var left = strings[i];
                if (left != string.Empty)
                {
                    List<string> pair = new List<string>();
                    pair.Add(left);
                    pair.Add(strings[++i]);
                    list.Add(pair);
                }
            }

            Problem13 problem13 = new Problem13();
            #endregion

            #region Act
            var sum = problem13.SortOrder(list);
            #endregion

            #region Assert
            Assert.AreEqual(140, sum);
            #endregion
        }

        [TestMethod]
        public void SortOrderInput()
        {
            #region Arrange

            string[] strings = Helper.GetText("problem13input.txt");
            List<IList<string>> list = new List<IList<string>>();

            for (int i = 0; i < strings.Length; i++)
            {
                var left = strings[i];
                if (left != string.Empty)
                {
                    List<string> pair = new List<string>();
                    pair.Add(left);
                    pair.Add(strings[++i]);
                    list.Add(pair);
                }
            }

            Problem13 problem13 = new Problem13();
            #endregion

            #region Act
            var sum = problem13.SortOrder(list);
            #endregion

            #region Assert
            Assert.AreEqual(19570, sum);
            #endregion
        }

    }
}
