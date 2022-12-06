using System.Text;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem02Tests
    {
        [TestMethod]
        public void GameScoreTop()
        {
            #region Arrange
            string text;
            using (var streamReader = new StreamReader(Helper.GetFilePath("problem02input.txt"), Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

            text = text.Replace("\r", "");
            string[] strings = text.Split(new char[] { '\n' });

            List<IList<char>> list = new List<IList<char>>();

            List<char> newList = new List<char>();

            foreach (string s in strings)
            {
                if (s == string.Empty)
                {
                    break;
                }
                newList.Add(s[0]);
                newList.Add(s[2]);
                list.Add(newList);
                newList = new List<char>();
            }

            Problem02 problem02= new Problem02();
            #endregion

            #region Act
            var score = problem02.GameScore(list);
            #endregion

            #region Assert
            Assert.AreEqual(13221, score);
            #endregion
        }

        [TestMethod]
        public void GameScore2()
        {
            #region Arrange
            string text;
            using (var streamReader = new StreamReader(Helper.GetFilePath("problem02input.txt"), Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

            text = text.Replace("\r", "");
            string[] strings = text.Split(new char[] { '\n' });

            List<IList<char>> list = new List<IList<char>>();

            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "abc.txt"); List<char> newList = new List<char>();

            foreach (string s in strings)
            {
                if (s == string.Empty)
                {
                    break;
                }
                newList.Add(s[0]);
                newList.Add(s[2]);
                list.Add(newList);
                newList = new List<char>();
            }

            Problem02 problem02 = new Problem02();
            #endregion

            #region Act
            var score = problem02.GameScore2(list);
            #endregion

            #region Assert
            Assert.AreEqual(13131, score);
            #endregion
        }
    }
}
