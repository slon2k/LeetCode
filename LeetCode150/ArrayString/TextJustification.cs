using System.Text;

namespace LeetCode.LeetCode150.ArrayString;

public class TextJustification
{
    public class Solution
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<List<string>> lines = new() {};

            int count = maxWidth;

            foreach (string word in words)
            {
                if (count + word.Length + 1 <= maxWidth)
                {
                    lines[^1].Add(word);
                    count += word.Length + 1;
                } else
                {
                    lines.Add(new() { word });
                    count = word.Length;
                }
            }

            List<string> result = new();

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Count == 1 || i == lines.Count - 1)
                {
                    result.Add(JustifyLeft(lines[i], maxWidth));
                } else
                {
                    result.Add(JustifyCenter(lines[i], maxWidth));
                }
            }

            return result;
        }

        private static string JustifyCenter(List<string> list, int maxWidth)
        {
            var result = new List<string>();
            int width = Width(list);
            int spacesCount = (maxWidth - width) / (list.Count - 1);
            string spaces = Spaces(spacesCount);

            foreach (string word in list)
            {
                result.Add(word);
                result.Add(spaces);
            }

            result.RemoveAt(result.Count - 1);

            for (int i = 1; i < result.Count; i++)
            {
                if (Width(result) == maxWidth)
                {
                    break;
                }

                if (result[i][0] == ' ')
                {
                    result[i] += ' ';
                }
            }

            return string.Join("", result);
        }

        private static int Width(List<string> list) => list.Select(l => l.Length).Sum();

        private static string JustifyLeft(List<string> list, int maxWidth)
        {
            string str = string.Join(" ", list);

            while (str.Length < maxWidth)
            {
                str += " ";
            }

            return str;
        }

        private static string Spaces(int length)
        {
            var result = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                result.Append(' ');
            }

            return result.ToString();
        }
    }
}
