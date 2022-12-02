using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (var streamReader = new StreamReader(@"C:\Users\eric.ung\source\repos\AdventOfCode\AdventOfCode2022.Tests\Files\problem02input.txt", Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

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
            Assert.AreEqual(score, 13221);
            #endregion
        }

        [TestMethod]
        public void GameScore2()
        {
            #region Arrange
            string text;
            using (var streamReader = new StreamReader(@"C:\Users\eric.ung\source\repos\AdventOfCode\AdventOfCode2022.Tests\Files\problem02input.txt", Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

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

            Problem02 problem02 = new Problem02();
            #endregion

            #region Act
            var score = problem02.GameScore2(list);
            #endregion

            #region Assert
            Assert.AreEqual(score, 13131);
            #endregion
        }
    }
}
