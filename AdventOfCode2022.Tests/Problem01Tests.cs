using System.Text;

namespace AdventOfCode2022.Tests
{
    [TestClass]
    public class Problem01Tests
    {
        [TestMethod]
        public void FirstTopCalories()
        {
            #region Arrange
            string text;
            using (var streamReader = new StreamReader(Helper.GetFilePath("input.txt"), Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

            text = text.Replace("\r", "");
            string[] strings = text.Split(new char[] { '\n' });

            List<IList<int>> list = new List<IList<int>>();

            List<int> newList = new List<int>();

            foreach(string s in strings)
            {
                if (s != string.Empty)
                {
                    newList.Add(Convert.ToInt32(s));
                }
                else
                {
                    list.Add(newList);
                    newList= new List<int>();
                }
            }

            Problem01 problem01 = new Problem01();
            #endregion

            #region Act
            var calories = problem01.CalorieCount(list);
            #endregion

            #region Assert
            Assert.AreEqual(71506, calories);
            #endregion
        }

        [TestMethod]
        public void TopThreeCalories()
        {
            #region Arrange
            string text;
            using (var streamReader = new StreamReader(Helper.GetFilePath("input.txt"), Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

            text = text.Replace("\r", "");
            string[] strings = text.Split(new char[] { '\n' });

            List<IList<int>> list = new List<IList<int>>();

            List<int> newList = new List<int>();

            foreach (string s in strings)
            {
                if (s != string.Empty)
                {
                    newList.Add(Convert.ToInt32(s));
                }
                else
                {
                    list.Add(newList);
                    newList = new List<int>();
                }
            }

            Problem01 problem01 = new Problem01();
            #endregion

            #region Act
            var calories = problem01.CalorieCountTopThree(list);
            #endregion

            #region Assert
            Assert.AreEqual(209603, calories);
            #endregion
        }
    }
}