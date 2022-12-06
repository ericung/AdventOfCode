using System.Text;

namespace AdventOfCode2022.Tests
{
    public static class Helper
    {
        public static string GetFilePath(string fileName)
        {
            string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Files/" + fileName);
            return path;
        }

        public static string[] GetText(string fileName)
        {
            string text;
            using (var streamReader = new StreamReader(Helper.GetFilePath(fileName), Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

            text = text.Replace("\r", "");
            string[] strings = text.Split(new char[] { '\n' });

            return strings;
        }
    }
}
